using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeChat.API.Model.User;
using WeChat.API.Model;

namespace WeChat.API.IRespository.IUserRespository
{
    public interface IMyShoppingListRespository
    {
        /// <summary>
        /// 我的订单
        /// </summary>
        /// <returns></returns>
        List<MyShoppingList> GetMyShoppingList();
    }
}
