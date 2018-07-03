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
    public partial class Atualizacao : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                clientes cliente = ClientesDAO.BuscarId(Convert.ToInt32(Request["id"]));
                txtId.Text = cliente.id.ToString();
                txtNome.Text = cliente.nome;
                txtEmail.Text = cliente.email;
                txtSaldo.Text = cliente.saldo.ToString();
                txtSenha.Text = cliente.senha;
                txtNasc.Text = cliente.dataNasc.ToString("dd/MM/yyyy");
            }

        }

        protected void btnAtualizar_Click(object sender, EventArgs e)
        {
            clientes cliente = new clientes();
            cliente.id = Convert.ToInt32(txtId.Text);
            cliente.nome = txtNome.Text;
            cliente.email = txtEmail.Text;
            cliente.saldo = Convert.ToDouble(txtSaldo.Text);
            cliente.senha = txtSenha.Text;
            cliente.dataNasc = Convert.ToDateTime(txtNasc.Text);
            if (ClientesDAO.Atualizar(cliente))
            {
                lblResposta.Text = "Atualizado com sucesso";
            }
            else
            {
                lblResposta.Text = "Erro ao atualizar";
            }
        }

        protected void btnDeletar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            if (ClientesDAO.Deletar(id))
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Deletado com sucesso');window.location ='Gerencia.aspx';", true);

            }
            else
            {
                lblResposta.Text = "Erro ao deletar";
            }
        }
    }
}