using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WeChat.API.Model.Pictures;
using WeChat.API.IRespository.IpicturesRespository;
using Dapper;
using System.Data;
using System.Configuration;
using Oracle.DataAccess.Client;

namespace WeChat.API.Respository.PicturesRespository
{
    public class CarPicturesRespository : IcarPicturesRespository
    {
        public static IDbConnection conn = new OracleConnection(ConfigurationManager.ConnectionStrings["OraclConn"].ToString());

        public List<CarPictures> GetCarPictures()
        {
            var carPicturesList = conn.Query<CarPictures>("select * from carpictures");
            return carPicturesList.ToList();
        }
    }
}
