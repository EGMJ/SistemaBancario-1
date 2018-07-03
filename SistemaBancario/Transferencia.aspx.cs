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
    public partial class Transferencia : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            clientes cliente = ClientesDAO.BuscarId(Convert.ToInt32(Request["id"]));
            lblSaldo.Text = cliente.saldo.ToString();
            lblCliente.Text = "Olá "+ cliente.nome+ " seu saldo é de R$ "+ lblSaldo.Text;
            lblidtransf.Text = cliente.id.ToString();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string email = txtBusca.Text;
            clientes cliente = ClientesDAO.BuscarPorEmail(email);
            if (cliente != null )
            {
                btnTransferir.Enabled = true;
                lblNome.Text = cliente.nome;
                lblIdreceb.Text = cliente.id.ToString();
            }
        }

        protected void btnTransferir_Click(object sender, EventArgs e)
        {
            double quantia = Convert.ToDouble(txtQuantia.Text);
            if (quantia<=Convert.ToDouble(lblSaldo.Text))
            {
                int idtransf = Convert.ToInt32(lblidtransf.Text);
                int idreceb = Convert.ToInt32(lblIdreceb.Text);
                if (ClientesDAO.Transferir(idtransf,idreceb, quantia))
                {
                    lblResultadoo.Text = "Transferido com Sucesso";
                }
                else
                {
                    lblResultadoo.Text = "Erro ao transferir";
                }
            }
            else
            {
                lblResultadoo.Text = "Saldo insuficiente";
            }
        }
    }
}