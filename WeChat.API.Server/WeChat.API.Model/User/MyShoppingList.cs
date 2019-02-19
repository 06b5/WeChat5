using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeChat.API.Model.User
{
    public class MyShoppingList
    {
        /// <summary>
        /// 我的订单页主键
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 订单图片
        /// </summary>
        public string Imgs { get; set; }

        /// <summary>
        /// 车名
        /// </summary>
        public string Carname { get; set; }

        /// <summary>
        /// 车辆价格
        /// </summary>
        public int Price { get; set; }
    }
}
