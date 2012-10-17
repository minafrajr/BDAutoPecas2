using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Camadas
{
    public class Vendedor
    {
        private int numeroCadastro;

        public int NumCadastro
        {
            get { return numeroCadastro; }
            set { numeroCadastro = value; }
        }

        private string nomevendedor;

        public string NomeVendedor
        {
            get { return nomevendedor; }
            set { nomevendedor = value; }
        }

        private string endereco;

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        private DateTime dataadmissao;

        public DateTime DataAdmissao
        {
            get { return dataadmissao; }
            set { dataadmissao = value; }
        }

        private string telefonefixo;

        public string TelefoneFixo
        {
            get { return telefonefixo; }
            set { telefonefixo = value; }
        }

        private string telefonecelular;

        public string TelefoneCelular
        {
            get { return telefonecelular; }
            set { telefonecelular = value; }
        }

        private double cpf;

        public double CPF
        {
            get { return cpf; }
            set { cpf = value; }
        }

        private string estadocivil;

        public string EstadoCivil
        {
            get { return estadocivil; }
            set { estadocivil = value; }
        }


    }
}
