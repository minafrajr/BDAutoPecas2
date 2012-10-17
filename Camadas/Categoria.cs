using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Camadas
{
    public class Categoria
    {
        private int idcategoria;

        public int IDCategoria
        {
            get { return idcategoria; }
            set { idcategoria = value; }
        }


        private string nomecategoria;

        public string NomeCategoria
        {
            get { return nomecategoria; }
            set { nomecategoria = value; }
        }

        private string descricao;

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

    }
}
