using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeChat.API.Model.Index;
using WeChat.API.IRespository.IndexIRespository;
using System.Configuration;
using Oracle.DataAccess.Client;
using System.Data;
using Newtonsoft.Json;
using Dapper;

namespace WeChat.API.Respository.IndexRespository
{
    public class IndexNewsRespository : IindexNewsRespository
    {
        public static IDbConnection conn = new OracleConnection(ConfigurationManager.ConnectionStrings["OraclConn"].ToString());
        /// 实现首页新闻展示的接口
        /// </summary>
        /// <returns></returns>
        public List<IndexNews> GetIndexNews()
        {
            var indexNewsList = conn.Query<IndexNews>("select * from indexnews");
            return indexNewsList.ToList();
        }
    }
}
