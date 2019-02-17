using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeChat.API.Model.Forum.HotForum
{
   public class Hot
    {
        /// <summary>
        /// 热门论坛主页主键
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 热门名称
        /// </summary>
        public string HotName { get; set; }
    }
}
