using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WeChat.API.Model.brand;
using WeChat.API.IRespository.IbrandRespository;
using Dapper;
using System.Data;
using System.Configuration;
using Oracle.DataAccess.Client;

namespace WeChat.API.Respository.BrandRespository
{
    public class BranCarsRespository : IbranCarsRespository
    {
        public static IDbConnection conn = new OracleConnection(ConfigurationManager.ConnectionStrings["OraclConn"].ToString());
        /// <summary>
        /// 展示汽车品牌下的详细车辆
        /// </summary>
        /// <returns></returns>

        public List<Brancars> GetbranCars(int id)
        {
            string sql = "select * from brancars where carsid=" + id;
            var carBrandsList = conn.Query<Brancars>(sql);
            return carBrandsList.ToList();
        }
    }
}
