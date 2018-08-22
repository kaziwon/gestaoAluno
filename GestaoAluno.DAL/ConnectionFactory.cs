﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAluno.DAL
{
    public class ConnectionFactory
    {
        public static DbConnection banco()
        {
            var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["banco"].ConnectionString);
            connection.Open();
            return connection;
        }
    }
}
