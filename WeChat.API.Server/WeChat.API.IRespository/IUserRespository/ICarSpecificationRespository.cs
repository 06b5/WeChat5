using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeChat.API.Model.User;

namespace WeChat.API.IRespository.IUserRespository
{
    public interface ICarSpecificationRespository
    {
        /// <summary>
        /// 显示汽车详细信息
        /// </summary>
        /// <returns></returns>

        List<CarSpecification> GetCarSpecification(int id);
    }
}
