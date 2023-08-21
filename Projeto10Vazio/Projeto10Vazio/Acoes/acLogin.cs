using Microsoft.Ajax.Utilities;
using MySql.Data.MySqlClient;
using Projeto10Vazio.Dados;
using Projeto10Vazio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto10Vazio.Acoes
{
    public class acLogin
    {
        conexao cone = new conexao();

        //Metodo para Logar
        public void Logar(modelLogin model)
        {

            MySqlCommand cmd = new MySqlCommand("insert into LOGIN(Usuario, Senha) values(@Usuario, @Senha)", cone.MyConnectBd());

            cmd.Parameters.Add("@Usuario", MySqlDbType.VarChar).Value = model.Usuario;
            cmd.Parameters.Add("@Senha", MySqlDbType.VarChar).Value = model.Senha;

            cmd.ExecuteNonQuery();

            cone.MyDesConnectBd();



        }

        public int Verificar(modelLogin model)
        {

            MySqlCommand cmd = new MySqlCommand("select * from LOGIN where Usuario='@Usuario' and Senha='@Senha' ", cone.MyConnectBd());

            cmd.Parameters.Add("@Usuario", MySqlDbType.VarChar).Value = model.Usuario;
            cmd.Parameters.Add("@Senha", MySqlDbType.VarChar).Value = model.Senha;

            MySqlDataReader reader = cmd.ExecuteReader();

            cone.MyDesConnectBd();

          

          
            if (model.Usuario == "admin" && model.Senha == "1234567")
            {
                return 1;
            }

            return 2;
          
        }



    

            
          
          

        }
    }
