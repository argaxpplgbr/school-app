using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace SchoolApp
{
    internal class Connection
    {
        public MySqlConnection ConnectionToSql()
        {
            string ConnectionString = "server=localhost;Database=pi_school;Uid=root;pwd=belajar123";
            MySqlConnection conn = new MySqlConnection(ConnectionString);
            return conn;
        }
    }
}
