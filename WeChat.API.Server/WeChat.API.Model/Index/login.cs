using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeChat.API.Model.Index
{
    public class login
    {
        /// <summary>
        /// ld
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// openId   
        /// </summary>
        public string openId { get; set; }

        /// <summary>
        /// 登录名
        /// </summary>
        public string clientName { get; set; }

        /// <summary>
        /// 用户令牌
        /// </summary>
        public string session_key { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public string username { get; set; }

        /// <summary>
        /// 用户密码
        /// </summary>
        public string userpwd { get; set; }
    }
}
