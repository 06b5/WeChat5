using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WeChat.API.Model.Forum.HotForum;
using WeChat.API.IRespository;

namespace WeChat.API.Server.Controllers
{
    public class HotForumIndexController : ApiController
    {
        public IHotForumRespository HotForumIndexIRespository { get; set; }

        /// <summary>
        /// 热门论坛首页热门列表
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Hot> HotLists()
        {
            var HotLists = HotForumIndexIRespository.HotLists();
            return HotLists;
        }

        /// <summary>
        /// 对应热门的帖子展示
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<HotForum> GetHotForumList(int hotId)
        {
            var getHotForumList = HotForumIndexIRespository.GetHotForumList(hotId);
            return getHotForumList;
        }

        /// <summary>
        /// 查看帖子内容
        /// </summary>`
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpGet]
        public List<HotForum> GetHotForumLists(int id)
        {
            var getHotForumLists = HotForumIndexIRespository.GetHotForumLists(id);
            return getHotForumLists;
        }

        /// <summary>
        /// 显示回帖数
        /// </summary>
        /// <param name="hotForumId"></param>
        /// <returns></returns>
        [HttpGet]
        public int GetReplyNum(int hotForumId)
        {
            var i = HotForumIndexIRespository.GetReplyNum(hotForumId);
            return i;
        }

        /// <summary>
        /// 帖子对应评论
        /// </summary>
        /// <param name="hotForumId"></param>
        /// <returns></returns>
        [HttpGet]
        public List<HotForumAnsers> GetHotForumReplyList(int hotForumId)
        {
            var getHotForumReplyList = HotForumIndexIRespository.GetHotForumReplyList(hotForumId);
            return getHotForumReplyList;
        }

        /// <summary>
        /// 在热门论坛发帖
        /// </summary>
        /// <param name="hotforum"></param>
        /// <returns></returns>
        [HttpPost]
        public int Add(HotForum hotforum)
        {
            var i = HotForumIndexIRespository.Add(hotforum);
            return i;
        }

        /// <summary>
        /// 回帖
        /// </summary>
        /// <param name="hotforumansers"></param>
        /// <returns></returns>
        [HttpPost]
        public int HotReply(HotForumAnsers hotforumansers)
        {
            var i = HotForumIndexIRespository.HotReply(hotforumansers);
            return i;
        }
    }
}
