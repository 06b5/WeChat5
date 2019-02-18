using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeChat.API.Model.Forum.ThemeForum;

namespace WeChat.API.IRespository
{
   public interface IThemeForumRespository
    {
        /// <summary>
        /// 主题列表展示
        /// </summary>
        /// <returns></returns>
        List<Theme> ThemeLists();

        /// <summary>
        /// 对应主题论坛帖子展示
        /// </summary>
        /// <returns></returns>
        List<ThemeForum> GetThemeForumList(int ThemeId);

        /// <summary>
        /// 查看帖子内容
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        List<ThemeForum> GetThemeForumLists(int id);

        /// <summary>
        /// 显示回帖数
        /// </summary>
        /// <param name="ThemeForumId"></param>
        /// <returns></returns>
        int GetReplyNum(int ThemeForumId);

        /// <summary>
        /// 帖子对应评论
        /// </summary>
        /// <param name="ThemeForumId"></param>
        /// <returns></returns>
        List<ThemeForumAnsers> GetThemeForumReplyList(int ThemeForumId);

        /// <summary>
        /// 在主题论坛发帖
        /// </summary>
        /// <param name="Themeforum"></param>
        /// <returns></returns>
        int Add(ThemeForum Themeforum);
        /// <summary>
        /// 回帖
        /// </summary>
        /// <param name="Themeforumansers"></param>
        /// <returns></returns>
        int ThemeReply(ThemeForumAnsers Themeforumansers);
    }
}
