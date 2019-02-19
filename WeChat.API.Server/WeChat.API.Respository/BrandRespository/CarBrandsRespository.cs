using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeChat.API.IRespository.IbrandRespository;
using WeChat.API.Model.brand;

using System.Data;
using Oracle.DataAccess.Client;
using System.Configuration;
using Dapper;

namespace WeChat.API.Respository.BrandRespository
{
    public class CarBrandsRespository : IcarbrandsRespository
    {
        public static IDbConnection conn = new OracleConnection(ConfigurationManager.ConnectionStrings["OraclConn"].ToString()); 

        public List<Carbrands> GetCarbrands()
        {
            var carbrandsList = conn.Query<Carbrands>("select * from carbrands");
            return carbrandsList.ToList();
        }
    }
}
