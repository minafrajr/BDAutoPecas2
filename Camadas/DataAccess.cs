using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.IO;

namespace Camadas
{
    internal class DataAccess
    {
        private string comandosql;
        private SqlCommand ComandoTSQL;
        private SqlConnection Conectionsql;

        /*essa string conecta com o serviço local*/
        private string conexao = "Data Source = DELL; Initial Catalog = AUTOPECAS; Integrated Security = True; ";

        //essa conexão deu certo no servidor GENESIS via IP
        //private string conexao = "Data Source=192.168.0.100,1433; Initial Catalog=AUTOPECAS; User ID=sa; Password=1234";

        /* 
         * Acesso via IP
         * "Data Source=192.168.200.100,1433; Network Library=DBMSSOCN;Initial Catalog=myDataBase;User ID=myUsername;Password=myPassword;
         * 
         * deu certo         private string conexao = "Data Source=192.168.0.100,1433; User ID=sa; Initial Catalog=AUTOPECAS; 
         * 
         * 1433 porta padrão do sqlserver
        */
        //acesso aos dados


        public int numpecas()
        {
            try
            {
                int num;
                DataTable dt = new DataTable();
                comandosql = "SELECT Count(IDPeca) FROM Pecas" ;

                using (Conectionsql = new SqlConnection(conexao))
                {
                    Conectionsql.Open();

                    using (ComandoTSQL = new SqlCommand(comandosql, Conectionsql))
                    {
                        SqlDataReader Leitor = ComandoTSQL.ExecuteReader();
                        
                        dt.Load(Leitor);
                        Leitor.Close();
                    }
                    Conectionsql.Close();
                }

                 num = Convert.ToInt16(dt.Rows[0]);

                 return num;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }


        #region  Atualizar

        public void Atualiza(Peca peca)
        {
            try
            {
                comandosql = "UPDATE Pecas SET NomePeca = @NomePeca WHERE IDPeca = @IDPeca";
                using (Conectionsql = new SqlConnection(conexao))
                {
                    Conectionsql.Open();
                    using (ComandoTSQL = new SqlCommand(comandosql, Conectionsql))
                    {
                        ComandoTSQL.Parameters.AddWithValue("@IDPeca", peca.IDPeca);
                        ComandoTSQL.Parameters.AddWithValue("@NomePeca", peca.NomePeca);

                        ComandoTSQL.ExecuteNonQuery();
                    }
                    Conectionsql.Close();
                }
            }
            catch (SqlException erro)
            {
                throw erro;
            }
            finally
            {
                Conectionsql.Close();
            }
        }

        public void AtualizaCategoria(Categoria categoria)
        {
            try
            {
                comandosql = "UPDATE Categorias SET NomeCategoria = @NomeCategoria WHERE IDCategoria= @IDCategoria";
                using (Conectionsql = new SqlConnection(conexao))
                {
                    Conectionsql.Open();
                    using (ComandoTSQL = new SqlCommand(comandosql, Conectionsql))
                    {
                        ComandoTSQL.Parameters.AddWithValue("@IDCategoria", categoria.IDCategoria);
                        ComandoTSQL.Parameters.AddWithValue("@NomeCategoria", categoria.NomeCategoria);

                        ComandoTSQL.ExecuteNonQuery();
                    }
                    Conectionsql.Close();
                }
            }
            catch (SqlException erro)
            {
                throw erro;
            }
            finally
            {
                Conectionsql.Close();
            }
        }

        public void AtualizaVeiculo(Veiculo veiculo)
        {
            try
            {
                comandosql = "UPDATE Veiculos SET NomeVeiculo = @NomeVeiculo, Fabricante = @Fabricante, AnoInicial = @AnoInicial, AnoFinal = @AnoFinal WHERE IDVeiculo = @IDVeiculo";
                using (Conectionsql = new SqlConnection(conexao))
                {
                    Conectionsql.Open();
                    using (ComandoTSQL = new SqlCommand(comandosql, Conectionsql))
                    {
                        ComandoTSQL.Parameters.AddWithValue("@IDVeiculo", veiculo.IDVeiculo);
                        ComandoTSQL.Parameters.AddWithValue("@NomeVeiculo", veiculo.NomeVeiculo);
                        ComandoTSQL.Parameters.AddWithValue("@Fabricante", veiculo.Fabricante);
                        ComandoTSQL.Parameters.AddWithValue("@AnoInicial", veiculo.AnoInicial);
                        ComandoTSQL.Parameters.AddWithValue("@AnoFinal", veiculo.AnoFinal);

                        ComandoTSQL.ExecuteNonQuery();
                    }
                    Conectionsql.Close();
                }
            }
            catch (SqlException erro)
            {
                throw erro;
            }
            finally
            {
                Conectionsql.Close();
            }
        }

        public void AtualizarCliente(Cliente cliente)
        {
            try
            {
                comandosql = "UPDATE Clientes SET NomeCliente = @NomeCliente, CNPj = @CNPJ,CPF = @CPF, EnderecoClilente = @EnderecoCliente,Bairro = @Bairro,CEP = @CEP, TelefoneCliente = @TelefoneCliente, CelularCliente = @CelularCliente,Cidade = @Cidade,UF = @UF WHERE IDCliente = @IDCliente";

                using (Conectionsql = new SqlConnection(conexao))
                {
                    Conectionsql.Open();
                    using (ComandoTSQL = new SqlCommand(comandosql, Conectionsql))
                    {
                        ComandoTSQL.Parameters.AddWithValue("@IDCliente", cliente.ID_Cliente);
                        ComandoTSQL.Parameters.AddWithValue("@NomeCliente", cliente.NomeCliente);

                        if (cliente.CNPJ != null)
                            ComandoTSQL.Parameters.AddWithValue("@CNPJ", Convert.ToDouble(cliente.CNPJ));
                        else
                            ComandoTSQL.Parameters.AddWithValue("@CNPJ", 0);

                        if (cliente.CPF != null)
                            ComandoTSQL.Parameters.AddWithValue("@CPF", Convert.ToDouble(cliente.CPF));
                        else
                            ComandoTSQL.Parameters.AddWithValue("@CPF", 0);


                        ComandoTSQL.Parameters.AddWithValue("@EnderecoCliente", cliente.Logradouro);
                        ComandoTSQL.Parameters.AddWithValue("@Bairro", cliente.Bairro);
                        ComandoTSQL.Parameters.AddWithValue("@TelefoneCliente", cliente.Telefone_Fixo);
                        ComandoTSQL.Parameters.AddWithValue("@CelularCliente", cliente.Telefone_Celular);
                        ComandoTSQL.Parameters.AddWithValue("@Cidade", cliente.Cidade);
                        ComandoTSQL.Parameters.AddWithValue("@CEP", cliente.CEP);
                        ComandoTSQL.Parameters.AddWithValue("@UF", cliente.UF);

                        ComandoTSQL.ExecuteNonQuery();
                    }
                    Conectionsql.Close();
                }
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void AtualizaFornecedor(Fornecedor fornecedor)
        {
            try
            {
                comandosql = "UPDATE Fornecedores SET NomeFornecedor = @NomeFornecedor, CNPJFornecedor = @CNPJFornecedor, EnderecoFornecedor = @EnderecoFornecedor, CEPFornecedor = @CEPFornecedor WHERE IDFornecedor = @IDFornecedor";
                using (Conectionsql = new SqlConnection(conexao))
                {
                    Conectionsql.Open();
                    using (ComandoTSQL = new SqlCommand(comandosql, Conectionsql))
                    {
                        ComandoTSQL.Parameters.AddWithValue("@IDFornecedor", fornecedor.IDFornecedor);
                        ComandoTSQL.Parameters.AddWithValue("@NomeFornecedor", fornecedor.RazaoSocial);
                        ComandoTSQL.Parameters.AddWithValue("@CNPJFornecedor ", fornecedor.CNPJ);
                        ComandoTSQL.Parameters.AddWithValue("@EnderecoFornecedor", fornecedor.Endereco);
                        ComandoTSQL.Parameters.AddWithValue("@CEPFornecedor", fornecedor.CEP);

                        ComandoTSQL.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                Conectionsql.Close();
            }
        }

        public void AtualizaVendedor(Vendedor vendedor)
        {
            try
            {
                comandosql = "UPDATE Vendedores SET NomeVendedor = @NomeVendedor, DataAdm = @DataAdm, Endereco=@Endereco, TelFixo = @TelFixo, TelCel=@TelCel, EstadoCivil = @EstadoCivil WHERE CPF = @CPF";
                using (Conectionsql = new SqlConnection(conexao))
                {
                    Conectionsql.Open();
                    using (ComandoTSQL = new SqlCommand(comandosql, Conectionsql))
                    {
                        ComandoTSQL.Parameters.AddWithValue("@CPF", vendedor.CPF);
                        ComandoTSQL.Parameters.AddWithValue("@DataAdm", vendedor.DataAdmissao);
                        ComandoTSQL.Parameters.AddWithValue("@Endereco", vendedor.Endereco);
                        ComandoTSQL.Parameters.AddWithValue("@Nomevendedor", vendedor.NomeVendedor);
                        ComandoTSQL.Parameters.AddWithValue("@TelCel", vendedor.TelefoneCelular);
                        ComandoTSQL.Parameters.AddWithValue("@TelFixo", vendedor.TelefoneFixo);
                        ComandoTSQL.Parameters.AddWithValue("@EstadoCivil", vendedor.EstadoCivil);

                        ComandoTSQL.ExecuteNonQuery();
                    }
                    Conectionsql.Close();
                }
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        # endregion

        public DataTable CarregaTabela(string tabela)
        {
            try
            {
                comandosql = "SELECT * FROM " + tabela;

                using (Conectionsql = new SqlConnection(conexao))
                {
                    Conectionsql.Open();
                    DataTable dt = new DataTable();

                    using (ComandoTSQL = new SqlCommand(comandosql, Conectionsql))
                    {
                        SqlDataReader Leitor = ComandoTSQL.ExecuteReader();
                        dt.Load(Leitor);
                        Leitor.Close();
                    }
                    Conectionsql.Close();
                    return dt;
                }
            }
            catch (SqlException)
            {
                throw;
            }
            finally
            {
                Conectionsql.Close();
            }
        }

        public void DeletaVeiculo(Veiculo veiculo)
        {
            try
            {
                comandosql = "DELETE FROM Veiculos WHERE IDVeiculo = @IDVeiculo";
                using (Conectionsql = new SqlConnection(conexao))
                {
                    Conectionsql.Open();
                    using (ComandoTSQL = new SqlCommand(comandosql, Conectionsql))
                    {
                        ComandoTSQL.Parameters.AddWithValue("@IDVeiculo", veiculo.IDVeiculo);
                        ComandoTSQL.ExecuteNonQuery();
                    }
                    Conectionsql.Close();
                }
            }
            catch (SqlException erro)
            {
                throw erro;
            }
            finally
            {
                Conectionsql.Close();
            }
        }

        public void DeleteCategoria(Categoria categoria)
        {
            try
            {
                comandosql = "DELETE FROM Categorias WHERE NomeCategoria = @NomeCategoria";
                using (Conectionsql = new SqlConnection(conexao))
                {
                    Conectionsql.Open();
                    using (ComandoTSQL = new SqlCommand(comandosql, Conectionsql))
                    {
                        ComandoTSQL.Parameters.AddWithValue("@NomeCategoria", categoria.NomeCategoria);
                        ComandoTSQL.ExecuteNonQuery();
                    }
                    Conectionsql.Close();
                }
            }
            catch (SqlException erro)
            {
                throw erro;
            }
            finally
            {
                Conectionsql.Close();
            }
        }

        public void DeletePeca(Peca peca)
        {
            try
            {
                comandosql = "DELETE FROM Pecas WHERE IDPeca = @IDPeca";
                using (Conectionsql = new SqlConnection(conexao))
                {
                    Conectionsql.Open();
                    using (ComandoTSQL = new SqlCommand(comandosql, Conectionsql))
                    {
                        ComandoTSQL.Parameters.AddWithValue("@IDPeca", peca.IDPeca);
                        ComandoTSQL.ExecuteNonQuery();
                    }
                    Conectionsql.Close();
                }
            }
            catch (SqlException erro)
            {
                throw erro;
            }
            finally
            {
                Conectionsql.Close();
            }
        }

        public void DeletaFornecedor(Fornecedor fornecedor)
        {
            try
            {
                comandosql = "DELETE fROM fornecedores WHERE  IDFornecedor = @IDFornecedor";
                using (Conectionsql = new SqlConnection(conexao))
                {
                    Conectionsql.Open();
                    using (ComandoTSQL = new SqlCommand(comandosql, Conectionsql))
                    {
                        ComandoTSQL.Parameters.AddWithValue("@IDFornecedor", fornecedor.IDFornecedor);
                        ComandoTSQL.ExecuteNonQuery();
                    }
                    Conectionsql.Close();
                }
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void DeletaCliente(Cliente cliente)
        {
            try
            {
                comandosql = "DELETE FROM Clientes WHERE  IDCliente = @IDCliente";
                using (Conectionsql = new SqlConnection(conexao))
                {
                    Conectionsql.Open();
                    using (ComandoTSQL = new SqlCommand(comandosql, Conectionsql))
                    {
                        ComandoTSQL.Parameters.AddWithValue("@NomeCliente", cliente.ID_Cliente);
                        ComandoTSQL.ExecuteNonQuery();
                    }
                    Conectionsql.Close();
                }
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }



        public void DeletaCliente(Object obj)
        {
            try
            {
                comandosql = "DELETE FROM ";   //Clientes WHERE  IDCliente = @IDCliente";

                using (Conectionsql = new SqlConnection(conexao))
                {
                    Conectionsql.Open();

                    if (obj.GetType() == typeof(Cliente))
                        comandosql += "Clientes";
                    else if (obj.GetType() == typeof(Categoria))
                        comandosql += "Categorias";
                    else if (obj.GetType() == typeof(Fornecedor))
                        comandosql += "Fornecedores";
                    else if (obj.GetType() == typeof(ItensVenda))
                        comandosql += "Itensvenda";
                    else if (obj.GetType() == typeof(Peca))
                        comandosql += "Pecas";
                    else if (obj.GetType() == typeof(Veiculo))
                        comandosql += "Veiculos";
                    else if (obj.GetType() == typeof(Venda))
                        comandosql += "Venda WHERE ";
                    else if (obj.GetType() == typeof(Vendedor))
                        comandosql += "Vendedores WHERE IDVendedor = @ID";



                    using (ComandoTSQL = new SqlCommand(comandosql, Conectionsql))
                    {
                        if (obj.GetType() == typeof(Cliente))
                            ComandoTSQL.Parameters.AddWithValue("@ID", ((Cliente)obj).ID_Cliente);
                        else if (obj.GetType() == typeof(Categoria))
                            ComandoTSQL.Parameters.AddWithValue("@ID", ((Categoria)obj).IDCategoria);
                        else if (obj.GetType() == typeof(Fornecedor))
                            ComandoTSQL.Parameters.AddWithValue("@ID", ((Fornecedor)obj).IDFornecedor);
                        else if (obj.GetType() == typeof(ItensVenda))
                            ComandoTSQL.Parameters.AddWithValue("@ID", ((ItensVenda)obj)._IDItensVemda);
                        else if (obj.GetType() == typeof(Peca))
                            ComandoTSQL.Parameters.AddWithValue("@ID", ((Peca)obj).IDPeca);
                        else if (obj.GetType() == typeof(Veiculo))
                            ComandoTSQL.Parameters.AddWithValue("@ID", ((Veiculo)obj).IDVeiculo);
                        else if (obj.GetType() == typeof(Venda))
                            ComandoTSQL.Parameters.AddWithValue("@ID", ((Venda)obj).IDVenda);
                        else if (obj.GetType() == typeof(Vendedor))
                            ComandoTSQL.Parameters.AddWithValue("@ID", ((Vendedor)obj).IDVendedor);

                        ComandoTSQL.ExecuteNonQuery();
                    }
                    Conectionsql.Close();
                }
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void DeletaVendedor(Vendedor vendedor)
        {
            try
            {
                comandosql = "DELETE FROM Vendedores WHERE  CPF = @CPF";
                using (Conectionsql = new SqlConnection(conexao))
                {
                    Conectionsql.Open();
                    using (ComandoTSQL = new SqlCommand(comandosql, Conectionsql))
                    {
                        ComandoTSQL.Parameters.AddWithValue("@CPF", vendedor.CPF);
                        ComandoTSQL.ExecuteNonQuery();
                    }
                    Conectionsql.Close();
                }
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public DataTable Filtrapeca(string param)
        {
            try
            {
                comandosql = "SELECT * FROM Pecas WHERE AnoVeiculo like '@filtro'";

                using (Conectionsql = new SqlConnection(conexao))
                {
                    Conectionsql.Open();
                    DataTable dt = new DataTable();

                    using (ComandoTSQL = new SqlCommand(comandosql, Conectionsql))
                    {
                        ComandoTSQL.Parameters.AddWithValue("@filtro", param);
                        SqlDataReader Leitor = ComandoTSQL.ExecuteReader();
                        dt.Load(Leitor);
                        Leitor.Close();
                    }
                    Conectionsql.Close();
                    return dt;
                }
            }
            catch (SqlException)
            {
                throw;
            }
            finally
            {
                Conectionsql.Close();
            }
        }

        public DataTable FiltraVendedor(string param)
        {
            try
            {
                comandosql = "SELECT * FROM Vendedores WHERE NomeVendedor like '@filtro'";

                using (Conectionsql = new SqlConnection(conexao))
                {
                    Conectionsql.Open();
                    DataTable dt = new DataTable();

                    using (ComandoTSQL = new SqlCommand(comandosql, Conectionsql))
                    {
                        ComandoTSQL.Parameters.AddWithValue("@filtro", param);
                        SqlDataReader Leitor = ComandoTSQL.ExecuteReader();
                        dt.Load(Leitor);
                        Leitor.Close();
                    }
                    Conectionsql.Close();
                    return dt;
                }
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public DataTable Filtrafornecedor(string param)
        {
            try
            {
                comandosql = "SELECT * FROM Fornecedores WHERE NomeFornecedor LIKE '@filtro'";

                using (Conectionsql = new SqlConnection(conexao))
                {
                    Conectionsql.Open();
                    DataTable dt = new DataTable();

                    using (ComandoTSQL = new SqlCommand(comandosql, Conectionsql))
                    {
                        ComandoTSQL.Parameters.AddWithValue("@filtro", param);
                        SqlDataReader Leitor = ComandoTSQL.ExecuteReader();
                        dt.Load(Leitor);
                        Leitor.Close();
                    }
                    return dt;
                }
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                Conectionsql.Close();
            }
        }

        public DataTable FiltraCategoria(string param)
        {
            try
            {
                Categoria categoria = new Categoria();
                comandosql = "SELECT * FROM Categorias WHERE NomeCategoria = '" + param + "'";

                using (Conectionsql = new SqlConnection(conexao))
                {
                    Conectionsql.Open();
                    DataTable dt = new DataTable();

                    using (ComandoTSQL = new SqlCommand(comandosql, Conectionsql))
                    {
                        SqlDataReader Leitor = ComandoTSQL.ExecuteReader();
                        dt.Load(Leitor);
                        Leitor.Close();
                    }
                    Conectionsql.Close();
                    return dt;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Gravar(Peca peca)
        {
            try
            {
                comandosql = "INSERT INTO Pecas VALUES (@NomePeca, @IDFornecedor, @IDVeiculo, @AnoVeiculo,@Quant,@Preco, @IDCategoria)";

                using (Conectionsql = new SqlConnection(conexao))
                {
                    Conectionsql.Open();
                    using (ComandoTSQL = new SqlCommand(comandosql, Conectionsql))
                    {
                        ComandoTSQL.Parameters.AddWithValue("@NomePeca", peca.NomePeca);
                        ComandoTSQL.Parameters.AddWithValue("@IDFornecedor", peca.IDFornecedor);
                        ComandoTSQL.Parameters.AddWithValue("@IDVeiculo", peca.IDVeiculo);
                        ComandoTSQL.Parameters.AddWithValue("@Quant", peca.QuatidadeEstoque);
                        ComandoTSQL.Parameters.AddWithValue("@Preco", peca.PrecoUnitario);
                        ComandoTSQL.Parameters.AddWithValue("@IDCategoria", peca.IDCategoria);
                        ComandoTSQL.ExecuteNonQuery();

                    }
                    Conectionsql.Close();
                }
            }
            catch (SqlException erro)
            {
                throw erro;
            }
            finally
            {
                Conectionsql.Close();
            }
        }

        public void GravarCategoria(Categoria categoria)
        {
            try
            {
                comandosql = "INSERT INTO Categorias VALUES (@NomeCategoria, @Descricao)";
                using (Conectionsql = new SqlConnection(conexao))
                {
                    Conectionsql.Open();
                    using (ComandoTSQL = new SqlCommand(comandosql, Conectionsql))
                    {
                        ComandoTSQL.Parameters.AddWithValue("@NomeCategoria", categoria.NomeCategoria);
                        ComandoTSQL.Parameters.AddWithValue("@Descricao", categoria.Descricao);
                        ComandoTSQL.ExecuteNonQuery();
                    }
                    Conectionsql.Close();
                }
            }
            catch (SqlException erro)
            {
                throw erro;
            }
            finally
            {
                Conectionsql.Close();
            }
        }

        public void GravaVeiculo(Veiculo veiculo)
        {
            try
            {
                comandosql = "INSERT INTO Veiculos VALUES (@IDVeiculo, @NomeVeiculo, @Fabricante, @AnoInicial, @AnoFinal)";
                using (Conectionsql = new SqlConnection(conexao))
                {
                    Conectionsql.Open();
                    using (ComandoTSQL = new SqlCommand(comandosql, Conectionsql))
                    {
                        ComandoTSQL.Parameters.AddWithValue("@IDVeiculo", veiculo.IDVeiculo);
                        ComandoTSQL.Parameters.AddWithValue("@NomeVeiculo", veiculo.NomeVeiculo);
                        ComandoTSQL.Parameters.AddWithValue("@Fabricante", veiculo.Fabricante);
                        ComandoTSQL.Parameters.AddWithValue("@AnoVeiculo", veiculo.AnoInicial);
                        ComandoTSQL.Parameters.AddWithValue("@AnoVeiculo", veiculo.AnoFinal);

                        ComandoTSQL.ExecuteNonQuery();
                    }
                    Conectionsql.Close();
                }
            }
            catch (SqlException erro)
            {
                throw erro;
            }
        }

        public void GravarCliente(Cliente cliente)
        {
            try
            {
                comandosql = "INSERT INTO Clientes VALUES (@NomeCliente,@CNPJ,@CPF,@EnderecoCliente,@Bairro,@CEP,@TelefoneCliente, @CelularCliente,@Cidade,@UF)";

                using (Conectionsql = new SqlConnection(conexao))
                {
                    Conectionsql.Open();
                    using (ComandoTSQL = new SqlCommand(comandosql, Conectionsql))
                    {
                        ComandoTSQL.Parameters.AddWithValue("@NomeCliente", cliente.NomeCliente);

                        if (cliente.CNPJ != null)
                            ComandoTSQL.Parameters.AddWithValue("@CNPJ", Convert.ToDouble(cliente.CNPJ));
                        else
                            ComandoTSQL.Parameters.AddWithValue("@CNPJ", 0);

                        if (cliente.CPF != null)
                            ComandoTSQL.Parameters.AddWithValue("@CPF", Convert.ToDouble(cliente.CPF));
                        else
                            ComandoTSQL.Parameters.AddWithValue("@CPF", 0);


                        ComandoTSQL.Parameters.AddWithValue("@EnderecoCliente", cliente.Logradouro);
                        ComandoTSQL.Parameters.AddWithValue("@Bairro", cliente.Bairro);
                        ComandoTSQL.Parameters.AddWithValue("@TelefoneCliente", cliente.Telefone_Fixo);
                        ComandoTSQL.Parameters.AddWithValue("@CelularCliente", cliente.Telefone_Celular);
                        ComandoTSQL.Parameters.AddWithValue("@Cidade", cliente.Cidade);
                        ComandoTSQL.Parameters.AddWithValue("@CEP", cliente.CEP);
                        ComandoTSQL.Parameters.AddWithValue("@UF", cliente.UF);

                        ComandoTSQL.ExecuteNonQuery();
                    }
                    Conectionsql.Close();
                }
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void GravarFornecedor(Fornecedor fornecedor)
        {
            try
            {
                comandosql = "INSERT INTO Fornecedores VALUES(@NomeFornecedor, @CNPJFornecedor, @EnderecoFornecedor, @CEPFornecedor)";
                using (Conectionsql = new SqlConnection(conexao))
                {
                    Conectionsql.Open();
                    using (ComandoTSQL = new SqlCommand(comandosql, Conectionsql))
                    {
                        ComandoTSQL.Parameters.AddWithValue("@NomeFornecedor", fornecedor.RazaoSocial);
                        ComandoTSQL.Parameters.AddWithValue("@CNPJFornecedor", fornecedor.CNPJ);
                        ComandoTSQL.Parameters.AddWithValue("@EnderecoFornecedor", fornecedor.Endereco);
                        ComandoTSQL.Parameters.AddWithValue("@CEPFornecedor", fornecedor.CEP);

                        ComandoTSQL.ExecuteNonQuery();
                    }
                    //Conectionsql.Close();
                }
            }
            catch (SqlException erro)
            {
                throw erro;
            }
            finally
            {
                Conectionsql.Close();
            }
        }

        public void GravarVendedor(Vendedor vendedor)
        {
            try
            {
                comandosql = "INSERT INTO Vendedores VALUES(@NomeVendedor, @DataAdm, @Endereco, @TelFixo, @TelCel, @CPF, @EstadoCivil)";
                using (Conectionsql = new SqlConnection(conexao))
                {
                    Conectionsql.Open();
                    using (ComandoTSQL = new SqlCommand(comandosql, Conectionsql))
                    {
                        ComandoTSQL.Parameters.AddWithValue("@CPF", vendedor.CPF);
                        ComandoTSQL.Parameters.AddWithValue("@DataAdm", vendedor.DataAdmissao);
                        ComandoTSQL.Parameters.AddWithValue("@Endereco", vendedor.Endereco);
                        ComandoTSQL.Parameters.AddWithValue("@Nomevendedor", vendedor.NomeVendedor);
                        ComandoTSQL.Parameters.AddWithValue("@TelCel", vendedor.TelefoneCelular);
                        ComandoTSQL.Parameters.AddWithValue("@TelFixo", vendedor.TelefoneFixo);
                        ComandoTSQL.Parameters.AddWithValue("@EstadoCivil", vendedor.EstadoCivil);


                        ComandoTSQL.ExecuteNonQuery();
                    }
                    Conectionsql.Close();
                }
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public DataTable PesquisaVeiculo(string pesquisa)
        {
            try
            {
                DataTable dt = new DataTable();

                comandosql = "SELECT * FROM Veiculos WHERE NomeVeiculo LIKE '%" + pesquisa + "%'";

                using (Conectionsql = new SqlConnection(conexao))
                {
                    Conectionsql.Open();

                    using (ComandoTSQL = new SqlCommand(comandosql, Conectionsql))
                    {
                        SqlDataReader Leitor = ComandoTSQL.ExecuteReader(CommandBehavior.CloseConnection);
                        dt.Load(Leitor);

                        Leitor.Close();
                    }
                    return dt;
                }
            }
            catch (SqlException)
            {
                throw;
            }
            finally
            {
                Conectionsql.Close();
            }
        }

        public DataTable PesquisaPeca(string pesquisa)
        {
            try
            {
                DataTable dt = new DataTable();
                comandosql = "SELECT * FROM Pecas WHERE NomePeca LIKE '%" + pesquisa + "%'";

                using (Conectionsql = new SqlConnection(conexao))
                {
                    Conectionsql.Open();

                    using (ComandoTSQL = new SqlCommand(comandosql, Conectionsql))
                    {
                        SqlDataReader Leitor = ComandoTSQL.ExecuteReader(CommandBehavior.CloseConnection);
                        dt.Load(Leitor);
                        Leitor.Close();
                    }
                    return dt;
                }
            }
            catch (SqlException)
            {
                throw;
            }
            finally
            {
                Conectionsql.Close();
            }
        }

        public DataTable PesquisaVendedor(string pesquisa)
        {
            try
            {
                DataTable dt = new DataTable();
                comandosql = "SELECT * FROM Vendedores WHERE NomeVendedor LIKE '%" + pesquisa + "%'";

                using (Conectionsql = new SqlConnection(conexao))
                {
                    Conectionsql.Open();

                    using (ComandoTSQL = new SqlCommand(comandosql, Conectionsql))
                    {
                        SqlDataReader Leitor = ComandoTSQL.ExecuteReader(CommandBehavior.CloseConnection);
                        dt.Load(Leitor);
                        Leitor.Close();
                    }
                    return dt;
                }
            }
            catch (Exception erro)
            {
                throw erro;
            }

        }

        public DataTable PesquisaCategoria(string pesquisa)
        {
            try
            {
                Categoria categoria = new Categoria();
                comandosql = "SELECT * FROM Categorias WHERE NomeCategoria LIKE '%" + pesquisa + "%'";

                using (Conectionsql = new SqlConnection(conexao))
                {
                    Conectionsql.Open();
                    DataTable dt = new DataTable();

                    using (ComandoTSQL = new SqlCommand(comandosql, Conectionsql))
                    {
                        SqlDataReader Leitor = ComandoTSQL.ExecuteReader();
                        dt.Load(Leitor);
                        Leitor.Close();
                    }
                    Conectionsql.Close();
                    return dt;
                }

            }
            catch (SqlException erro)
            {
                throw erro;
            }
            finally
            {
                Conectionsql.Close();
            }
        }

        public DataTable PesquisaFornecedor(string pesquisa)
        {
            try
            {
                DataTable dt = new DataTable();
                comandosql = "SELECT * FROM fornecedores WHERE NomeFornecedor LIKE '%" + pesquisa + "%'";

                using (Conectionsql = new SqlConnection(conexao))
                {
                    Conectionsql.Open();

                    using (ComandoTSQL = new SqlCommand(comandosql, Conectionsql))
                    {
                        SqlDataReader Leitor = ComandoTSQL.ExecuteReader(CommandBehavior.CloseConnection);
                        dt.Load(Leitor);
                        Leitor.Close();
                    }
                    return dt;
                }
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }


    }
}