using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeChat.API.Model.Ranking
{
    public class Topranking
    {
        /// <summary>
        /// 热门排行主键
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 热门汽车的名字
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 热门汽车的价钱
        /// </summary>
        public string Price { get; set; }

        /// <summary>
        /// 热门汽车的图片
        /// </summary>
        public string Img { get; set; }
    }
}
