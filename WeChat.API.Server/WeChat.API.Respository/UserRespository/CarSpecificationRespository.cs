using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WeChat.API.Model.brand;
using WeChat.API.IRespository.IbrandRespository;
using System.Data;
using System.Configuration;
using Dapper;
using Oracle.DataAccess.Client;
using WeChat.API.IRespository.IUserRespository;
using WeChat.API.Model.User;

namespace WeChat.API.Respository.UserRespository
{
    public class CarSpecificationRespository : ICarSpecificationRespository
    {

        public static IDbConnection conn = new OracleConnection(ConfigurationManager.ConnectionStrings["OraclConn"].ToString());

        public List<CarSpecification> GetCarSpecification(int id)
        {
            string sql = "select * from CarSpecification where MSLID=" + id;
            var carMessageslist = conn.Query<CarSpecification>(sql);
            return carMessageslist.ToList();
        }
    }
}
