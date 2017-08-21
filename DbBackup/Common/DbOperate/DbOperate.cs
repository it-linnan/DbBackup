using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DbBackup.Common.DbOperate
{
    abstract class DbOperate
    {
        /// <summary>  
        /// 服务器  
        /// </summary>  
        public string Server
        {
            get;
            set;
        }
        /// <summary>  
        /// 登录名  
        /// </summary>  
        public string Uid
        {
            get;
            set;
        }
        /// <summary>  
        /// 登录密码  
        /// </summary>  
        public string Password
        {
            get;
            set;
        }
        /// <summary>  
        /// 要操作的数据库  
        /// </summary>  
        public string DataBase
        {
            get;
            set;
        }
        /// <summary>  
        /// 路经  
        /// </summary>  
        public string Path
        {
            get;
            set;
        }
        public DbOperate(string server, string uid, string password, string database, string path)
        {
            Server = server;
            Uid = uid;
            Password = password;
            DataBase = database;
            Path = path;
        }
        /// <summary>
        /// 操作数据库
        /// </summary>
        /// <returns>操作成功标识</returns>
        public bool Operate()
        {
            // 备份：use master;backup database @name to disk=@path;  
            // 恢复：use master;restore database @name from disk=@path;   
            SqlConnection connection = new SqlConnection("Data Source=" + Server + ";initial catalog=master" + ";user id=" + Uid + ";password=" + Password + ";");
            if (!string.IsNullOrWhiteSpace(Path) && !Path.EndsWith(".bak"))
            {
                Path += ".bak";
            }
            SqlCommand command = CreateSqlCommand(connection);
            command.Parameters.AddWithValue("@dataBase", DataBase);
            command.Parameters.AddWithValue("@path", Path);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            return true;
        }
        /// <summary>
        /// 创建sql命令
        /// </summary>
        /// <returns></returns>
        public abstract SqlCommand CreateSqlCommand(SqlConnection connection);
    }
}
