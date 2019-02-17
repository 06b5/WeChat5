using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeChat.API.Model.Forum.HotForum;

namespace WeChat.API.IRespository
{
   public interface IHotForumIndexRespository
    {
        /// <summary>
        /// 热门列表展示
        /// </summary>
        /// <returns></returns>
        List<Hot> HotLists();

        /// <summary>
        /// 对应热门论坛帖子展示
        /// </summary>
        /// <returns></returns>
        List<HotForum> GetHotForumList(int HotId);

        /// <summary>
        /// 查看帖子内容
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        List<HotForum> GetHotForumLists(int id);

        /// <summary>
        /// 显示回帖数
        /// </summary>
        /// <param name="HotForumId"></param>
        /// <returns></returns>
        int GetReplyNum(int HotForumId);

        /// <summary>
        /// 帖子对应评论
        /// </summary>
        /// <param name="HotForumId"></param>
        /// <returns></returns>
        List<HotForumAnsers> GetHotForumReplyList(int HotForumId);

        /// <summary>
        /// 在热门论坛发帖
        /// </summary>
        /// <param name="Hotforum"></param>
        /// <returns></returns>
        int Add(HotForum Hotforum);
        /// <summary>
        /// 回帖
        /// </summary>
        /// <param name="Hotforumansers"></param>
        /// <returns></returns>
        int HotReply(HotForumAnsers Hotforumansers);
    }
}
