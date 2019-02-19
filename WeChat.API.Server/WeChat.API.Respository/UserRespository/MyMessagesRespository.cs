using Dapper;
using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeChat.API.IRespository.IUserRespository;
using WeChat.API.Model.User;

namespace WeChat.API.Respository.UserRespository
{
    public class MyMessagesRespository: IMyMessagesRespository
    {
        public static IDbConnection conn = new OracleConnection(ConfigurationManager.ConnectionStrings["OraclConn"].ToString());

        public List<MyMessage> GetMyMessage()
        {
            var myMessage = conn.Query<MyMessage>("select * from MYMESSAGES");
            return myMessage.ToList();
        }
    }
}
