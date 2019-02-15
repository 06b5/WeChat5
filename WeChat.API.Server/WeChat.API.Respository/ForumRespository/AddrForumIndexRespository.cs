using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeChat.API.Model.Forum.AddrForum;
using WeChat.API.IRespository;
using System.Configuration;
using Oracle.DataAccess.Client;
using System.Data;
using Newtonsoft.Json;
using Dapper;

namespace WeChat.API.Respository
{
   public class AddrForumIndexRespository: IAddrForumIndexRespository
    {
        public static IDbConnection conn = new OracleConnection(ConfigurationManager.ConnectionStrings["OraclConn"].ToString());

        /// 地区列表展示
        /// </summary>
        /// <returns></returns>
        public List<Addr> AddrLists()
        {
            string sql = "select * from addr";
            var addrlists = conn.Query<Addr>(sql);
            return addrlists.ToList();
        }

        /// 查看地区帖子
        /// </summary>
        /// <returns></returns>
        public List<AddrForum> GetAddrForumList(int addrId)
        {
            string sql = $"select * from addrforum where AddrId ={addrId}";
            var getAddrForumList = conn.Query<AddrForum>(sql);
            return getAddrForumList.ToList();
        }

        /// <summary>
        /// 查看帖子内容
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
       public List<AddrForum> GetAddrForumLists(int id)
        {
            string sql = $"select * from addrforum where Id ={id}";
            var getAddrForumLists = conn.Query<AddrForum>(sql);
            return getAddrForumLists.ToList();
        }

        /// <summary>
        /// 显示回帖数
        /// </summary>
        /// <param name="AddrForumId"></param>
        /// <returns></returns>
        public int GetReplyNum(int addrForumId)
        {
            string sql = $"select count(*) from addrforumansers where AddrForumId = {addrForumId}";
            int i = Convert.ToInt32(conn.ExecuteScalar(sql));
            return i;
        }

        /// <summary>
        /// 帖子对应评论
        /// </summary>
        /// <param name="AddrForumId"></param>
        /// <returns></returns>
        public List<AddrForumAnsers> GetAddrForumReplyList(int addrForumId)
        {
            string sql = $"select * from addrforumansers where AddrForumId ={addrForumId}";
            var getAddrForumReplyList = conn.Query<AddrForumAnsers>(sql);
            return getAddrForumReplyList.ToList();
        }

        /// <summary>
        /// 在地区论坛发帖
        /// </summary>
        /// <param name="addrforum"></param>
        /// <returns></returns>
        public int Add(AddrForum addrforum)
        {
            string sql = $"insert into addrforum (AddrId,PostTitle,PostContent,PostImgs) values ("+addrforum.AddrID+",'"+addrforum.PostTitle+"','"+addrforum.PostContent+"','"+addrforum.PostImgs+"')";
            var i = conn.Execute(sql);
            return i;
        }

        /// <summary>
        /// 回帖
        /// </summary>
        /// <param name="addrforumansers"></param>
        /// <returns></returns>
        public int AddReply(AddrForumAnsers addrforumansers)
        {
            string sql = $"insert into addrforumansers (AddrForumId,AnserContent) values ("+addrforumansers.AddrForumID+",'"+addrforumansers.AnserContent+"')";
            var i = conn.Execute(sql);
            return i;
        }
    }
}
