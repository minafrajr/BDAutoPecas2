using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Camadas
{
    public class Models
    {
        private string anoveiculo;
        private string catdescricao;
        private string celularcliente;
        private string cep;
        private long cnpj;
        private long cpf;
        private string enderecocliente;
        private string fabricante;
        private int idcategoria;
        private int idcliente;
        private int idfornecedor;
        private int idpeca;

        private int idveiculo;

        private string nomecategoria;

        private string nomecliente;

        private string nomefornecedor;

        private string nomepeca;

        private string nomeveiculo;

        private string telefonecliente;

        public string AnoVeiculo
        {
            get { return anoveiculo; }
            set { anoveiculo = value; }
        }

        public string CateDescricao
        {
            get { return catdescricao; }
            set { catdescricao = value; }
        }

        public string CelularCliente
        {
            get { return celularcliente; }
            set { celularcliente = value; }
        }

        public string CEP
        {
            get { return cep; }
            set { cep = value; }
        }

        public long CNPJ
        {
            get { return cnpj; }
            set { cnpj = value; }
        }

        public long CPF
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public string EndereçoCliente
        {
            get { return enderecocliente; }
            set { enderecocliente = value; }
        }

        public string Fabricante
        {
            get { return fabricante; }
            set { fabricante = value; }
        }

        public int IDCategoria
        {
            get { return idcategoria; }
            set { idcategoria = value; }
        }

        public int IDCliente
        {
            get { return idcliente; }
            set { idcliente = value; }
        }

        public int IDFornecedor
        {
            get { return idfornecedor; }
            set { idfornecedor = value; }
        }

        public int IDPeca
        {
            get { return idpeca; }
            set { idpeca = value; }
        }

        public int IDVeiculo
        {
            get { return idveiculo; }
            set { idveiculo = value; }
        }

        public string NomeCategoria
        {
            get { return nomecategoria; }
            set { nomecategoria = value; }
        }

        public string NomeCliente
        {
            get { return nomecliente; }
            set { nomecliente = value; }
        }

        public string Nomefornecedor
        {
            get { return nomefornecedor; }
            set { nomefornecedor = value; }
        }

        public string NomePeca
        {
            get { return nomepeca; }
            set { nomepeca = value; }
        }

        public string NomeVeiculo
        {
            get { return nomeveiculo; }
            set { nomeveiculo = value; }
        }

        public string TelefoneCliente
        {
            get { return telefonecliente; }
            set { telefonecliente = value; }
        }

        private string endfornecedor;

        public string EnderecoFornecedor
        {
            get { return endfornecedor; }
            set { endfornecedor = value; }
        }
        private double quant;

        public double Quant
        {
            get { return quant; }
            set { quant = value; }
        }

        private double preco;

        public double Preco
        {
            get { return preco; }
            set { preco = value; }
        }

       

    }
}