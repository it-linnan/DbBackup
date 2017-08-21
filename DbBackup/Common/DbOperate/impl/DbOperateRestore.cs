using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DbBackup.Common.DbOperate.impl
{
    class DbOperateRestore : DbOperate
    {
        public DbOperateRestore(string server, string uid, string password, string database, string path) : base(server, uid, password, database, path)
        {
        }

        public override SqlCommand CreateSqlCommand(SqlConnection connection)
        {
            SqlCommand command = new SqlCommand("use master;restore database @database from disk=@path;", connection);
            return command;
        }
    }
}
