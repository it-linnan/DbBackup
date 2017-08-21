using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DbBackup.Common.DbOperate.impl
{
    class DbOperateBackUp : DbOperate
    {
        public DbOperateBackUp(string server, string uid, string password, string database, string path) : base(server, uid, password, database, path)
        {
        }

        public override SqlCommand CreateSqlCommand(SqlConnection connection)
        {
            SqlCommand command = new SqlCommand("use master;backup database @database to disk=@path;", connection);
            return command;
        }
    }
}
