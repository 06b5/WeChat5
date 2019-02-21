using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WeChat.API.Model.Index;
using WeChat.API.IRespository.IndexIRespository;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using Newtonsoft.Json;

namespace WeChat.API.Respository.IndexRespository
{
    public class loginRespository : IloginRespository
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["OraclConn"].ToString());

        public List<login> GetLogin()
        {
            string sql = "select * from login";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            conn.Open();
            adapter.Fill(dt);
            string json = JsonConvert.SerializeObject(dt);
            List<login> loginList = JsonConvert.DeserializeObject<List<login>>(json);
            return loginList;
        }
    }
}
