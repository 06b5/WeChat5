using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeChat.API.Model.brand;

namespace WeChat.API.IRespository.IbrandRespository
{
    public interface IcarbrandsRespository
    {
        /// <summary>
        /// 汽车品牌的展示
        /// </summary>
        /// <returns></returns>
        List<Carbrands> GetCarbrands();
    }
}
