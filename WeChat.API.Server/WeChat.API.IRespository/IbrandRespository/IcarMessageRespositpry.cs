using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WeChat.API.Model.brand;

namespace WeChat.API.IRespository.IbrandRespository
{
    public interface IcarMessageRespositpry
    {
        /// <summary>
        /// 显示汽车详细信息
        /// </summary>
        /// <returns></returns>
        List<CarMessage> GetCarMessages(int id);
    }
}
