using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WeChat.API.Model.Index;
using WeChat.API.IRespository.IndexIRespository;
using Newtonsoft.Json;

namespace WeChat.API.Server.Controllers
{
    public class IndexController : ApiController
    {
        public IindexNewsRespository indexNewsIRespository { get; set; }

        public IindexNewsPingRespository indexNewsPingRespository { get; set; }

        public IloginRespository iloginRespository { get; set; }
        /// <summary>
        /// 首页新闻
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<IndexNews> GetIndexNews()
        {
            var indexNewsList = indexNewsIRespository.GetIndexNews();
            return indexNewsList;
        }

        /// <summary>
        /// 新闻详情页面
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public List<IndexNewsPing> GetIndexNewsPing(int id)
        {
            var indexNewsPingList = indexNewsPingRespository.GetIndexNewsPing(id);
            return indexNewsPingList;
        }

        [HttpGet]
        public List<login> GetLogins()
        {
            var loginList = iloginRespository.GetLogin();
            return loginList;
        }
    }
}
