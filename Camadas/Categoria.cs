using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Camadas
{
    public class Categoria
    {
        private int _idCategoria;

        public int IDCategoria
        {
            get { return _idCategoria; }
            set { _idCategoria = value; }
        }


        private string _nomeCategoria;

        public string NomeCategoria
        {
            get { return _nomeCategoria; }
            set { _nomeCategoria = value; }
        }

        private string _descricao;

        public string Descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }

    }
}
