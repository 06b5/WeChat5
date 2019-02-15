﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Autofac;
using WeChat.API.IRespository.IndexIRespository;
using WeChat.API.IRespository.RankingIRespository;
using WeChat.API.Respository.IndexRespository;
using WeChat.API.Respository.RankingRespoistory;
using Autofac.Integration.WebApi;
using System.Reflection;
using System.Web.Http;
using System.Web.Mvc;
using Autofac.Integration.Mvc;
using WeChat.API.IRespository;
using WeChat.API.Respository;

namespace WeChat.API.Server.App_Start
{
    public class AutofacConfig
    {
        /// <summary>
        /// 项目初始化 实例化IOC容器
        /// </summary>
        public static void Register()
        {
            var bulider = new ContainerBuilder();
            SetUpd(bulider);

            //注测所有的Apicontrollers
            bulider.RegisterApiControllers(Assembly.GetExecutingAssembly()).PropertiesAutowired();
            var contaniner = bulider.Build();

            //注测api容器使用的httpconfiguration对象
            HttpConfiguration config = GlobalConfiguration.Configuration;
            config.DependencyResolver = new AutofacWebApiDependencyResolver(contaniner);
            DependencyResolver.SetResolver(new AutofacDependencyResolver(contaniner));
        }
        /// <summary>
        /// 将实现类和接口注入到ioc容器中
        /// </summary>
        /// <param name="container"></param>
        public static void SetUpd(ContainerBuilder container)
        {
            //首页新闻
            container.RegisterType<indexNewsRespository>().As<IindexNewsRespository>();
            //地区论坛
            container.RegisterType<AddrForumIndexRespository>().As<IAddrForumIndexRespository>();
            //首页新闻详情
            container.RegisterType<indexNewsPingRespository>().As<IindexNewsPingRespository>();
            //汽车排行
            container.RegisterType<ToprankingRespoistory>().As<ItoprankingRespository>();
        }
    }
}