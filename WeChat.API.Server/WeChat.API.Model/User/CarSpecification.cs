using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeChat.API.Model.User
{
    public class CarSpecification
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 指导价
        /// </summary>
        public int GuidePrice { get; set; }

        /// <summary>
        /// 级别
        /// </summary>
        public string Rank { get; set; }

        /// <summary>
        /// 油耗
        /// </summary>
        public string FuelConsumption { get; set; }

        /// <summary>
        /// 关联ID
        /// </summary>
        public int MSLID { get; set; }

        /// <summary>
        /// 图片
        /// </summary>
        public string Pircuter { get; set; }
    }
}
