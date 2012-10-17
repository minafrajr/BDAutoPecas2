using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camadas
{
    /// <summary>
    /// Classe Cliente.
    /// </summary>
    public class Cliente
    {
        #region PROPRIEDADES

        private int id_cliente;
        public int ID_Cliente
        {
            get { return id_cliente; }
            set { id_cliente = value; }
        }
        
        private string nomecliente;
        public string NomeCliente
        {
            get { return nomecliente; }
            set { nomecliente = value; }
        }

        private string cpf;
        public string CPF
        {
            get { return cpf; }
            set { cpf = value; }
        }

        private string cnpj;
        public string CNPJ
        {
            get { return cnpj; }
            set { cnpj = value; }
        }

        private string logradouro;
        public string Logradouro
        {
            get { return logradouro; }
            set { logradouro = value; }
        }

        private string  numero_residencia;
        public string  N_Residencia
        {
            get { return numero_residencia; }
            set { numero_residencia = value; }
        }

        private string bairro;
        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }
        
        private string cidade;
        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }

        private string uf;
        public string UF
        {
            get { return uf; }
            set { uf = value; }
        }

        private string cep;
        public string CEP
        {
            get { return cep; }
            set { cep = value; }
        }

        private string telefone_fixo;
        public string Telefone_Fixo
        {
            get { return telefone_fixo; }
            set { telefone_fixo = value; }
        }

        private string telefone_celular;
        public string Telefone_Celular
        {
            get { return telefone_celular; }
            set { telefone_celular = value; }
        }
                
        

        #endregion
                
    }
}
