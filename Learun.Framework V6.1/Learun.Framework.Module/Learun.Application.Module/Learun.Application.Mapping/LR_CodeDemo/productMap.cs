﻿using Learun.Application.TwoDevelopment.LR_CodeDemo;
using System.Data.Entity.ModelConfiguration;

namespace  Learun.Application.Mapping
{
    /// <summary>
    /// 版 本 Learun-ADMS V6.1.6.0 力软敏捷开发框架
    /// Copyright (c) 2013-2017 上海力软信息技术有限公司
    /// 创 建：超级管理员
    /// 日 期：2018-05-23 13:06
    /// 描 述：存储过程测试
    /// </summary>
    public class productMap : EntityTypeConfiguration<productEntity>
    {
        public productMap()
        {
            #region 表、主键
            //表
            this.ToTable("PRODUCT");
            //主键
            this.HasKey(t => t.productId);
            #endregion

            #region 配置关系
            #endregion
        }
    }
}

