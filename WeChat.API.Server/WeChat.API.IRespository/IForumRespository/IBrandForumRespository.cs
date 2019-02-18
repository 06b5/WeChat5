﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeChat.API.Model.Forum.BrandForum;

namespace WeChat.API.IRespository
{
   public interface IBrandForumRespository
    {
        /// <summary>
        /// 车系列表展示
        /// </summary>
        /// <returns></returns>
        List<Brand> BrandLists();

        /// <summary>
        /// 对应车系论坛帖子展示
        /// </summary>
        /// <returns></returns>
        List<BrandForum> GetBrandForumList(int brandId);

        /// <summary>
        /// 查看帖子内容
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        List<BrandForum> GetBrandForumLists(int id);

        /// <summary>
        /// 显示回帖数
        /// </summary>
        /// <param name="brandForumId"></param>
        /// <returns></returns>
        int GetReplyNum(int brandForumId);

        /// <summary>
        /// 帖子对应评论
        /// </summary>
        /// <param name="brandForumId"></param>
        /// <returns></returns>
        List<BrandForumAnsers> GetBrandForumReplyList(int brandForumId);

        /// <summary>
        /// 根据标题查询主题论坛帖子
        /// </summary>
        /// <param name="IdforumName></param>
        /// <returns></returns>
        List<BrandForum> GetBrandForumListsByName(string forumName);

        /// <summary>
        /// 在车系论坛发帖
        /// </summary>
        /// <param name="brandforum"></param>
        /// <returns></returns>
        int Add(BrandForum brandforum);

        /// <summary>
        /// 回帖
        /// </summary>
        /// <param name="brandforumansers"></param>
        /// <returns></returns>
        int BrandReply(BrandForumAnsers brandforumansers);
    }
}
