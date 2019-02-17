using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeChat.API.Model.Forum.BrandForum
{
   public class BrandForum
    {
        /// <summary>
        /// 车系论坛帖子主键
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 车系编号
        /// </summary>
        public int BrandID { get; set; }

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
