using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeChat.API.IRespository;
using System.Configuration;
using Oracle.DataAccess.Client;
using System.Data;
using WeChat.API.Model.Forum.HotForum;
using WeChat.API.IRespository;
using System.Configuration;
using Oracle.DataAccess.Client;
using System.Data;
using Newtonsoft.Json;
using Dapper;

namespace WeChat.API.Respository
{
   public  class HotForumIndexRespository : IHotForumIndexRespository
    {
        public static IDbConnection conn = new OracleConnection(ConfigurationManager.ConnectionStrings["OraclConn"].ToString());

        /// 热门列表展示
        /// </summary>
        /// <returns></returns>
        public List<Hot> HotLists()
        {
            string sql = "select * from Hot";
            var Hotlists = conn.Query<Hot>(sql);
            return Hotlists.ToList();
        }

        /// 查看热门帖子
        /// </summary>
        /// <returns></returns>
        public List<HotForum> GetHotForumList(int HotId)
        {
            string sql = $"select * from Hotforum where HotId ={HotId}";
            var getHotForumList = conn.Query<HotForum>(sql);
            return getHotForumList.ToList();
        }

        /// <summary>
        /// 查看帖子内容
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public List<HotForum> GetHotForumLists(int id)
        {
            string sql = $"select * from Hotforum where Id ={id}";
            var getHotForumLists = conn.Query<HotForum>(sql);
            return getHotForumLists.ToList();
        }

        /// <summary>
        /// 显示回帖数
        /// </summary>
        /// <param name="HotForumId"></param>
        /// <returns></returns>
        public int GetReplyNum(int HotForumId)
        {
            string sql = $"select count(*) from Hotforumansers where HotForumId = {HotForumId}";
            int i = Convert.ToInt32(conn.ExecuteScalar(sql));
            return i;
        }

        /// <summary>
        /// 帖子对应评论
        /// </summary>
        /// <param name="HotForumId"></param>
        /// <returns></returns>
        public List<HotForumAnsers> GetHotForumReplyList(int HotForumId)
        {
            string sql = $"select * from Hotforumansers where HotForumId ={HotForumId}";
            var getHotForumReplyList = conn.Query<HotForumAnsers>(sql);
            return getHotForumReplyList.ToList();
        }

        /// <summary>
        /// 在热门论坛发帖
        /// </summary>
        /// <param name="Hotforum"></param>
        /// <returns></returns>
        public int Add(HotForum Hotforum)
        {
            string sql = $"insert into Hotforum (HotId,PostTitle,PostContent,PostImgs) values (" + Hotforum.HotID + ",'" + Hotforum.PostTitle + "','" + Hotforum.PostContent + "','" + Hotforum.PostImgs + "')";
            var i = conn.Execute(sql);
            return i;
        }

        /// <summary>
        /// 回帖
        /// </summary>
        /// <param name="Hotforumansers"></param>
        /// <returns></returns>
        public int HotReply(HotForumAnsers Hotforumansers)
        {
            string sql = $"insert into Hotforumansers (HotForumId,AnserContent) values (" + Hotforumansers.HotForumID + ",'" + Hotforumansers.AnserContent + "')";
            var i = conn.Execute(sql);
            return i;
        }
    }
}
