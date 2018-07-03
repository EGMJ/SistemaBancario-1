using SistemaBancario.DAO;
using SistemaBancario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaBancario
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogar_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string senha = txtSenha.Text;
            clientes login = ClientesDAO.Login(email, senha);
            if (login != null)
            {
                if (login.flg_admin == "1")
                {
                    Response.Redirect("Gerencia.aspx");
                }
                if (login.flg_admin == "0")
                {
                    Response.Redirect("Transferencia.aspx?id="+login.id);
                }
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Email ou Senha incorretos');window.location ='Default.aspx';", true);
            }
        }
    }
}