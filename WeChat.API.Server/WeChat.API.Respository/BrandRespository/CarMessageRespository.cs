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

namespace WeChat.API.Respository.BrandRespository
{
    public class CarMessageRespository : IcarMessageRespositpry
    {
        public static IDbConnection conn = new OracleConnection(ConfigurationManager.ConnectionStrings["OraclConn"].ToString());

        public List<CarMessage> GetCarMessages(int id)
        {
            string sql = "select * from carmessage where carsid="+id;
            var carMessagesList = conn.Query<CarMessage>(sql);
            return carMessagesList.ToList();
        }
    }
}
