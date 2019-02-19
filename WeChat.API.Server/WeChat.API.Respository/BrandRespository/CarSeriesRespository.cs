using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WeChat.API.Model.brand;
using WeChat.API.IRespository.IbrandRespository;
using System.Data;
using System.Configuration;
using Oracle.DataAccess.Client;
using Dapper;

namespace WeChat.API.Respository.BrandRespository
{
    public class CarSeriesRespository : IcarSeriesRespository
    {
        public static IDbConnection conn = new OracleConnection(ConfigurationManager.ConnectionStrings["OraclConn"].ToString());

        /// <summary>
        /// 具体的哪一款汽车
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<CarSeries> GetCarSeries(int id)
        {
            var sql = "select * from carseries where carmid=" + id;
            var carSeriesList = conn.Query<CarSeries>(sql);
            return carSeriesList.ToList();
        }
    }
}
