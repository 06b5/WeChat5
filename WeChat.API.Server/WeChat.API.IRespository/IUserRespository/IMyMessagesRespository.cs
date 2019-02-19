using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeChat.API.Model.User;
using WeChat.API.Model;

namespace WeChat.API.IRespository.IUserRespository
{
    public interface IMyMessagesRespository
    {
        /// <summary>
        /// 我的消息
        /// </summary>
        /// <returns></returns>
        List<MyMessage> GetMyMessage();
    }
}
