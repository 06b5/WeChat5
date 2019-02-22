using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WeChat.API.Model.Forum.BrandForum;
using WeChat.API.IRespository;

namespace WeChat.API.Server.Controllers
{
    public class BrandForumIndexController : ApiController
    {
        public IBrandForumRespository BrandForumIndexIRespository { get; set; }

        /// <summary>
        /// 车系论坛首页车系列表
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Brand> BrandLists()
        {
            var brandLists = BrandForumIndexIRespository.BrandLists();
            return brandLists;
        }

        /// <summary>
        /// 对应车系的帖子展示
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<BrandForum> GetBrandForumList(int brandId)
        {
            var getBrandForumList = BrandForumIndexIRespository.GetBrandForumList(brandId);
            return getBrandForumList;
        }

        /// <summary>
        /// 查看帖子内容
        /// </summary>`
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpGet]
        public List<BrandForum> GetBrandForumLists(int id)
        {
            var getBrandForumLists = BrandForumIndexIRespository.GetBrandForumLists(id);
            return getBrandForumLists;
        }

        /// <summary>
        /// 显示回帖数
        /// </summary>
        /// <param name="brandForumId"></param>
        /// <returns></returns>
        [HttpGet]
        public int GetReplyNum(int brandForumId)
        {
            var i = BrandForumIndexIRespository.GetReplyNum(brandForumId);
            return i;
        }

        /// <summary>
        /// 帖子对应评论
        /// </summary>
        /// <param name="brandForumId"></param>
        /// <returns></returns>
        [HttpGet]
        public List<BrandForumAnsers> GetBrandForumReplyList(int brandForumId)
        {
            var getBrandForumReplyList = BrandForumIndexIRespository.GetBrandForumReplyList(brandForumId);
            return getBrandForumReplyList;
        }

        /// <summary>
        /// 根据标题查询车系论坛帖子
        /// </summary>
        /// <param name="forumName"></param>
        /// <returns></returns>
        [HttpGet]
        public List<BrandForum> GetBrandForumListsByName(string forumName)
        {
            var getBrandForumList = BrandForumIndexIRespository.GetBrandForumListsByName(forumName);
            return getBrandForumList;
        }

        /// <summary>
        /// 在车系论坛发帖
        /// </summary>
        /// <param name="brandforum"></param>
        /// <returns></returns>
        [HttpPost]
        public int Add(BrandForum brandforum)
        {
            var i = BrandForumIndexIRespository.Add(brandforum);
            return i;
        }

        /// <summary>
        /// 回帖
        /// </summary>
        /// <param name="brandforumansers"></param>
        /// <returns></returns>
        [HttpPost]
        public int BrandReply(BrandForumAnsers brandforumansers)
        {
            var i = BrandForumIndexIRespository.BrandReply(brandforumansers);
            return i;
        }
    }
}
