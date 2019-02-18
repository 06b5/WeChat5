using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WeChat.API.Model.Forum.ThemeForum;
using WeChat.API.IRespository;

namespace WeChat.API.Server.Controllers
{
    public class ThemeForumIndexController : ApiController
    {
        public IThemeForumRespository ThemeForumIndexIRespository { get; set; }

        /// <summary>
        /// 主题论坛首页主题列表
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Theme> ThemeLists()
        {
            var ThemeLists = ThemeForumIndexIRespository.ThemeLists();
            return ThemeLists;
        }

        /// <summary>
        /// 对应主题的帖子展示
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<ThemeForum> GetThemeForumList(int themeId)
        {
            var getThemeForumList = ThemeForumIndexIRespository.GetThemeForumList(themeId);
            return getThemeForumList;
        }

        /// <summary>
        /// 查看帖子内容
        /// </summary>`
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpGet]
        public List<ThemeForum> GetThemeForumLists(int id)
        {
            var getThemeForumLists = ThemeForumIndexIRespository.GetThemeForumLists(id);
            return getThemeForumLists;
        }

        /// <summary>
        /// 显示回帖数
        /// </summary>
        /// <param name="ThemeForumId"></param>
        /// <returns></returns>
        [HttpGet]
        public int GetReplyNum(int themeForumId)
        {
            var i = ThemeForumIndexIRespository.GetReplyNum(themeForumId);
            return i;
        }

        /// <summary>
        /// 帖子对应评论
        /// </summary>
        /// <param name="ThemeForumId"></param>
        /// <returns></returns>
        [HttpGet]
        public List<ThemeForumAnsers> GetThemeForumReplyList(int themeForumId)
        {
            var getThemeForumReplyList = ThemeForumIndexIRespository.GetThemeForumReplyList(themeForumId);
            return getThemeForumReplyList;
        }

        /// <summary>
        /// 在主题论坛发帖
        /// </summary>
        /// <param name="themeforum"></param>
        /// <returns></returns>
        [HttpPost]
        public int Add(ThemeForum themeforum)
        {
            var i = ThemeForumIndexIRespository.Add(themeforum);
            return i;
        }

        /// <summary>
        /// 回帖
        /// </summary>
        /// <param name="themeforumansers"></param>
        /// <returns></returns>
        [HttpPost]
        public int ThemeReply(ThemeForumAnsers themeforumansers)
        {
            var i = ThemeForumIndexIRespository.ThemeReply(themeforumansers);
            return i;
        }
    }
}
