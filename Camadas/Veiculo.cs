using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Camadas
{
    public class Veiculo
    {

        #region Propriedades e Atributos

        private int _idVeiculo;

        public int IDVeiculo
        {
            get { return _idVeiculo; }
            set { _idVeiculo = value; }
        }

        private string _nomeVeiculo;

        public string NomeVeiculo
        {
            get { return _nomeVeiculo; }
            set { _nomeVeiculo = value; }
        }

        private string _fabricante;

        public string Fabricante
        {
            get { return _fabricante; }
            set { _fabricante = value; }
        }

        private string marca;

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        private double cilindrada;

        public double Cilindrada
        {
            get { return cilindrada; }
            set { cilindrada = value; }
        }

        private DateTime _anoInicial;

        public DateTime AnoInicial
        {
            get { return _anoInicial; }
            set { _anoInicial = value; }
        }

        private DateTime _anoFinal;

        public DateTime AnoFinal
        {
            get { return _anoFinal; }
            set { _anoFinal = value; }
        }

        private string modelo;

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }


        #endregion

        #region Construtoras da classe

        /// <summary>
        /// Construtora Vazia para instanciamento do objeto.
        /// </summary>
        public Veiculo(){}

        /// <summary>
        /// Cria o objeto Veiculo.
        /// </summary>
        /// <param name="_idveiculo">Código do veículo</param>
        /// <param name="_nomeveiculo">NomeCliente do veículo</param>
        /// <param name="_marca">fabricante</param>
        /// <param name="_anoinicial">ano inicial do veiculo que a peca serve</param>
        /// <param name="_anofinal">ano témino do veiculo que a perça serve</param>
        /// <param name="_cilindrada">a potencia em cilindrada do veiculo</param>
        public Veiculo(int _idveiculo,string _nomeveiculo,string _fabricante,string _marca,string _modelo,DateTime _anoinicial, DateTime _anofinal,double _cilindrada )
        {
            this._idVeiculo = _idveiculo;
            this._nomeVeiculo = _nomeveiculo;
            this.marca = _marca;
            this.modelo = _modelo;
            this._fabricante = _fabricante;
            this._anoInicial = _anoinicial;
            this._anoFinal = _anofinal;
            this.cilindrada = _cilindrada;
        }

        #endregion
    }
}
