using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WeChat.API.Model.brand;

namespace WeChat.API.IRespository.IbrandRespository
{
    public interface IbranCarsRespository
    {
        /// <summary>
        /// 展示汽车品牌下的详细车辆
        /// </summary>
        /// <returns></returns>
        List<Brancars> GetbranCars(int id);
    }
}
