using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WeChat.API.Model.Forum.AddrForum;
using WeChat.API.IRespository;

namespace WeChat.API.Server.Controllers.Forum.AddrForums
{
    public class AddrForumIndexController : ApiController
    {
        public IAddrForumRespository AddrForumIndexIRespository { get; set; }

        /// <summary>
        /// 地区论坛首页地区列表
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Addr> AddrLists()
        {
            var AddrLists = AddrForumIndexIRespository.AddrLists();
            return AddrLists;
        }

        /// <summary>
        /// 对应地区的帖子展示
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<AddrForum> GetAddrForumList(int addrId)
        {
            var getAddrForumList = AddrForumIndexIRespository.GetAddrForumList(addrId);
            return getAddrForumList;
        }

        /// <summary>
        /// 查看帖子内容
        /// </summary>`
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpGet]
        public List<AddrForum> GetAddrForumLists(int id)
        {
            var getAddrForumLists = AddrForumIndexIRespository.GetAddrForumLists(id);
            return getAddrForumLists;
         }

        /// <summary>
        /// 显示回帖数
        /// </summary>
        /// <param name="AddrForumId"></param>
        /// <returns></returns>
        [HttpGet]
        public int GetReplyNum(int addrForumId)
        {
            var i = AddrForumIndexIRespository.GetReplyNum(addrForumId);
            return i;
        }

        /// <summary>
        /// 帖子对应评论
        /// </summary>
        /// <param name="AddrForumId"></param>
        /// <returns></returns>
        [HttpGet]
        public List<AddrForumAnsers> GetAddrForumReplyList(int addrForumId)
        {
            var getAddrForumReplyList = AddrForumIndexIRespository.GetAddrForumReplyList(addrForumId);
            return getAddrForumReplyList;
        }

        /// <summary>
        /// 根据标题查询地区论坛帖子
        /// </summary>
        /// <param name="forumName"></param>
        /// <returns></returns>
        [HttpGet]
        public List<AddrForum> GetAddrForumListsByName(string forumName)
        {
            var getAddrForumList = AddrForumIndexIRespository.GetAddrForumListsByName(forumName);
            return getAddrForumList;
        }

        /// <summary>
        /// 在地区论坛发帖
        /// </summary>
        /// <param name="addrforum"></param>
        /// <returns></returns>
        [HttpPost]
        public int Add(AddrForum addrforum)
        {
            var i = AddrForumIndexIRespository.Add(addrforum);
            return i;
        }

        /// <summary>
        /// 回帖
        /// </summary>
        /// <param name="addrforumansers"></param>
        /// <returns></returns>
        [HttpPost]
        public int AddReply(AddrForumAnsers addrforumansers)
        {
            var i = AddrForumIndexIRespository.AddReply(addrforumansers);
            return i;
        }
    }
}
