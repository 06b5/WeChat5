using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeChat.API.IRespository;
using WeChat.API.IRespository.IUserRespository;
using WeChat.API.Model.User;
using Dapper;
using System.Data;
using Oracle.DataAccess.Client;
using System.Configuration;

namespace WeChat.API.Respository.UserRespository
{
    public class MyShoppingListRespository : IMyShoppingListRespository
    {

        public static IDbConnection conn = new OracleConnection(ConfigurationManager.ConnectionStrings["OraclConn"].ToString());

        public List<MyShoppingList> GetMyShoppingList()
        {
            var myShoppingList = conn.Query<MyShoppingList>("select * from MyShoppingList");
            return myShoppingList.ToList();
        }
    }
}
