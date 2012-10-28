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

        private int _idCliente;
        public int IDCliente
        {
            get { return _idCliente; }
            set { _idCliente = value; }
        }
        
        private string _nomeCliente;
        public string NomeCliente
        {
            get { return _nomeCliente; }
            set { _nomeCliente = value; }
        }

        private string _cpf;
        public string CPF
        {
            get { return _cpf; }
            set { _cpf = value; }
        }

        private string _cnpj;
        public string CNPJ
        {
            get { return _cnpj; }
            set { _cnpj = value; }
        }

        private string _enderecoCliente;
        public string EnderecoCliente
        {
            get { return _enderecoCliente; }
            set { _enderecoCliente = value; }
        }

        private string _bairro;
        public string Bairro
        {
            get { return _bairro; }
            set { _bairro = value; }
        }
        
        private string _cidade;
        public string Cidade
        {
            get { return _cidade; }
            set { _cidade = value; }
        }

        private string _uf;
        public string UF
        {
            get { return _uf; }
            set { _uf = value; }
        }

        private string _cep;
        public string CEP
        {
            get { return _cep; }
            set { _cep = value; }
        }

        private string _telefoneCliente;
        public string TelefoneCliente
        {
            get { return _telefoneCliente; }
            set { _telefoneCliente = value; }
        }

        private string _celularCliente;
        public string CelularCliente
        {
            get { return _celularCliente; }
            set { _celularCliente = value; }
        }

          
        

        #endregion
                
    }
}
