using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Camadas
{
    public class Veiculo
    {

        #region Propriedades e Atributos

        private int idveiculo;

        public int IDVeiculo
        {
            get { return idveiculo; }
            set { idveiculo = value; }
        }

        private string nomeveiculo;

        public string NomeVeiculo
        {
            get { return nomeveiculo; }
            set { nomeveiculo = value; }
        }

        private string fabricante;

        public string Fabricante
        {
            get { return fabricante; }
            set { fabricante = value; }
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

        private DateTime anoinicial;

        public DateTime AnoInicial
        {
            get { return anoinicial; }
            set { anoinicial = value; }
        }

        private DateTime anofinal;

        public DateTime AnoFinal
        {
            get { return anofinal; }
            set { anofinal = value; }
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
            this.idveiculo = _idveiculo;
            this.nomeveiculo = _nomeveiculo;
            this.marca = _marca;
            this.modelo = _modelo;
            this.fabricante = _fabricante;
            this.anoinicial = _anoinicial;
            this.anofinal = _anofinal;
            this.cilindrada = _cilindrada;
        }

        #endregion
    }
}
