using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeChat.API.Model.Index;

namespace WeChat.API.IRespository.IndexIRespository
{
    public interface IindexNewsRespository
    {
        /// <summary>
        /// 首页面的显示接口
        /// </summary>
        /// <returns></returns>
        List<IndexNews> GetIndexNews();
    }
}
