using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Camadas
{
    public class ItensVenda
    {
        public Venda venda;

        private int _idItensVenda;
        private int _idPeca;
        private int _idVenda;
        private double _precoUnitario;
        private int _quantidade;
        private double _subtotal;

        public int IDItensVenda
        {
            get
            {
                return _idItensVenda;
            }
            set
            {
                if (this._idItensVenda != value)
                    this._idItensVenda = value;
            }
        }

        public int IDPeca
        {
            get
            {
                return _idPeca;
            }
            set
            {
                if (this._idPeca != value)
                    this._idPeca = value;
            }
        }

        public int IDVenda
        {
            get
            {
                return _idVenda;
            }
            set
            {
                if (this._idVenda != value)
                    this._idVenda = value;
            }
        }

        public double PrecoUnitario
        {
            get
            {
                return _precoUnitario;
            }
            set
            {
                if (this._precoUnitario != value)
                    this._precoUnitario = value;
            }
        }

        public int Quantidade
        {
            get
            {
                return _quantidade;
            }
            set
            {
                if (this._quantidade != value)
                    this._quantidade = value;
            }
        }

        public double Subtotal
        {
            get
            {
                return _subtotal;
            }
            set
            {
                if (this._subtotal != value)
                    this._subtotal = value;
            }
        }

    }
}
