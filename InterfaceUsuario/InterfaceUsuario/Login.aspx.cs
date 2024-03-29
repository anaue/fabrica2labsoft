﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using InterfaceUsuario.Classes;

namespace InterfaceUsuario
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Login1.UserName != "" && Login1.Password != "")
                {
                    Autenticador autenticador = new Autenticador();
                    if (autenticador.Login(Login1.UserName, Login1.Password) != null)
                    {
                        Session["IdUsuario"] = autenticador.IdUsuario;
                        Session["IdTipoAcesso"] = autenticador.IdTipoAcesso;
                        Response.Redirect("ConsultarPatrimonio.aspx");
                    }
                    else
                    {
                        Login1.FailureText = "Usuário ou Senha estão inválidos";
                    }

                }
            }
            catch
            {
                Login1.FailureText = "Usuário ou Senha estão inválidos";
            }
        }


    }
}
