﻿using Microsoft.Ajax.Utilities;
using MySql.Data.MySqlClient;
using Projeto10Vazio.Dados;
using Projeto10Vazio.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace Projeto10Vazio.Acoes
{
    public class acLogin
    {
        conexao cone = new conexao();

        //Metodo para Logar
        public void Cadastrar(modelLogin model)
        {

            MySqlCommand cmd = new MySqlCommand("insert into LOGIN(Usuario, Senha) values(@Usuario, @Senha)", cone.MyConnectBd());

            cmd.Parameters.Add("@Usuario", MySqlDbType.VarChar).Value = model.Usuario;
            cmd.Parameters.Add("@Senha", MySqlDbType.VarChar).Value = model.Senha;

            cmd.ExecuteNonQuery();

            cone.MyDesConnectBd();



        }

        public modelLogin Verificar(modelLogin model)
        {

            MySqlCommand cmd = new MySqlCommand("select * from login where usuario = '@usuario' and senha = '@senha'", cone.MyConnectBd());

            cmd.Parameters.Add("@Usuario", MySqlDbType.VarChar).Value = model.Usuario;
            cmd.Parameters.Add("@Senha", MySqlDbType.VarChar).Value = model.Senha;

            MySqlDataReader leitor;

            leitor = cmd.ExecuteReader();


            


            if (leitor.HasRows)
            {
                while (leitor.Read())
                {

                    modelLogin login = new modelLogin();
                    {
                        login.Usuario = Convert.ToString(leitor["Usuario"]);
                        login.Senha = Convert.ToString(leitor["Senha"]);
                    }

                }



            }
            else
            {
                model.Usuario = null; 
                model.Senha = null;
            }
              
            return model;

        }

   


    }

}
