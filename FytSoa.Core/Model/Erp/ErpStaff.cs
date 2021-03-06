﻿using System;
using System.Linq;
using System.Text;

namespace FytSoa.Core.Model.Erp
{
    ///<summary>
    /// 店铺员工表
    ///</summary>
    public partial class ErpStaff
    {
        public ErpStaff()
        {


        }
        /// <summary>
        /// Desc:唯一编号
        /// Default:
        /// Nullable:False
        /// </summary>           
        public string Guid { get; set; }

        /// <summary>
        /// Desc:所属店铺（可以是总店）
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string ShopGuid { get; set; }

        /// <summary>
        /// Desc:员工登录账号
        /// Default:
        /// Nullable:False
        /// </summary>           
        public string LoginName { get; set; }

        /// <summary>
        /// Desc:登录密码
        /// Default:
        /// Nullable:False
        /// </summary>           
        public string LoginPwd { get; set; }

        /// <summary>
        /// Desc:真实姓名
        /// Default:
        /// Nullable:False
        /// </summary>           
        public string TrueName { get; set; }

        /// <summary>
        /// Desc:手机号码
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string Mobile { get; set; }

        /// <summary>
        /// Desc:性别
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string Sex { get; set; } = "男";

        /// <summary>
        /// Desc:状态 0=正常 1=账号冻结 2=离职
        /// Default:
        /// Nullable:False
        /// </summary>           
        public byte Status { get; set; } = 0;

        /// <summary>
        /// 推送用的到token
        /// </summary>
        public string Token { get; set; }

        /// <summary>
        /// 设备类型，是苹果还是安卓  0=苹果 1=安卓
        /// </summary>
        public int IsDevice { get; set; }

        /// <summary>
        /// 设备类型名称，是苹果还是安卓
        /// </summary>
        public string DeviceName { get; set; }

        /// <summary>
        /// Desc:添加时间
        /// Default:
        /// Nullable:False
        /// </summary>           
        public DateTime AddDate { get; set; } = DateTime.Now;

        /// <summary>
        /// Desc:登录次数
        /// Default:0
        /// Nullable:False
        /// </summary>           
        public int LoginCount { get; set; } = 1;

        /// <summary>
        /// Desc:最后一次登录时间
        /// Default:
        /// Nullable:True
        /// </summary>           
        public DateTime? LastLoginDate { get; set; }

        /// <summary>
        /// Desc:上次登录时间
        /// Default:
        /// Nullable:True
        /// </summary>           
        public DateTime? UpLoginDate { get; set; }

    }
}
