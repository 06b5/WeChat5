using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WeChat.API.Model.Pictures;

namespace WeChat.API.IRespository.IpicturesRespository
{
    public interface IcarPicturesRespository
    {
        /// <summary>
        /// 名称鉴赏的图片
        /// </summary>
        /// <returns></returns>
        List<CarPictures> GetCarPictures();
    }
}
