using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeChat.API.Model.Ranking;
using WeChat.API.IRespository.RankingIRespository;
using System.Data;
using Dapper;
using Oracle.DataAccess.Client;
using System.Configuration;

namespace WeChat.API.Respository.RankingRespoistory
{
    public class ToprankingRespoistory : ItoprankingRespository
    {
        public static IDbConnection conn = new OracleConnection(ConfigurationManager.ConnectionStrings["OraclConn"].ToString());

        public List<Topranking> GetToprankings()
        {
            var toprankingList = conn.Query<Topranking>("select * from topranking");
            return toprankingList.ToList();
        }
    }
}
