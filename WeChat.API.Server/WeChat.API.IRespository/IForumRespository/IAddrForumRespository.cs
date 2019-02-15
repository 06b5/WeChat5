using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeChat.API.Model.Forum.AddrForum;

namespace WeChat.API.IRespository
{
    public interface IAddrForumIndexRespository
    {
        /// <summary>
        /// 地区列表展示
        /// </summary>
        /// <returns></returns>
        List<Addr> AddrLists();

        /// <summary>
        /// 对应地区论坛帖子展示
        /// </summary>
        /// <returns></returns>
        List<AddrForum> GetAddrForumList (int addrId);

        /// <summary>
        /// 查看帖子内容
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        List<AddrForum> GetAddrForumLists(int id);

        /// <summary>
        /// 显示回帖数
        /// </summary>
        /// <param name="AddrForumId"></param>
        /// <returns></returns>
        int GetReplyNum(int addrForumId);

        /// <summary>
        /// 帖子对应评论
        /// </summary>
        /// <param name="AddrForumId"></param>
        /// <returns></returns>
        List<AddrForumAnsers> GetAddrForumReplyList(int addrForumId);

        /// <summary>
        /// 在地区论坛发帖
        /// </summary>
        /// <param name="addrforum"></param>
        /// <returns></returns>
        int Add(AddrForum addrforum);
        /// <summary>
        /// 回帖
        /// </summary>
        /// <param name="addrforumansers"></param>
        /// <returns></returns>
        int AddReply(AddrForumAnsers addrforumansers);
    }
}
