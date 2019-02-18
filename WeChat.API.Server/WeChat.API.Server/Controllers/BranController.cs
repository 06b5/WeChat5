using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using WeChat.API.IRespository.IbrandRespository;
using WeChat.API.Model.brand;

namespace WeChat.API.Server.Controllers
{
    public class BranController : ApiController
    {
        public IcarbrandsRespository icarbrandsRespository { get; set; }
        public IbranCarsRespository ibranCarsRespository { get; set; }

        /// <summary>
        /// 查询汽车品牌
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Carbrands> Getcarbrands()
        {
            var carbrandsList = icarbrandsRespository.GetCarbrands();
            return carbrandsList;
        }

        /// <summary>
        /// 查询汽车品牌下的详细车型
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public List<Brancars> GetBrancars(int id)
        {
            var brancarsList = ibranCarsRespository.GetbranCars(id);
            return brancarsList;
        }
    }
}
