using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeChat.API.IRespository;
using System.Configuration;
using Oracle.DataAccess.Client;
using System.Data;
using WeChat.API.Model.Forum.BrandForum;
using Newtonsoft.Json;
using Dapper;

namespace WeChat.API.Respository
{
   public class BrandForumRespository : IBrandForumRespository
    {
        public static IDbConnection conn = new OracleConnection(ConfigurationManager.ConnectionStrings["OraclConn"].ToString());

        /// 车系列表展示
        /// </summary>
        /// <returns></returns>
        public List<Brand> BrandLists()
        {
            string sql = "select * from Brand";
            var Brandlists = conn.Query<Brand>(sql);
            return Brandlists.ToList();
        }

        /// 查看车系帖子
        /// </summary>
        /// <returns></returns>
        public List<BrandForum> GetBrandForumList(int brandId)
        {
            string sql = $"select * from Brandforum where BrandId ={brandId}";
            var getBrandForumList = conn.Query<BrandForum>(sql);
            return getBrandForumList.ToList();
        }

        /// <summary>
        /// 查看帖子内容
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public List<BrandForum> GetBrandForumLists(int id)
        {
            string sql = $"select * from Brandforum where Id ={id}";
            var getBrandForumLists = conn.Query<BrandForum>(sql);
            return getBrandForumLists.ToList();
        }

        /// <summary>
        /// 显示回帖数
        /// </summary>
        /// <param name="BrandForumId"></param>
        /// <returns></returns>
        public int GetReplyNum(int brandForumId)
        {
            string sql = $"select count(*) from Brandforumansers where BrandForumId = {brandForumId}";
            int i = Convert.ToInt32(conn.ExecuteScalar(sql));
            return i;
        }

        /// <summary>
        /// 帖子对应评论
        /// </summary>
        /// <param name="BrandForumId"></param>
        /// <returns></returns>
        public List<BrandForumAnsers> GetBrandForumReplyList(int BrandForumId)
        {
            string sql = $"select * from Brandforumansers where BrandForumId ={BrandForumId}";
            var getBrandForumReplyList = conn.Query<BrandForumAnsers>(sql);
            return getBrandForumReplyList.ToList();
        }

        /// <summary>
        /// 在车系论坛发帖
        /// </summary>
        /// <param name="Brandforum"></param>
        /// <returns></returns>
        public int Add(BrandForum brandforum)
        {
            string sql = $"insert into Brandforum (BrandId,PostTitle,PostContent,PostImgs) values (" + brandforum.BrandID + ",'" + brandforum.PostTitle + "','" + brandforum.PostContent + "','" + brandforum.PostImgs + "')";
            var i = conn.Execute(sql);
            return i;
        }

        /// <summary>
        /// 回帖
        /// </summary>
        /// <param name="Brandforumansers"></param>
        /// <returns></returns>
        public int BrandReply(BrandForumAnsers brandforumansers)
        {
            string sql = $"insert into Brandforumansers (BrandForumId,AnserContent) values (" + brandforumansers.BrandForumID + ",'" + brandforumansers.AnserContent + "')";
            var i = conn.Execute(sql);
            return i;
        }
    }
}
