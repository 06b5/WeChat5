using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeChat.API.Model.Forum.ThemeForum
{
    public class Theme
    {
        /// <summary>
        /// 主题论坛主页主键
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 主题名称
        /// </summary>
        public string ThemeName { get; set; }
    }
}
