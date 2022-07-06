using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.ServiceModel;
using System.Runtime.Serialization;
using WebFormsApp.ServiceReference1;

namespace WebFormsApp
{
    public partial class _Default : Page
    {
        ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            GridView1.DataSource = client.GetClientes().ClienteTable;
            GridView1.DataBind();
        }

        protected void btnInserir_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Nome = txtNome.Text;
            cliente.CPF = txtCPF.Text;
            cliente.RG = txtRG.Text;
            cliente.DataExpedicao = txtDataExp.Text;
            cliente.OrgaoExpedicao = txtOrgaoExp.Text;
            cliente.EstadoCivil = txtEstado.Text;
            cliente.Sexo = txtSexo.Text;
            cliente.DataNascimento = Convert.ToDateTime(txtDataNasc.Text);
            cliente.UF = txtUF.Text;
            cliente.CEP = txtCEP.Text;
            cliente.Logradouro = txtLogradouro.Text;
            cliente.Numero = Convert.ToInt32(txtNumero.Text);
            cliente.Bairro = txtBairro.Text;
            cliente.Cidade = txtCidade.Text;
            cliente.UfEndereco = txtUFendereco.Text;
            cliente.Complemento = txtComplemento.Text;
            client.InsertCliente(cliente);

            Response.Redirect(Request.Url.AbsoluteUri);
        }

        protected void btnAtualiza_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Id = Convert.ToInt32(txtID.Text);
            cliente.Nome = txtNome.Text;
            cliente.CPF = txtCPF.Text;
            cliente.RG = txtRG.Text;
            cliente.DataExpedicao = txtDataExp.Text;
            cliente.OrgaoExpedicao = txtOrgaoExp.Text;
            cliente.EstadoCivil = txtEstado.Text;
            cliente.Sexo = txtSexo.Text;
            cliente.DataNascimento = Convert.ToDateTime(txtDataNasc.Text);
            cliente.UF = txtUF.Text;
            cliente.CEP = txtCEP.Text;
            cliente.Logradouro = txtLogradouro.Text;
            cliente.Numero = Convert.ToInt32(txtNumero.Text);
            cliente.Bairro = txtBairro.Text;
            cliente.Cidade = txtCidade.Text;
            cliente.UfEndereco = txtUFendereco.Text;
            cliente.Complemento = txtComplemento.Text;

            client.UpdateCliente(cliente);

            Response.Redirect(Request.Url.AbsoluteUri);
        }

        protected void btnDeletarCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Id = Convert.ToInt32(txtID.Text);
            client.DeleteCliente(cliente);
            Response.Redirect(Request.Url.AbsoluteUri);
        }
    }
}