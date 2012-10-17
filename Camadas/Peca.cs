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

        private string nomepeca;

        public string NomePeca
        {
            get { return nomepeca; }
            set { nomepeca = value; }
        }
        private int idcategoria;

        public int IDCategoria
        {
            get { return idcategoria; }
            set { idcategoria = value; }
        }

        private uint precounitario;

        public uint PrecoUnitario
        {
            get { return precounitario; }
            set { precounitario = value; }
        }

        private uint quantidadeestoque;

        public uint  QuatidadeEstoque
        {
            get { return quantidadeestoque; }
            set { quantidadeestoque = value; }
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

        
        private int idveiculo;

        public int IDVeiculo
        {
            get { return idveiculo; }
            set { idveiculo = value; }
        }

        private int idpeca;

        public int IDPeca
        {
            get { return idpeca; }
            set { idpeca = value; }
        }
        private int idfornecedor;

        public int IDFornecedor
        {
            get { return idfornecedor; }
            set { idfornecedor = value; }
        }

        #endregion

    }
}
