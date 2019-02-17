using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeChat.API.Model.Forum.HotForum
{
    public class HotForum
    {
        /// <summary>
        /// 热门论坛帖子主键
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 热门编号
        /// </summary>
        public int HotID { get; set; }

        /// <summary>
        /// 帖子标题
        /// </summary>
        public string PostTitle { get; set; }

        /// <summary>
        /// 帖子内容
        /// </summary>
        public string PostContent { get; set; }

        /// <summary>
        /// 帖子图片
        /// </summary>
        public string PostImgs { get; set; }
    }
}
