using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Camadas
{
    public class Venda
    {
        #region Atributos

        //Atributos

        private int _idVenda;
        private int _idVendedor;
        private int _idCliente;
        private double _precoTotal;
        private double _desconto;
        private string _CPF;
        private string _Nome;
        private string _Endereco;
        private string _Numero;
        private string _Bairro;
        private string _Telefone;
        private DateTime _dataVenda ;
        private DateTime _Hora ; 

        #endregion Atributos

        #region Propriedades dos Atributos
        //Torna as variaveis como propriedades dos objetos

        

        public int IDVendedor
        {
            get { return _idVendedor; }
            set { _idVendedor = value; }
        }       
        public int IDCliente
        {
            get { return _idCliente; }
            set { _idCliente = value; }
        }
        public int IDVenda
        {
            get { return _idVenda; }
            set { _idVenda = value; }
        }
        public double PrecoTotal
        {
            get { return _precoTotal; }
            set { _precoTotal = value; }
        }
        public double Desconto
        {
            get { return _desconto; }
            set { _desconto = value; }
        }
        public string CPF
        {
            get { return _CPF; }
            set { _CPF = value; }
        }
        public string Nome
        {
            get { return _Nome; }
            set { _Nome = value; }
        }
        public string Endereco
        {
            get { return _Endereco; }
            set { _Endereco = value; }
        }

        public string Numero
        {
            get { return _Numero; }
            set { _Numero = value; }
        }
        public string Bairro
        {
            get { return _Bairro; }
            set { _Bairro = value; }
        }
        public string Telefone
        {
            get { return _Telefone; }
            set { _Telefone = value; }
        }
        public DateTime DataVenda
        {
            get { return _dataVenda = RetornaHoraData(); }
            
        }
        public DateTime Hora
        {
            get { return _Hora = RetornaHoraData(); }
            
        }

        #endregion Propriedades dos atributos

        #region Metodos e Funcoes
        
        //Função bolleana para validar CPF
        public bool Valida_CPF()
        {
            int[] Multiplicador1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] Multiplicador2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            string auxCPF = _CPF;

            if (auxCPF.Length != 11)
                return false;

            tempCpf = auxCPF.Substring(0, 9);

            soma = 0;
            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * Multiplicador1[i];

            resto = soma % 11;

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = resto.ToString();

            tempCpf = tempCpf + digito;

            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * Multiplicador2[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            return auxCPF.EndsWith(digito);
        }
        
        //Função para gerar a data atual e hora
        static private DateTime RetornaHoraData()
        {
            DateTime data;
            data = System.DateTime.Now;
            return data;
            
        }
                 
        #endregion Metodos e funcoes
    }
}
