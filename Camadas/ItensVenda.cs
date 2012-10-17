using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Camadas
{
    public class ItensVenda
    {
        public Venda venda;

        private int IDItensVenda;
        private int IDPeca;
        private int IDVenda;
        private double PrecoUnitario;
        private int Quantidade;
        private double SubTotal;

        public int _IDItensVemda
        {
            get
            {
                return IDItensVenda;
            }
            set
            {
                if (this.IDItensVenda != value)
                    this.IDItensVenda = value;
            }
        }

        public int _IDPeca
        {
            get
            {
                return IDPeca;
            }
            set
            {
                if (this.IDPeca != value)
                    this.IDPeca = value;
            }
        }

        public int _IDVenda
        {
            get
            {
                return IDVenda;
            }
            set
            {
                if (this.IDVenda != value)
                    this.IDVenda = value;
            }
        }

        public double _PrecoUnitario
        {
            get
            {
                return PrecoUnitario;
            }
            set
            {
                if (this.PrecoUnitario != value)
                    this.PrecoUnitario = value;
            }
        }

        public int _Quantidade
        {
            get
            {
                return Quantidade;
            }
            set
            {
                if (this.Quantidade != value)
                    this.Quantidade = value;
            }
        }

        public double _SubTotal
        {
            get
            {
                return SubTotal;
            }
            set
            {
                if (this.SubTotal != value)
                    this.SubTotal = value;
            }
        }

    }
}
