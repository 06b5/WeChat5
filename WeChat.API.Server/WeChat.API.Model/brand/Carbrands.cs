using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeChat.API.Model.brand
{
    public class Carbrands
    {
        /// <summary>
        /// 车型大全的ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 车型图标
        /// </summary>
        public string BrandImg { get; set; }

        /// <summary>
        /// 车型的名字
        /// </summary>
        public string BrandName { get; set; }

        /// <summary>
        /// 新能源
        /// </summary>
        public int IsNewenergy { get; set; }

        /// <summary>
        /// 是否二手
        /// </summary>
        public int ErShow { get; set; }
    }
}
