﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.Model
{
    class _Conexao
    {
        SqlConnection con = new SqlConnection();

        public _Conexao()
        {
            con.ConnectionString = "Server=localhost;Database=master;Trusted_Connection=True;";//KEVEN SLT
        }

        public SqlConnection Conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }

            return con;
        }

        public void Desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }

        }
    }
}
