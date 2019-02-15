using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeChat.API.Model.Ranking;

namespace WeChat.API.IRespository.RankingIRespository
{
    public interface ItoprankingRespository
    {
        /// <summary>
        /// 热门汽车排行
        /// </summary>
        /// <returns></returns>
        List<Topranking> GetToprankings();
    }
}
