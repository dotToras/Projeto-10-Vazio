using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Projeto10Vazio.Dados
{
    public class conexao
    {



        MySqlConnection cn = new MySqlConnection("Server=localhost;DataBase=BD; User=root; pwd=12345678");
        public static string msg;



        public MySqlConnection MyConnectBd() /*Método para Conectar*/
        {

            try
            {
                cn.Open();
            }
            catch (Exception erro)
            {
                msg = "Ocorreu um erro ao se conectar" + erro.Message;

            }
            return cn;
        }

        public MySqlConnection MyDesConnectBd() /*Método para desconectar*/
        {

            try
            {
                cn.Close();
            }
            catch (Exception erro)
            {
                msg = "Ocorreu um erro ao se desconectar" + erro.Message;

            }
            return cn;
        }




    }
}