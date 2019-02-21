using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WeChat.API.Model.Index;


namespace WeChat.API.IRespository.IndexIRespository
{
    public interface IloginRespository
    {
        /// <summary>
        /// 登录
        /// </summary>
        /// <returns></returns>
        List<login> GetLogin();
    }
}
