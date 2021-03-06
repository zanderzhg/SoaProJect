﻿using FytIms.Service.Extensions;
using FytSoa.Common;
using FytSoa.Core;
using FytSoa.Core.Model.Erp;
using FytSoa.Core.Model.Sys;
using FytSoa.Service.DtoModel;
using FytSoa.Service.Interfaces;
using Newtonsoft.Json;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FytSoa.Service.Implements
{
    public class ErpInOutLogService : DbContext, IErpInOutLogService
    {
        /// <summary>
        /// 批量添加数据
        /// </summary>
        /// <returns></returns>
        public async Task<ApiResult<string>> AddBatchAsync(string guid, string json, string adminGuid)
        {
            var res = new ApiResult<string>() { data = "1", statusCode = (int)ApiEnum.Error };
            try
            {
                if (string.IsNullOrEmpty(json))
                {
                    res.message = "商品不能为空~";
                    return await Task.Run(() => res);
                }
                var packModel = ErpPackLogDb.GetById(guid);
                //解析字符串转换成List对象
                var goodsList = JsonConvert.DeserializeObject<List<ErpInOutLog>>(json);
                //根据条形码查询平台库存的数据
                var codeList = goodsList.Select(m=>m.GoodsGuid).ToList();
                var skuList = ErpGoodsSkuDb.GetList(m=>codeList.Contains(m.Guid));
                //定义一个值，判断条形码里面没有的数据数量
                var noSkuCount = 0;
                //根据条形码，查询商家库存信息
                var shopSkuList = new List<ErpShopSku>();
                //一个新的商家库存信息
                var newShopSkuList = new List<ErpShopSku>();
                //只有在出库的时候查询，入库不处理
                if (packModel.Types==2)
                {
                    shopSkuList = ErpShopSkuDb.GetList(m=> codeList.Contains(m.SkuGuid) && m.ShopGuid==packModel.ShopGuid);
                }
                //循环平台数据，减少相应的库存
                foreach (var item in skuList)
                {
                    var goodsModel = goodsList.Find(m=>m.GoodsGuid==item.Guid);
                    //出库
                    if (goodsModel!=null && packModel.Types==2)
                    {
                        item.StockSum = item.StockSum - goodsModel.GoodsSum;
                        //根据条形码判断商家库存是否存在，如果存在，修改库存信息，不存在增加一条新的库存信息
                        if (shopSkuList.Count>0)
                        {
                            var shopSkuModel = shopSkuList.Find(m=>m.SkuGuid==item.Guid);
                            if (shopSkuModel!=null)
                            {
                                shopSkuList.Find(m => m.SkuGuid == item.Guid).Stock = shopSkuModel.Stock + goodsModel.GoodsSum;
                            }
                            else
                            {
                                newShopSkuList.Add(new ErpShopSku() {
                                    Guid = Guid.NewGuid().ToString(),
                                    SkuGuid = item.Guid,
                                    SkuCode = item.Code,
                                    ShopGuid = packModel.ShopGuid,
                                    Stock = goodsModel.GoodsSum
                                });
                            }
                        }
                        else
                        {
                            newShopSkuList.Add(new ErpShopSku()
                            {
                                Guid = Guid.NewGuid().ToString(),
                                SkuGuid = item.Guid,
                                SkuCode = item.Code,
                                ShopGuid = packModel.ShopGuid,
                                Stock = goodsModel.GoodsSum
                            });
                        }
                    }
                    //入库
                    else if (goodsModel != null && packModel.Types == 1)
                    {
                        item.StockSum = item.StockSum + goodsModel.GoodsSum;
                    }
                    else
                    {
                        noSkuCount++;
                    }
                }
                if (noSkuCount!=0)
                {
                    res.message = "添加的商品在平台没有查询到~";
                    return await Task.Run(() => res);
                }
                //循环构造出入库详情数据
                foreach (var item in goodsList)
                {
                    item.Guid = Guid.NewGuid().ToString();
                    item.Types = packModel.Types;
                    item.InTypes = 1;
                    item.PackGuid = packModel.Guid;
                    item.ShopGuid = packModel.ShopGuid;
                    item.AdminGuid = adminGuid;
                    item.AddDate = DateTime.Now;
                }
                packModel.GoodsSum += goodsList.Sum(m=>m.GoodsSum);
                var result = Db.Ado.UseTran(() =>
                {
                    //修改打包的数量
                    Db.Updateable(packModel).ExecuteCommand();
                    //添加该打包日志下面的商品
                    Db.Insertable(goodsList).ExecuteCommand();
                    //修改平台库存数量
                    Db.Updateable(skuList).ExecuteCommand();
                    if (packModel.Types==2)
                    {
                        if (shopSkuList.Count>0)
                        {
                            Db.Updateable(shopSkuList).ExecuteCommand();
                        }
                        if (newShopSkuList.Count>0)
                        {
                            Db.Insertable(newShopSkuList).ExecuteCommand();
                        }
                    }
                });
                res.statusCode = (int)ApiEnum.Status;
                if (!result.IsSuccess)
                {
                    res.statusCode = (int)ApiEnum.Error;
                    res.message = result.ErrorMessage;
                }
            }
            catch (Exception ex)
            {
                res.message = ApiEnum.Error.GetEnumText() + ex.Message;
            }
            return await Task.Run(() => res);
        }

        /// <summary>
        /// 添加一条数据
        /// </summary>
        /// <returns></returns>
        public async Task<ApiResult<string>> AddAsync(ErpInOutLog parm)
        {
            var res = new ApiResult<string>() { statusCode = 200 };
            try
            {
                //判断条形码是否存在
                var skuModel = ErpGoodsSkuDb.GetSingle(m => m.Code == parm.GoodsSku && !m.IsDel);
                if (skuModel == null)
                {
                    res.statusCode = (int)ApiEnum.ParameterError;
                    res.message = "该条形码不存在~";
                    return await Task.Run(() => res);
                }
                if (parm.Types==2)
                {
                    //出库  需要判断库存是否足够
                    if (skuModel.StockSum < parm.GoodsSum)
                    {
                        res.statusCode = (int)ApiEnum.ParameterError;
                        res.message = "库存不足,只剩下" + skuModel.StockSum + "件~";
                        return await Task.Run(() => res);
                    }
                }
                parm.Guid = Guid.NewGuid().ToString();
                parm.GoodsGuid = skuModel.Guid;
                //开启事务
                Db.Ado.BeginTran();
                if (parm.Types == 1)
                {
                    //更新该条形码的库存
                    ErpGoodsSkuDb.Update(m => new ErpGoodsSku() { StockSum = m.StockSum + parm.GoodsSum }, m => m.Guid == parm.GoodsGuid);
                }
                else
                {
                    //更新平台的库存，减少
                    ErpGoodsSkuDb.Update(m => new ErpGoodsSku() { StockSum = m.StockSum - parm.GoodsSum }, m => m.Guid == parm.GoodsGuid);
                    //增加到店铺条形码表中
                    var shopSku = ErpShopSkuDb.GetSingle(m=>m.ShopGuid==parm.ShopGuid && m.SkuGuid== parm.GoodsGuid);
                    if (shopSku!=null)
                    {
                        //修改，增加库存
                        ErpShopSkuDb.Update(m=>new ErpShopSku() { Stock=m.Stock+parm.GoodsSum,UpdateDate=DateTime.Now},m=>m.ShopGuid==parm.ShopGuid && m.SkuGuid== parm.GoodsGuid);
                    }
                    else
                    {
                        //增加一条库存
                        var shopSkuModel = new ErpShopSku()
                        {
                            Guid=Guid.NewGuid().ToString(),
                            SkuGuid=skuModel.Guid,
                            SkuCode=skuModel.Code,
                            ShopGuid=parm.ShopGuid,
                            Stock=parm.GoodsSum
                        };
                        ErpShopSkuDb.Insert(shopSkuModel);
                    }
                }
                ErpInOutLogDb.Insert(parm);
                Db.Ado.CommitTran();
            }
            catch (Exception ex)
            {
                Db.Ado.CommitTran();
                res.statusCode = (int)ApiEnum.Error;
                res.message = ApiEnum.Error.GetEnumText() + ex.Message;
            }
            return await Task.Run(() => res);
        }

        /// <summary>
        /// 删除一条或多条数据
        /// </summary>
        /// <returns></returns>
        public async Task<ApiResult<string>> DeleteAsync(string parm)
        {
            var res = new ApiResult<string>() { data = "1", statusCode = (int)ApiEnum.Error };
            try
            {
                var list = Utils.StrToListString(parm);
                //根据主键查询详细
                var inoutList = ErpInOutLogDb.GetList(m => list.Contains(m.Guid));
                //获得条形码数据
                var codeList = inoutList.Select(m => m.GoodsGuid).ToList();
                var skuList = ErpGoodsSkuDb.GetList(m => codeList.Contains(m.Guid));
                //定义一个值，判断条形码里面没有的数据数量
                var noSkuCount = 0;
                //获得打包日志的ID
                var packGuid = "";
                //循环平台数据，减少相应的库存
                foreach (var item in skuList)
                {
                    var goodsModel = inoutList.Find(m => m.GoodsGuid == item.Guid);
                    packGuid = goodsModel.PackGuid;
                    if (goodsModel != null && goodsModel.Types == 2)
                    {
                        item.StockSum = item.StockSum + goodsModel.GoodsSum;
                    }
                    else if (goodsModel != null && goodsModel.Types == 1)
                    {
                        item.StockSum = item.StockSum - goodsModel.GoodsSum;
                    }
                    else
                    {
                        noSkuCount++;
                    }
                }
                if (noSkuCount != 0)
                {
                    res.message = "删除的商品在平台没有查询到~";
                    return await Task.Run(() => res);
                }

                var result = Db.Ado.UseTran(() =>
                {
                    //删除出入库信息
                    Db.Deleteable(inoutList).ExecuteCommand();
                    //修改平台库存数量
                    Db.Updateable(skuList).ExecuteCommand();
                    //根据打包ID获得下面商品的总数
                    var packInOutCount = Db.Queryable<ErpInOutLog>().Where(m => m.PackGuid == packGuid).Sum(m => m.GoodsSum);
                    //更新打包日志数量
                    Db.Updateable<ErpPackLog>().UpdateColumns(m => new ErpPackLog() { GoodsSum = packInOutCount }).Where(m => m.Guid == packGuid).ExecuteCommand();
                });
                res.statusCode = (int)ApiEnum.Status;
                if (!result.IsSuccess)
                {
                    res.statusCode = (int)ApiEnum.Error;
                    res.message = result.ErrorMessage;
                }
            }
            catch (Exception ex)
            {
                res.message = ApiEnum.Error.GetEnumText() + ex.Message;
            }
            return await Task.Run(() => res);
        }

        /// <summary>
        /// 获得一条数据
        /// </summary>
        /// <returns></returns>
        public async Task<ApiResult<ErpInOutLog>> GetByGuidAsync(string parm)
        {
            var model = ErpInOutLogDb.GetById(parm);
            var res = new ApiResult<ErpInOutLog>
            {
                statusCode = 200,
                data = model ?? new ErpInOutLog() { }
            };
            return await Task.Run(() => res);
        }

        /// <summary>
        /// 分页
        /// </summary>
        /// <param name="parm"></param>
        /// <returns></returns>
        public async Task<ApiResult<Page<GoodsSkuDto>>> GetPagesAsync(PageParm parm, SearchParm searchParm)
        {
            var res = new ApiResult<Page<GoodsSkuDto>>();
            try
            {
                var query = Db.Queryable<ErpInOutLog>()
                        .WhereIF(parm.types != 0, m => m.Types == parm.types)
                        .WhereIF(!string.IsNullOrEmpty(parm.key), 
                        m => SqlFunc.Subqueryable<ErpGoodsSku>().Where(g => g.Guid == m.GoodsGuid).Select(g => g.Code).Contains(parm.key))
                        .WhereIF(!string.IsNullOrEmpty(parm.guid), m => m.ShopGuid == parm.guid)
                        .WhereIF(!string.IsNullOrEmpty(searchParm.brank), 
                        m => SqlFunc.Subqueryable<ErpGoodsSku>().Where(g => g.Guid == m.GoodsGuid).Select(g => g.BrankGuid) == searchParm.brank)
                        .Where(m => m.PackGuid == searchParm.packGuid)
                        .OrderBy(m=>m.GoodsSum,OrderByType.Asc)
                        .Select(m=>new GoodsSkuDto() {
                            Guid=m.Guid,
                            Code=m.GoodsSku,
                            StockSum=m.GoodsSum,
                            AddDate=m.AddDate,
                            BrankName= SqlFunc.Subqueryable<SysCode>().Where(g => g.Guid == SqlFunc.Subqueryable<ErpGoodsSku>().Where(t => t.Guid == m.GoodsGuid).Select(t => t.BrankGuid)).Select(g => g.Name),
                            StyleName= SqlFunc.Subqueryable<SysCode>().Where(g => g.Guid == SqlFunc.Subqueryable<ErpGoodsSku>().Where(t => t.Guid == m.GoodsGuid).Select(t => t.StyleGuid)).Select(g => g.Name)
                        })
                        .ToPageAsync(parm.page, parm.limit);
                res.success = true;
                res.message = "获取成功！";
                res.data = await query;
            }
            catch (Exception ex)
            {
                res.message = ApiEnum.Error.GetEnumText() + ex.Message;
                res.statusCode = (int)ApiEnum.Error;
            }
            return await Task.Run(() => res);
        }

        /// <summary>
        /// 获得列表,根据出库商家查询，调拨用
        /// </summary>
        /// <param name="parm"></param>
        /// <returns></returns>
        public async Task<ApiResult<Page<GoodsSkuDto>>> GetByInOutShopPagesAsync(PageParm parm, string outShopGuid)
        {
            var res = new ApiResult<Page<GoodsSkuDto>>();
            try
            {
                //根据出库商家，查询该商家下面的所有商品
                var querys = Db.Queryable<ErpInOutLog, ErpGoodsSku>((log, sku) => new object[] { JoinType.Left, log.GoodsGuid == sku.Guid })
                        .Where((log, sku) => log.Types == 2 && log.GoodsSum > 0 && log.ShopGuid == outShopGuid)
                        .WhereIF(!string.IsNullOrEmpty(parm.key), (log, sku) => sku.Code == parm.key)
                        .WhereIF(!string.IsNullOrEmpty(parm.guid), (log, sku) => sku.BrankGuid == parm.guid)
                        .OrderBy((log, sku) => log.AddDate, OrderByType.Desc)
                        .Select((log, sku) => new GoodsSkuDto()
                        {
                            Guid = sku.Guid,
                            Code = sku.Code,
                            BrankName = SqlFunc.Subqueryable<SysCode>().Where(g => g.Guid == sku.BrankGuid).Select(g => g.Name),
                            StyleName = SqlFunc.Subqueryable<SysCode>().Where(g => g.Guid == sku.StyleGuid).Select(g => g.Name),
                            SeasonName = SqlFunc.Subqueryable<SysCode>().Where(g => g.Guid == sku.SeasonGuid).Select(g => g.Name),
                            SalePrice = sku.SalePrice,
                            DisPrice = sku.DisPrice,
                            StockSum = log.GoodsSum,
                            SaleSum = sku.SaleSum,
                            AddDate = sku.AddDate
                        });                    
                var str = querys.ToSql();
                var query = querys.ToPageAsync(parm.page, parm.limit);
                res.success = true;
                res.message = "获取成功！";
                res.data = await query;
            }
            catch (Exception ex)
            {
                res.message = ApiEnum.Error.GetEnumText() + ex.Message;
                res.statusCode = (int)ApiEnum.Error;
            }
            return await Task.Run(() => res);
        }

        /// <summary>
        /// 修改一条数据
        /// </summary>
        /// <returns></returns>
        public async Task<ApiResult<string>> ModifyAsync(ErpInOutLog parm)
        {
            var res = new ApiResult<string>() { data = "1", statusCode = 200 };
            try
            {
                //判断条形码是否存在
                var isExt = ErpGoodsSkuDb.IsAny(m => m.Guid == parm.GoodsGuid && !m.IsDel);
                if (!isExt)
                {
                    res.statusCode = (int)ApiEnum.ParameterError;
                    res.message = "该条形码不存在~";
                }
                else
                {
                    var dbres = ErpInOutLogDb.Update(parm);
                    if (!dbres)
                    {
                        res.statusCode = (int)ApiEnum.Error;
                        res.message = "修改数据失败~";
                    }
                }                
            }
            catch (Exception ex)
            {
                res.statusCode = (int)ApiEnum.Error;
                res.message = ApiEnum.Error.GetEnumText() + ex.Message;
            }
            return await Task.Run(() => res);
        }
    }
}
