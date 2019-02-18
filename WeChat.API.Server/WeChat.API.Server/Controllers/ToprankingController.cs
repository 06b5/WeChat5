using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using WeChat.API.Model.Ranking;
using WeChat.API.IRespository.RankingIRespository;

namespace WeChat.API.Server.Controllers
{
    public class ToprankingController : ApiController
    {
        public ItoprankingRespository itoprankingRespository { get; set; }

        /// <summary>
        /// 汽车热门排行
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Topranking> GetTopranking()
        {
            var toprankingLit = itoprankingRespository.GetToprankings();
            return toprankingLit;
        }
    }
}
