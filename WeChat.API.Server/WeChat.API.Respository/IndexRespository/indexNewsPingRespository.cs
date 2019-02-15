using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeChat.API.IRespository.IndexIRespository;
using WeChat.API.Model.Index;
using Dapper;
using System.Configuration;
using System.Data;
using Oracle.DataAccess.Client;

namespace WeChat.API.Respository.IndexRespository
{
    public class indexNewsPingRespository : IindexNewsPingRespository
    {
        public static IDbConnection conn = new OracleConnection(ConfigurationManager.ConnectionStrings["OraclConn"].ToString());
        /// <summary>
        /// 新闻详情
        /// </summary>
        /// <returns></returns>
        public List<IndexNewsPing> GetIndexNewsPing(int id)
        {
            string sql = "select* from indexnewsping where newsid =" + id;
            var indexNewsPingList = conn.Query<IndexNewsPing>(sql);
            return indexNewsPingList.ToList();
        }
    }
}
