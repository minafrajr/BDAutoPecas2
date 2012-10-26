using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Camadas
{
    class AuxItensdeVenda
    {
        private string conexao = "Data Source = CASA; Initial Catalog = AUTOPECAS; Integrated Security = True; ";
        
        public AuxItensdeVenda()
        {
            SqlConnection conexao = new SqlConnection(conexao);
        }

    }
}
