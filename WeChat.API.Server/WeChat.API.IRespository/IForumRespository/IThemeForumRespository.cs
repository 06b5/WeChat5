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
        List<ThemeForum> GetThemeForumList(int themeId);

        /// <summary>
        /// 查看帖子内容
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        List<ThemeForum> GetThemeForumLists(int id);

        /// <summary>
        /// 显示回帖数
        /// </summary>
        /// <param name="themeForumId"></param>
        /// <returns></returns>
        int GetReplyNum(int themeForumId);

        /// <summary>
        /// 帖子对应评论
        /// </summary>
        /// <param name="themeForumId"></param>
        /// <returns></returns>
        List<ThemeForumAnsers> GetThemeForumReplyList(int themeForumId);

        /// <summary>
        /// 根据标题查询主题论坛帖子
        /// </summary>
        /// <param name="forumName"></param>
        /// <returns></returns>
        List<ThemeForum> GetThemeForumListsByName(string forumName);

        /// <summary>
        /// 在主题论坛发帖
        /// </summary>
        /// <param name="themeforum"></param>
        /// <returns></returns>
        int Add(ThemeForum themeforum);

        /// <summary>
        /// 回帖
        /// </summary>
        /// <param name="themeforumansers"></param>
        /// <returns></returns>
        int ThemeReply(ThemeForumAnsers themeforumansers);
    }
}
