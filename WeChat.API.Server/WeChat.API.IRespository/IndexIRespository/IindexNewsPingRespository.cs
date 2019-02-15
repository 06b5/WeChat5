using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeChat.API.Model.Index;

namespace WeChat.API.IRespository.IndexIRespository
{
    public interface IindexNewsPingRespository
    {   
        /// <summary>
        /// 详情新闻页
        /// </summary>
        /// <returns></returns>
        List<IndexNewsPing> GetIndexNewsPing(int id);
    }
}
