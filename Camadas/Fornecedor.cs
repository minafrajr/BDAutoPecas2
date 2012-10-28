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
        int _idFornecedor;
        string _cnpjFornecedor;
        string _nomeFornecedor; //nomecliente do fornecedor
        string _enderecoFornecedor;
        string _bairroFornecedor;
        string _telefoneFixo;
        string _telefoneCelular;
        string _cepFornecedor;
        DateTime _dataContrato;

        #endregion Atributos

        #region Propriedades dos Atributos
        //Torna as variaveis como propriedades dos objetos
        
        public int IDFornecedor
        {
            get { return _idFornecedor; }
            set { _idFornecedor = value; }
        }

        public string CNPJFornecedor
        {
            get { return _cnpjFornecedor; }
            set { _cnpjFornecedor = value; }
        }
        public string NomeFornecedor
        {
            get { return _nomeFornecedor; }
            set { _nomeFornecedor = value; }
        }
        public string EnderecoFornecedor
        {
            get { return _enderecoFornecedor; }
            set { _enderecoFornecedor = value; }
        }

        public string BairroFornecedor
        {
            get { return _bairroFornecedor; }
            set { _bairroFornecedor = value; }
        }
        public string TelefoneFixo
        {
            get { return _telefoneFixo; }
            set { _telefoneFixo = value; }
        }

        public string CEPFornecedor 
        { 
            get { return _cepFornecedor; } 
            set { _cepFornecedor = value; } 
        }

        public string TelefoneCelular 
        { 
            get {return _telefoneCelular;}
            set { _telefoneCelular = value; } 
        }

        public DateTime DataContrato
        {
            get { return _dataContrato; }
            set { _dataContrato = value; }
        }
        #endregion

        
    }
}