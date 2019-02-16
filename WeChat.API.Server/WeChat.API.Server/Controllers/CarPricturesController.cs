using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using WeChat.API.Model.Pictures;
using WeChat.API.IRespository.IpicturesRespository;

namespace WeChat.API.Server.Controllers
{
    public class CarPricturesController : ApiController
    {
        public IcarPicturesRespository icarPicturesRespository { get; set; }

        /// <summary>
        /// 名车的显示
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<CarPictures> GetCarPictures()
        {
            var carPicturesList = icarPicturesRespository.GetCarPictures();
            return carPicturesList;
        }
    }
}
