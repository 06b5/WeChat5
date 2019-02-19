using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WeChat.API.IRespository.IUserRespository;
using WeChat.API.Model.User;

namespace WeChat.API.Server.Controllers
{
    public class UserController : ApiController
    {
        public IMyMessagesRespository myMessagesRespository { get; set; }

        public IMyShoppingListRespository myShoppingListRespository { get; set; }

        /// <summary>
        /// 我的订单
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<MyShoppingList> GetMyShoppingList()
        {
            var myShoppingList = myShoppingListRespository.GetMyShoppingList();
            return myShoppingList;
        }


        [HttpGet]
        public List<MyMessage> GetMyMessage()
        {
            var myMessage = myMessagesRespository.GetMyMessage();
            return myMessage;
        }
    }
}
