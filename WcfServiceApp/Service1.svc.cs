using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string dbConnection = "Data Source=HYL-009146\\SQLEXPRESS; Initial Catalog=GTI_DB; Integrated Security=True";
        public string InsertCliente(Cliente cliente)
        {
            string Message;
            SqlConnection con = new SqlConnection(dbConnection);
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Clientes(CPF,Nome,RG,DataExpedicao,OrgaoExpedicao,UF,DataNascimento,Sexo,EstadoCivil,CEP,Logradouro,Numero,Bairro,Cidade,UfEndereco,Complemento) values(@CPF,@Nome,@RG,@DataExpedicao,@OrgaoExpedicao,@UF,@DataNascimento,@Sexo,@EstadoCivil,@CEP,@Logradouro,@Numero,@Bairro,@Cidade,@UfEndereco,@Complemento)", con);
            cmd.Parameters.AddWithValue("@CPF", cliente.CPF);
            cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
            cmd.Parameters.AddWithValue("@RG", cliente.RG);
            cmd.Parameters.AddWithValue("@DataExpedicao", cliente.DataExpedicao);
            cmd.Parameters.AddWithValue("@OrgaoExpedicao", cliente.OrgaoExpedicao);
            cmd.Parameters.AddWithValue("@UF", cliente.UF);
            cmd.Parameters.AddWithValue("@DataNascimento", cliente.DataNascimento);
            cmd.Parameters.AddWithValue("@Sexo", cliente.Sexo);
            cmd.Parameters.AddWithValue("@CEP", cliente.CEP);
            cmd.Parameters.AddWithValue("@Logradouro", cliente.Logradouro);
            cmd.Parameters.AddWithValue("@Numero", cliente.Numero);
            cmd.Parameters.AddWithValue("@Bairro", cliente.Bairro);
            cmd.Parameters.AddWithValue("@Cidade", cliente.Cidade);
            cmd.Parameters.AddWithValue("@UfEndereco", cliente.UfEndereco);
            cmd.Parameters.AddWithValue("@Complemento", cliente.Complemento);
            cmd.Parameters.AddWithValue("@EstadoCivil", cliente.EstadoCivil);
            int result = cmd.ExecuteNonQuery();
            if (result == 1)
            {
                Message = cliente.Nome + " Details inserted successfully";
            }
            else
            {
                Message = cliente.Nome + " Details not inserted successfully";
            }
            con.Close();
            return Message;
        }

        public ClienteData GetClientes()
        {

            using (SqlConnection con = new SqlConnection(dbConnection))
            {
                using (SqlCommand cmd = new SqlCommand("select * from Clientes"))
                {
                    using(SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            ClienteData clientes = new ClienteData();
                            sda.Fill(clientes.ClienteTable);
                            return clientes;
                        }
                    }
                }
            }
        }

        public string UpdateCliente(Cliente cliente)
        {
            string Message;
            SqlConnection con = new SqlConnection(dbConnection);
            con.Open();
            SqlCommand cmd = new SqlCommand("update Clientes set CPF = @CPF ,Nome = @Nome, RG = @RG , DataExpedicao = @DataExpedicao, OrgaoExpedicao = @OrgaoExpedicao , UF = @UF, DataNascimento = @DataNascimento,Sexo = @Sexo, EstadoCivil = @EstadoCivil, CEP = @CEP,Logradouro = @Logradouro, Numero = @Numero, Bairro = @Bairro, Cidade = @Cidade, UfEndereco = @UfEndereco, Complemento = @Complemento where Id = @Id", con);
            cmd.Parameters.AddWithValue("@CPF", cliente.CPF);
            cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
            cmd.Parameters.AddWithValue("@RG", cliente.RG);
            cmd.Parameters.AddWithValue("@DataExpedicao", cliente.DataExpedicao);
            cmd.Parameters.AddWithValue("@OrgaoExpedicao", cliente.OrgaoExpedicao);
            cmd.Parameters.AddWithValue("@UF", cliente.UF);
            cmd.Parameters.AddWithValue("@DataNascimento", cliente.DataNascimento);
            cmd.Parameters.AddWithValue("@Sexo", cliente.Sexo);
            cmd.Parameters.AddWithValue("@EstadoCivil", cliente.EstadoCivil);
            cmd.Parameters.AddWithValue("@CEP", cliente.CEP);
            cmd.Parameters.AddWithValue("@Logradouro", cliente.Logradouro);
            cmd.Parameters.AddWithValue("@Numero", cliente.Numero);
            cmd.Parameters.AddWithValue("@Bairro", cliente.Bairro);
            cmd.Parameters.AddWithValue("@Cidade", cliente.Cidade);
            cmd.Parameters.AddWithValue("@UfEndereco", cliente.UfEndereco);
            cmd.Parameters.AddWithValue("@Complemento", cliente.Complemento);
            cmd.Parameters.AddWithValue("@Id", cliente.Id);
            int result = cmd.ExecuteNonQuery();
            if (result == 1)
            {
                Message = cliente.Nome + " Details inserted successfully";
            }
            else
            {
                Message = cliente.Nome + " Details not inserted successfully";
            }
            con.Close();
            return Message;
        }

        public string DeleteCliente(Cliente cliente)
        {
            string Message;
            SqlConnection con = new SqlConnection(dbConnection);
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from Clientes where Id = @Id", con);
            cmd.Parameters.AddWithValue("@Id", cliente.Id);
            int result = cmd.ExecuteNonQuery();
            if (result == 1)
            {
                Message = cliente.Nome + " Cliente deleted successfully";
            }
            else
            {
                Message = cliente.Nome + " Cliente not deleted successfully";
            }
            con.Close();
            return Message;
        }
    }
}
