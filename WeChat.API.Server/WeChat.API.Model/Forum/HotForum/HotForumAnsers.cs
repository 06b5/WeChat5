using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeChat.API.Model.Forum.HotForum
{
    public class HotForumAnsers
    {
        /// <summary>
        /// 回帖主键
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 对应帖子ID
        /// </summary>
        public int HotForumID { get; set; }

        /// <summary>
        /// 回帖内容
        /// </summary>
        public string AnserContent { get; set; }
    }
}
