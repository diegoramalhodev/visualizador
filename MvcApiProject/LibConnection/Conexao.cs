using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace LibConnection
{
        public class Conexao
        {
            private static NpgsqlConnection conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStr"].ConnectionString);
            // private static string StringConn = ConfigurationManager.ConnectionStrings["ConnectionStr"].ConnectionString;

            public static void Abre()
            {
                try
                {
                    //conn = new SqlConnection(StringConn);
                    conn.Open();
                }
                catch (Exception)
                {
                    //Levanta uma excessão que deve ser tratada pelo método chamador
                    throw new Exception("Erro de conexão com o banco.");
                }
            }

            /// <summary>
            /// Fecha a conexão com o banco de dados.
            /// </summary>
            public static void Fecha()
            {
                try
                {
                    conn.Close();
                }
                catch (Exception)
                {
                    //Levanta uma excessão que deve ser tratada pelo método chamador
                    throw new Exception("Erro no fechamento da conexão com o banco.");
                }
            }

            public static NpgsqlConnection conexao
            {
                get { return conn; }
                set { conn = value; }
            }



            /*public static DataSet consulta(String sql)
            {
                try
                {
                    String banco = ConfigurationManager.ConnectionStrings["banco"].ConnectionString;

                    //string conexao = "Provider=Microsoft.SQLSERVER.CE.OLEDB.3.5;data source=" + System.AppDomain.CurrentDomain.BaseDirectory.ToString() + banco + ";";
                    //string conexao = "Provider=Microsoft.SQLSERVER.CE.OLEDB.3.5;data source=" + banco + ";";
                    //string conexao = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

                    //string conexao = @"Server=.\SQLExpress;Database=" + System.AppDomain.CurrentDomain.BaseDirectory.ToString() + banco + ";";
                    //string conexao = @"Server=.\SQLExpress;AttachDbFilename=" + banco + ";Integrated Security=True;Connect Timeout=30;User Instance=True;";
                    string conexao = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=" + banco + ";Integrated Security=True";

                    ConexaoStatus.Abre(conexao);

                    SqlCommand command = new SqlCommand(sql, ConexaoStatus.conexao);
                    SqlDataAdapter da = new SqlDataAdapter(command);

                    DataSet ds = new DataSet();

                    da.Fill(ds);
                    return ds;
                }
                catch (Exception exc)
                {
                    //Levanta uma excessão que deve ser tratada pelo método chamador
                    throw new Exception("Erro na realização da consulta: " + exc.Message);
                }
                finally
                {
                    ConexaoStatus.Fecha();
                }
            }*/
    }
}
