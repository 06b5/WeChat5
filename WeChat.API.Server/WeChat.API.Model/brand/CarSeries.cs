using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeChat.API.Model.brand
{
    public class CarSeries
    {
        /// <summary>
        /// 详细车辆ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 车辆类别ID
        /// </summary>
        public int carmid { get; set; }

        /// <summary>
        /// 车辆名字
        /// </summary>
        public string carname { get; set; }

        /// <summary>
        /// 厂家指导价
        /// </summary>
        public string factoryprice { get; set; }

        /// <summary>
        /// 参考价
        /// </summary>
        public string referenceprice { get; set; }

    }
}
