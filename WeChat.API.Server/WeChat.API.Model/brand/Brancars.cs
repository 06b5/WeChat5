using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeChat.API.Model.brand
{
    public class Brancars
    {
        /// <summary>
        /// 汽车表ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 车型大全的id
        /// </summary>
        public int CarSid { get; set; }

        /// <summary>
        /// 汽车详情的名字
        /// </summary>
        public string CarName { get; set; }

        /// <summary>
        /// 汽车详情的图片
        /// </summary>
        public string CarImg { get; set; }

        /// <summary>
        /// 汽车的价钱
        /// </summary>
        public string CarPrice { get; set; }
    }
}
