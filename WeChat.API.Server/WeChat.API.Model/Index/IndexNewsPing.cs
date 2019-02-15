using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeChat.API.Model.Index
{
    public class IndexNewsPing
    {
        /// <summary>
        /// 详情新闻主键
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 新闻主键 用来关联查询
        /// </summary>
        public int NewSId { get; set; }

        /// <summary>
        /// 详情新闻内容
        /// </summary>
        public string AnserContent { get; set; }

        /// <summary>
        /// 详情新闻标题
        /// </summary>
        public string AnserTitle { get; set; }

        /// <summary>
        /// 详情新闻图片
        /// </summary>
        public string AnserImg { get; set; }
    }
}
