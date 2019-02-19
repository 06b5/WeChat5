using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeChat.API.Model.brand
{
    public class CarMessage
    {
        /// <summary>
        /// 车辆详细信息
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 车辆详细
        /// </summary>
        public int CarSid { get; set; }

        /// <summary>
        /// 车辆名称
        /// </summary>
        public string CarName { get; set; }

        /// <summary>
        /// 车辆图片
        /// </summary>
        public string CarImgs { get; set; }

        /// <summary>
        /// 车辆价格
        /// </summary>
        public string CarPrice { get; set; }

        /// <summary>
        /// 车辆类别
        /// </summary>
        public string CarType { get; set; }

        /// <summary>
        /// 车辆油耗
        /// </summary>
        public string CarXiaohao { get; set; }

        /// <summary>
        /// 车辆信息
        /// </summary>
        public string CarContent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Likenum { get; set; }

        /// <summary>
        /// 油耗
        /// </summary>
        public string fuel { get; set; }
        /// <summary>
        /// 马力
        /// </summary>
        public string horsepower { get; set; }
    }
}