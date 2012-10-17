using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Camadas
{
    public class Fornecedor
    {
        #region Atributos

        //Atributos
        int idfornecedor;
        string cnpj;
        string razaosocial; //nomecliente do fornecedor
        string endereco;
        string bairro;
        string telefonefixo;
        string telefonecelular;
        string cep;
        DateTime datacontrato;

        #endregion Atributos

        #region Propriedades dos Atributos
        //Torna as variaveis como propriedades dos objetos
        
        public int IDFornecedor
        {
            get { return idfornecedor; }
            set { idfornecedor = value; }
        }

        public string CNPJ
        {
            get { return cnpj; }
            set { cnpj = value; }
        }
        public string RazaoSocial
        {
            get { return razaosocial; }
            set { razaosocial = value; }
        }
        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }
        public string Telefone
        {
            get { return telefonefixo; }
            set { telefonefixo = value; }
        }

        public string CEP 
        { 
            get { return cep; } 
            set { cep = value; } 
        }

        public string TelefoneCelular 
        { 
            get {return telefonecelular;}
            set { telefonecelular = value; } 
        }

        public DateTime DataContrato
        {
            get { return datacontrato; }
            set { datacontrato = value; }
        }
        #endregion

        
    }
}