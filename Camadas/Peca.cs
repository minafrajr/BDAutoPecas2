using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camadas
{
    /// <summary>
    /// Classe Peça.
    /// </summary>
    public class Peca
    {
        #region PROPRIEDADES

        private string _nomePeca;

        public string NomePeca
        {
            get { return _nomePeca; }
            set { _nomePeca = value; }
        }
        private int _idCategoria;

        public int IDCategoria
        {
            get { return _idCategoria; }
            set { _idCategoria = value; }
        }

        private double _precoPeca;

        public double PrecoPeca
        {
            get { return _precoPeca; }
            set { _precoPeca = value; }
        }

        private int _quantidade;

        public int  Quantidade
        {
            get { return _quantidade; }
            set { _quantidade = value; }
        }
        
        private string fabricante;

        public string Fabricante
        {
            get { return fabricante; }
            set { fabricante = value; }
        }

        private string descricao;

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        
        private int _idVeiculo;

        public int IDVeiculo
        {
            get { return _idVeiculo; }
            set { _idVeiculo = value; }
        }

        private int idpeca;

        public int IDPeca
        {
            get { return idpeca; }
            set { idpeca = value; }
        }

        private int _idFornecedor;
        public int IDFornecedor
        {
            get { return _idFornecedor; }
            set { _idFornecedor = value; }
        }

        private double _precoEstocado;

        public double PrecoEstocado
        {
            get { return _precoEstocado; }
            set { _precoEstocado = value; }
        }


        #endregion

    }
}
