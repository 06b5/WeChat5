using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WeChat.API.Model.brand;

namespace WeChat.API.IRespository.IbrandRespository
{
    public interface IcarSeriesRespository
    {
        /// <summary>
        /// 具体的哪一款汽车
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        List<CarSeries> GetCarSeries(int id);
    }
}
