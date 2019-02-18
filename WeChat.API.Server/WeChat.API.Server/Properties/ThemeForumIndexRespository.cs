using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeChat.API.IRespository;
using System.Configuration;
using Oracle.DataAccess.Client;
using System.Data;
using WeChat.API.Model.Forum.ThemeForum;
using WeChat.API.IRespository;
using System.Configuration;
using Oracle.DataAccess.Client;
using System.Data;
using Newtonsoft.Json;
using Dapper;

namespace WeChat.API.Respository
{
   public class ThemeForumIndexRespository : IThemeForumRespository
    {
        public static IDbConnection conn = new OracleConnection(ConfigurationManager.ConnectionStrings["OraclConn"].ToString());

        /// 主题列表展示
        /// </summary>
        /// <returns></returns>
        public List<Theme> ThemeLists()
        {
            string sql = "select * from Theme";
            var Themelists = conn.Query<Theme>(sql);
            return Themelists.ToList();
        }

        /// 查看主题帖子
        /// </summary>
        /// <returns></returns>
        public List<ThemeForum> GetThemeForumList(int ThemeId)
        {
            string sql = $"select * from Themeforum where ThemeId ={ThemeId}";
            var getThemeForumList = conn.Query<ThemeForum>(sql);
            return getThemeForumList.ToList();
        }

        /// <summary>
        /// 查看帖子内容
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public List<ThemeForum> GetThemeForumLists(int id)
        {
            string sql = $"select * from Themeforum where Id ={id}";
            var getThemeForumLists = conn.Query<ThemeForum>(sql);
            return getThemeForumLists.ToList();
        }

        /// <summary>
        /// 显示回帖数
        /// </summary>
        /// <param name="ThemeForumId"></param>
        /// <returns></returns>
        public int GetReplyNum(int ThemeForumId)
        {
            string sql = $"select count(*) from Themeforumansers where ThemeForumId = {ThemeForumId}";
            int i = Convert.ToInt32(conn.ExecuteScalar(sql));
            return i;
        }

        /// <summary>
        /// 帖子对应评论
        /// </summary>
        /// <param name="ThemeForumId"></param>
        /// <returns></returns>
        public List<ThemeForumAnsers> GetThemeForumReplyList(int ThemeForumId)
        {
            string sql = $"select * from Themeforumansers where ThemeForumId ={ThemeForumId}";
            var getThemeForumReplyList = conn.Query<ThemeForumAnsers>(sql);
            return getThemeForumReplyList.ToList();
        }

        /// <summary>
        /// 在主题论坛发帖
        /// </summary>
        /// <param name="Themeforum"></param>
        /// <returns></returns>
        public int Add(ThemeForum Themeforum)
        {
            string sql = $"insert into Themeforum (ThemeId,PostTitle,PostContent,PostImgs) values (" + Themeforum.ThemeID + ",'" + Themeforum.PostTitle + "','" + Themeforum.PostContent + "','" + Themeforum.PostImgs + "')";
            var i = conn.Execute(sql);
            return i;
        }

        /// <summary>
        /// 回帖
        /// </summary>
        /// <param name="Themeforumansers"></param>
        /// <returns></returns>
        public int ThemeReply(ThemeForumAnsers Themeforumansers)
        {
            string sql = $"insert into Themeforumansers (ThemeForumId,AnserContent) values (" + Themeforumansers.ThemeForumID + ",'" + Themeforumansers.AnserContent + "')";
            var i = conn.Execute(sql);
            return i;
        }
    }
}
