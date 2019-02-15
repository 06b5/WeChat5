using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeChat.API.Model.Index
{
    public class IndexNews
    {
        /// <summary>
        /// 新闻主页主键
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 新闻标题
        /// </summary>
        public string NesStitle { get; set; }

        /// <summary>
        /// 新闻图片
        /// </summary>
        public string NewSimg { get; set; }

        /// <summary>
        /// 种类
        /// </summary>
        public string NewScontent { get; set; }
    }
}
