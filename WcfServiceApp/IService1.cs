using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string InsertCliente(Cliente cliente);

        [OperationContract]
        ClienteData GetClientes();

        [OperationContract]
        string UpdateCliente(Cliente cliente);

        [OperationContract]
        string DeleteCliente(Cliente cliente);  




    }

    [DataContract]
    public class Cliente
    {
        int id = 0;
        string cpf = String.Empty;
        string nome = String.Empty;
        string rg = String.Empty;
        string dataexpedicao = String.Empty;
        string orgaoexpedicao = String.Empty;
        string uf = String.Empty;
        DateTime datanascimento = DateTime.Now;
        string sexo = String.Empty;
        string estadocivil = String.Empty;
        string logradouro = String.Empty;
        string cep = String.Empty;
        int numero = 0;
        string ufendereco = String.Empty;
        string complemento = String.Empty;
        string bairro = String.Empty;
        string cidade = String.Empty;


        [DataMember]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        [DataMember]
        public string CPF
        {
            get { return cpf; }
            set { cpf = value; }
        }

        [DataMember]
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        [DataMember]
        public string RG
        {
            get { return rg; }
            set { rg = value; }
        }

        [DataMember]
        public string DataExpedicao
        {
            get { return dataexpedicao; }
            set { dataexpedicao = value; }
        }

        [DataMember]
        public string OrgaoExpedicao
        {
            get { return orgaoexpedicao; }
            set { orgaoexpedicao = value; }
        }

        [DataMember]
        public string UF
        {
            get { return uf; }
            set { uf = value; }
        }

        [DataMember]
        public DateTime DataNascimento
        {
            get { return datanascimento; }
            set { datanascimento = value; }
        }

        [DataMember]
        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        [DataMember]
        public string EstadoCivil
        {
            get { return estadocivil; }
            set { estadocivil = value; }
        }


        [DataMember]
        public string CEP
        {
            get { return cep; }
            set { cep = value; }
        }


        [DataMember]
        public string Logradouro
        {
            get { return logradouro; }
            set { logradouro = value; }
        }


        [DataMember]
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }


        [DataMember]
        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }


        [DataMember]
        public string UfEndereco
        {
            get { return ufendereco; }
            set { ufendereco = value; }
        }


        [DataMember]
        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }


        [DataMember]
        public string Complemento
        {
            get { return complemento; }
            set { complemento = value; }
        }
    }

    [DataContract]
    public class ClienteData
    {
        public ClienteData()
        {
            this.ClienteTable = new DataTable("ClienteData");
        }

        [DataMember]
        public DataTable ClienteTable { get; set; }
    }

}
