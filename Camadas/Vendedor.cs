using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Camadas
{
    public class Vendedor
    {
        private int _idVendedor;

        public int IDVendedor
        {
            get { return _idVendedor; }
            set { _idVendedor = value; }
        }

        private int _nCadastro;

        public int NCadastro
        {
            get { return _nCadastro; }
            set { _nCadastro = value; }
        }


        private string _nomeVendedor;

        public string NomeVendedor
        {
            get { return _nomeVendedor; }
            set { _nomeVendedor = value; }
        }

        private string _endereco;

        public string Endereco
        {
            get { return _endereco; }
            set { _endereco = value; }
        }

        private DateTime _dataAdm;

        public DateTime DataAdm
        {
            get { return _dataAdm; }
            set { _dataAdm = value; }
        }

        private string _telFixo;

        public string TelFixo
        {
            get { return _telFixo; }
            set { _telFixo = value; }
        }

        private string _telCel;

        public string TelCel
        {
            get { return _telCel; }
            set { _telCel = value; }
        }

        private string _cpf;

        public string CPF
        {
            get { return _cpf; }
            set { _cpf = value; }
        }

        private string _estadoCivil;

        public string EstadoCivil
        {
            get { return _estadoCivil; }
            set { _estadoCivil = value; }
        }


    }
}
