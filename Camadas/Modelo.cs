using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;
using System.Data;

namespace Camadas
{
    public class Modelo
    {
        private string instrucaoSql;
        private string tipoObjetoParaInserir;
        private string nomeTabela;
        private SqlConnection conexaoSql;
        private SqlCommand comandoSql;
        //private const string NOME_SERVIDOR = "PHLP";
        private const string NOME_SERVIDOR = "DELL";
        //private const string NOME_SERVIDOR = "SESA-10267";
        //private const string NOME_SERVIDOR = "CASA";
        private const string NOME_BANCO_DADOS = "AUTOPECAS";
        private string stringConexao = string.Format("Data Source = {0}; Initial Catalog = {1}; Integrated Security = True;", NOME_SERVIDOR, NOME_BANCO_DADOS);

        /// <summary>
        /// Método para inserir qualquer objeto no banco de dados.
        /// </summary>
        /// <param name="paraInserir">Objeto a ser inserido.</param>
        public void ModeloInserir(object paraInserir)
        {
            try
            {
                conexaoSql = new SqlConnection();
                conexaoSql.ConnectionString = stringConexao;
                conexaoSql.Open();

                comandoSql = new SqlCommand();
                comandoSql.Connection = conexaoSql;

                instrucaoSql = "INSERT INTO ";
                tipoObjetoParaInserir = paraInserir.GetType().Name.ToString();

                switch (tipoObjetoParaInserir)
                {
                    case "Categoria":
                        Categoria categoria = (Categoria)paraInserir;
                        nomeTabela = "CATEGORIAS";
                        instrucaoSql += string.Format(" {0} VALUES (@NOMECATEGORIA,@DESCRICAO)", nomeTabela);
                        comandoSql.Parameters.AddWithValue("@NOMECATEGORIA", categoria.NomeCategoria);
                        comandoSql.Parameters.AddWithValue("@DESCRICAO", categoria.Descricao);
                        break;

                    case "Cliente":
                        Cliente cliente = (Cliente)paraInserir;
                        nomeTabela = "CLIENTES";
                        instrucaoSql += string.Format(" {0} VALUES (@NOMECLIENTE,@CNPJ,@CPF,@ENDERECOCLIENTE,@BAIRRO,@CEP,@TELEFONECLIENTE,@CELULARCLIENTE,@CIDADE,@UF)", nomeTabela);
                        comandoSql.Parameters.AddWithValue("@NOMECLIENTE", cliente.NomeCliente);

                        if (cliente.CNPJ != null)
                        {
                            comandoSql.Parameters.AddWithValue("@CNPJ", cliente.CNPJ);
                        }
                        else
                        {
                            comandoSql.Parameters.AddWithValue("@CNPJ", '-');
                        }

                        if (cliente.CPF!=null)
                        {
                            comandoSql.Parameters.AddWithValue("@CPF", cliente.CPF);
                        }
                        else
                        {
                            comandoSql.Parameters.AddWithValue("@CPF", '-');
                        }

                        //comandoSql.Parameters.AddWithValue("@CNPJ", cliente.CNPJ);
                        //comandoSql.Parameters.AddWithValue("@CPF", cliente.CPF);
                        comandoSql.Parameters.AddWithValue("@ENDERECOCLIENTE", cliente.EnderecoCliente);
                        comandoSql.Parameters.AddWithValue("@BAIRRO", cliente.Bairro);
                        comandoSql.Parameters.AddWithValue("@CEP", cliente.CEP);
                        comandoSql.Parameters.AddWithValue("@TELEFONECLIENTE", cliente.TelefoneCliente);
                        comandoSql.Parameters.AddWithValue("@CELULARCLIENTE", cliente.CelularCliente);
                        comandoSql.Parameters.AddWithValue("@CIDADE", cliente.Cidade);
                        comandoSql.Parameters.AddWithValue("@UF", cliente.UF);
                        break;

                    case "Fornecedor":
                        Fornecedor fornecedor = (Fornecedor)paraInserir;
                        nomeTabela = "FORNECEDORES";
                        instrucaoSql += string.Format(" {0} VALUES (@NOMEFORNECEDOR,@CNPJFORNECEDOR,@ENDERECOFORNECEDOR,@BAIRROFORNECEDOR,@CEPFORNECEDOR,@TELEFONEFIXO,@TELEFONECELULAR,@DATACONTRATO)", nomeTabela);
                        comandoSql.Parameters.AddWithValue("@NOMEFORNECEDOR", fornecedor.NomeFornecedor);
                        comandoSql.Parameters.AddWithValue("@CNPJFORNECEDOR", fornecedor.CNPJFornecedor);
                        comandoSql.Parameters.AddWithValue("@ENDERECOFORNECEDOR", fornecedor.EnderecoFornecedor);
                        comandoSql.Parameters.AddWithValue("@BAIRROFORNECEDOR", fornecedor.BairroFornecedor);
                        comandoSql.Parameters.AddWithValue("@CEPFORNECEDOR", fornecedor.CEPFornecedor);
                        comandoSql.Parameters.AddWithValue("@TELEFONEFIXO", fornecedor.TelefoneFixo);
                        comandoSql.Parameters.AddWithValue("@TELEFONECELULAR", fornecedor.TelefoneCelular);
                        comandoSql.Parameters.AddWithValue("@DATACONTRATO", fornecedor.DataContrato);
                        break;

                    case "ItensVenda":
                        ItensVenda itensVenda = (ItensVenda)paraInserir;
                        nomeTabela = "ITENSVENDA";
                        instrucaoSql += string.Format(" {0} VALUES (@IDPECA,@IDVENDA,@PRECOUNITARIO,@QUANTIDADE,@SUBTOTAL)", nomeTabela);
                        comandoSql.Parameters.AddWithValue("@IDPECA", itensVenda.IDPeca);
                        comandoSql.Parameters.AddWithValue("@IDVENDA", itensVenda.IDVenda);
                        comandoSql.Parameters.AddWithValue("@PRECOUNITARIO", itensVenda.PrecoUnitario);
                        comandoSql.Parameters.AddWithValue("@QUANTIDADE", itensVenda.Quantidade);
                        comandoSql.Parameters.AddWithValue("@SUBTOTAL", itensVenda.Subtotal);
                        break;

                    case "Peca":
                        Peca peca = (Peca)paraInserir;
                        nomeTabela = "PECAS";
                        instrucaoSql += string.Format(" {0} VALUES (@NOMEPECA,@IDFORNECEDOR,@IDVEICULO,@QUANTIDADE,@PRECOPECA,@IDCATEGORIA,@PRECOESTOCADO)", nomeTabela);
                        comandoSql.Parameters.AddWithValue("@NOMEPECA", peca.NomePeca);
                        comandoSql.Parameters.AddWithValue("@IDFORNECEDOR", peca.IDFornecedor);
                        comandoSql.Parameters.AddWithValue("@IDVEICULO", peca.IDVeiculo);
                        comandoSql.Parameters.AddWithValue("@QUANTIDADE", peca.Quantidade);
                        comandoSql.Parameters.AddWithValue("@PRECOPECA", peca.PrecoPeca);
                        comandoSql.Parameters.AddWithValue("@IDCATEGORIA", peca.IDCategoria);
                        comandoSql.Parameters.AddWithValue("@PRECOESTOCADO", peca.PrecoEstocado);
                        break;

                    case "Veiculo":
                        Veiculo veiculo = (Veiculo)paraInserir;
                        nomeTabela = "VEICULOS";
                        instrucaoSql += string.Format(" {0} VALUES (@NOMEVEICULO,@FABRICANTE,@ANOINICIAL,@ANOFINAL)", nomeTabela);
                        comandoSql.Parameters.AddWithValue("@NOMEVEICULO", veiculo.NomeVeiculo);
                        comandoSql.Parameters.AddWithValue("@FABRICANTE", veiculo.Fabricante);
                        comandoSql.Parameters.AddWithValue("@ANOINICIAL", veiculo.AnoInicial);
                        comandoSql.Parameters.AddWithValue("@ANOFINAL", veiculo.AnoFinal);
                        break;

                    case "Venda":
                        Venda venda = (Venda)paraInserir;
                        nomeTabela = "VENDA";
                        instrucaoSql += string.Format(" {0} VALUES (@IDVENDEDOR,@DATAVENDA,@IDCLIENTE,@PRECOTOTAL,@DESCONTO)", nomeTabela);
                        comandoSql.Parameters.AddWithValue("@IDVENDEDOR", venda.IDVendedor);
                        comandoSql.Parameters.AddWithValue("@DATAVENDA", venda.DataVenda);
                        comandoSql.Parameters.AddWithValue("@IDCLIENTE", venda.IDCliente);
                        comandoSql.Parameters.AddWithValue("@PRECOTOTAL", venda.PrecoTotal);
                        comandoSql.Parameters.AddWithValue("@DESCONTO", venda.Desconto);
                        break;

                    case "Vendedor":
                        Vendedor vendedor = (Vendedor)paraInserir;
                        nomeTabela = "VENDEDORES";
                        instrucaoSql += string.Format(" {0} VALUES (@NOMEVENDEDOR,@N_CADASTRO,@DATAADM,@ENDERECO,@TELFIXO,@TELCEL,@CPF,@ESTADOCIVIL)", nomeTabela);
                        comandoSql.Parameters.AddWithValue("@NOMEVENDEDOR", vendedor.NomeVendedor);
                        comandoSql.Parameters.AddWithValue("@N_CADASTRO", vendedor.NCadastro);
                        comandoSql.Parameters.AddWithValue("@DATAADM", vendedor.DataAdm);
                        comandoSql.Parameters.AddWithValue("@ENDERECO", vendedor.Endereco);
                        comandoSql.Parameters.AddWithValue("@TELFIXO", vendedor.TelFixo);
                        comandoSql.Parameters.AddWithValue("@TELCEL", vendedor.TelCel);
                        comandoSql.Parameters.AddWithValue("@CPF", vendedor.CPF);
                        comandoSql.Parameters.AddWithValue("@ESTADOCIVIL", vendedor.EstadoCivil);
                        break;
                }

                comandoSql.CommandText = instrucaoSql;
                comandoSql.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                if (conexaoSql.State == ConnectionState.Open)
                {
                    conexaoSql.Close();
                }
            }
        }

        /// <summary>
        /// Método para atualizar qualquer objeto no banco de dados.
        /// </summary>
        /// <param name="paraAtualizar">Objeto a ser atualizado.</param>
        public void ModeloAtualizar(object paraAtualizar)
        {
            try
            {
                conexaoSql = new SqlConnection();
                conexaoSql.ConnectionString = stringConexao;
                conexaoSql.Open();

                comandoSql = new SqlCommand();
                comandoSql.Connection = conexaoSql;

                instrucaoSql = "UPDATE ";
                tipoObjetoParaInserir = paraAtualizar.GetType().Name.ToString();

                switch (tipoObjetoParaInserir)
                {
                    case "Categoria":
                        Categoria categoria = (Categoria)paraAtualizar;
                        nomeTabela = "CATEGORIAS";
                        instrucaoSql += string.Format(" {0} SET NOMECATEGORIA = @NOMECATEGORIA, DESCRICAO = @DESCRICAO WHERE IDCATEGORIA = @IDCATEGORIA", nomeTabela);
                        comandoSql.Parameters.AddWithValue("@NOMECATEGORIA", categoria.NomeCategoria);
                        comandoSql.Parameters.AddWithValue("@DESCRICAO", categoria.Descricao);
                        comandoSql.Parameters.AddWithValue("@IDCATEGORIA", categoria.IDCategoria);
                        break;

                    case "Cliente":
                        Cliente cliente = (Cliente)paraAtualizar;
                        nomeTabela = "CLIENTES";
                        instrucaoSql += string.Format(" {0} SET NOMECLIENTE = @NOMECLIENTE, CNPJ = @CNPJ, CPF = @CPF, ENDERECOCLIENTE = @ENDERECOCLIENTE, BAIRRO = @BAIRRO, CEP = @CEP, TELEFONECLIENTE = @TELEFONECLIENTE, CELULARCLIENTE = @CELULARCLIENTE, CIDADE = @CIDADE, UF = @UF WHERE IDCLIENTE = @IDCLIENTE", nomeTabela);
                        comandoSql.Parameters.AddWithValue("@NOMECLIENTE", cliente.NomeCliente);



                        if (cliente.CNPJ!=null)
                        {
                            comandoSql.Parameters.AddWithValue("@CNPJ", cliente.CNPJ);
                        }
                        else
                        {
                            comandoSql.Parameters.AddWithValue("@CNPJ", '-');
                        }

                        if (cliente.CPF!=null)
                        {
                            comandoSql.Parameters.AddWithValue("@CPF", cliente.CPF);
                        }
                        else
                        {
                            comandoSql.Parameters.AddWithValue("@CPF", '-');
                        }
                        //comandoSql.Parameters.AddWithValue("@CNPJ", cliente.CNPJ);
                        //comandoSql.Parameters.AddWithValue("@CPF", cliente.CPF);




                        comandoSql.Parameters.AddWithValue("@ENDERECOCLIENTE", cliente.EnderecoCliente);
                        comandoSql.Parameters.AddWithValue("@BAIRRO", cliente.Bairro);
                        comandoSql.Parameters.AddWithValue("@CEP", cliente.CEP);
                        comandoSql.Parameters.AddWithValue("@TELEFONECLIENTE", cliente.TelefoneCliente);
                        comandoSql.Parameters.AddWithValue("@CELULARCLIENTE", cliente.CelularCliente);
                        comandoSql.Parameters.AddWithValue("@CIDADE", cliente.Cidade);
                        comandoSql.Parameters.AddWithValue("@UF", cliente.UF);
                        comandoSql.Parameters.AddWithValue("@IDCLIENTE", cliente.IDCliente);
                        break;

                    case "Fornecedor":
                        Fornecedor fornecedor = (Fornecedor)paraAtualizar;
                        nomeTabela = "FORNECEDORES";
                        instrucaoSql += string.Format(" {0} SET NOMEFORNECEDOR = @NOMEFORNECEDOR, CNPJFORNECEDOR = @CNPJFORNECEDOR, ENDERECOFORNECEDOR = @ENDERECOFORNECEDOR, BAIRROFORNECEDOR = @BAIRROFORNECEDOR, CEPFORNECEDOR = @CEPFORNECEDOR, TELEFONEFIXO = @TELEFONEFIXO, TELEFONECELULAR = @TELEFONECELULAR, DATACONTRATO = @DATACONTRATO WHERE IDFORNECEDOR = @IDFORNECEDOR", nomeTabela);
                        comandoSql.Parameters.AddWithValue("@NOMEFORNECEDOR", fornecedor.NomeFornecedor);
                        comandoSql.Parameters.AddWithValue("@CNPJFORNECEDOR", fornecedor.CNPJFornecedor);
                        comandoSql.Parameters.AddWithValue("@ENDERECOFORNECEDOR", fornecedor.EnderecoFornecedor);
                        comandoSql.Parameters.AddWithValue("@BAIRROFORNECEDOR", fornecedor.BairroFornecedor);
                        comandoSql.Parameters.AddWithValue("@CEPFORNECEDOR", fornecedor.CEPFornecedor);
                        comandoSql.Parameters.AddWithValue("@TELEFONEFIXO", fornecedor.TelefoneFixo);
                        comandoSql.Parameters.AddWithValue("@TELEFONECELULAR", fornecedor.TelefoneCelular);
                        comandoSql.Parameters.AddWithValue("@DATACONTRATO", fornecedor.DataContrato);
                        comandoSql.Parameters.AddWithValue("@IDFORNECEDOR", fornecedor.IDFornecedor);
                        break;

                    case "ItensVenda":
                        ItensVenda itensVenda = (ItensVenda)paraAtualizar;
                        nomeTabela = "ITENSVENDA";
                        instrucaoSql += string.Format(" {0} SET IDPECA = @IDPECA, IDVENDA = @IDVENDA, PRECOUNITARIO = @PRECOUNITARIO, QUANTIDADE = @QUANTIDADE, SUBTOTAL = @SUBTOTAL WHERE IDITENSVENDA = @IDITENSVENDA", nomeTabela);
                        comandoSql.Parameters.AddWithValue("@IDPECA", itensVenda.IDPeca);
                        comandoSql.Parameters.AddWithValue("@IDVENDA", itensVenda.IDVenda);
                        comandoSql.Parameters.AddWithValue("@PRECOUNITARIO", itensVenda.PrecoUnitario);
                        comandoSql.Parameters.AddWithValue("@QUANTIDADE", itensVenda.Quantidade);
                        comandoSql.Parameters.AddWithValue("@SUBTOTAL", itensVenda.Subtotal);
                        comandoSql.Parameters.AddWithValue("@IDITENSVENDA", itensVenda.IDItensVenda);
                        break;

                    case "Peca":
                        Peca peca = (Peca)paraAtualizar;
                        nomeTabela = "PECAS";
                        instrucaoSql += string.Format(" {0} SET NOMEPECA = @NOMEPECA, IDFORNECEDOR = @IDFORNECEDOR, IDVEICULO = @IDVEICULO, QUANTIDADE = @QUANTIDADE, PRECOPECA = @PRECOPECA, IDCATEGORIA = @IDCATEGORIA WHERE IDPECA = @IDPECA", nomeTabela);
                        comandoSql.Parameters.AddWithValue("@NOMEPECA", peca.NomePeca);
                        comandoSql.Parameters.AddWithValue("@IDFORNECEDOR", peca.IDFornecedor);
                        comandoSql.Parameters.AddWithValue("@IDVEICULO", peca.IDVeiculo);
                        comandoSql.Parameters.AddWithValue("@QUANTIDADE", peca.Quantidade);
                        comandoSql.Parameters.AddWithValue("@PRECOPECA", peca.PrecoPeca);
                        comandoSql.Parameters.AddWithValue("@IDCATEGORIA", peca.IDCategoria);
                        //comandoSql.Parameters.AddWithValue("@PRECOESTOCADO", peca.PrecoEstocado);
                        comandoSql.Parameters.AddWithValue("@IDPECA", peca.IDPeca);
                        break;

                    case "Veiculo":
                        Veiculo veiculo = (Veiculo)paraAtualizar;
                        nomeTabela = "VEICULOS";
                        instrucaoSql += string.Format(" {0} SET NOMEVEICULO = @NOMEVEICULO, FABRICANTE = @FABRICANTE, ANOINICIAL = @ANOINICIAL, ANOFINAL = @ANOFINAL WHERE IDVEICULO = @IDVEICULO", nomeTabela);
                        comandoSql.Parameters.AddWithValue("@NOMEVEICULO", veiculo.NomeVeiculo);
                        comandoSql.Parameters.AddWithValue("@FABRICANTE", veiculo.Fabricante);
                        comandoSql.Parameters.AddWithValue("@ANOINICIAL", veiculo.AnoInicial);
                        comandoSql.Parameters.AddWithValue("@ANOFINAL", veiculo.AnoFinal);
                        comandoSql.Parameters.AddWithValue("@IDVEICULO", veiculo.IDVeiculo);
                        break;

                    case "Venda":
                        Venda venda = (Venda)paraAtualizar;
                        nomeTabela = "VENDA";
                        instrucaoSql += string.Format(" {0} SET IDVENDEDOR = @IDVENDEDOR, DATAVENDA = @DATAVENDA, IDCLIENTE = @IDCLIENTE, PRECOTOTAL = @PRECOTOTAL, DESCONTO = @DESCONTO WHERE IDVENDA = @IDVENDA", nomeTabela);
                        comandoSql.Parameters.AddWithValue("@IDVENDEDOR", venda.IDVendedor);
                        comandoSql.Parameters.AddWithValue("@DATAVENDA", venda.DataVenda);
                        comandoSql.Parameters.AddWithValue("@IDCLIENTE", venda.IDCliente);
                        comandoSql.Parameters.AddWithValue("@PRECOTOTAL", venda.PrecoTotal);
                        comandoSql.Parameters.AddWithValue("@DESCONTO", venda.Desconto);
                        comandoSql.Parameters.AddWithValue("@IDVENDA", venda.IDVenda);
                        break;

                    case "Vendedor":
                        Vendedor vendedor = (Vendedor)paraAtualizar;
                        nomeTabela = "VENDEDORES";
                        instrucaoSql += string.Format(" {0} SET NOMEVENDEDOR = @NOMEVENDEDOR, N_CADASTRO = @N_CADASTRO, DATAADM = @DATAADM, ENDERECO = @ENDERECO, TELFIXO = @TELFIXO, TELCEL = @TELCEL, CPF = @CPF, ESTADOCIVIL = @ESTADOCIVIL WHERE IDVENDEDOR = @IDVENDEDOR", nomeTabela);
                        comandoSql.Parameters.AddWithValue("@NOMEVENDEDOR", vendedor.NomeVendedor);
                        comandoSql.Parameters.AddWithValue("@N_CADASTRO", vendedor.NCadastro);
                        comandoSql.Parameters.AddWithValue("@DATAADM", vendedor.DataAdm);
                        comandoSql.Parameters.AddWithValue("@ENDERECO", vendedor.Endereco);
                        comandoSql.Parameters.AddWithValue("@TELFIXO", vendedor.TelFixo);
                        comandoSql.Parameters.AddWithValue("@TELCEL", vendedor.TelCel);
                        comandoSql.Parameters.AddWithValue("@CPF", vendedor.CPF);
                        comandoSql.Parameters.AddWithValue("@ESTADOCIVIL", vendedor.EstadoCivil);
                        comandoSql.Parameters.AddWithValue("@IDVENDEDOR", vendedor.IDVendedor);
                        break;
                }

                comandoSql.CommandText = instrucaoSql;
                comandoSql.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                if (conexaoSql.State == ConnectionState.Open)
                {
                    conexaoSql.Close();
                }
            }
        }

        /// <summary>
        /// Método para deletar qualquer objeto no banco de dados.
        /// </summary>
        /// <param name="paraDeletar">Objeto a ser deletado.</param>
        public void ModeloDeletar(object paraDeletar)
        {
            try
            {
                conexaoSql = new SqlConnection();
                conexaoSql.ConnectionString = stringConexao;
                conexaoSql.Open();

                comandoSql = new SqlCommand();
                comandoSql.Connection = conexaoSql;

                instrucaoSql = "DELETE FROM ";
                tipoObjetoParaInserir = paraDeletar.GetType().Name.ToString();

                switch (tipoObjetoParaInserir)
                {
                    case "Categoria":
                        Categoria categoria = (Categoria)paraDeletar;
                        nomeTabela = "CATEGORIAS";
                        instrucaoSql += string.Format(" {0} WHERE IDCATEGORIA = @IDCATEGORIA", nomeTabela);
                        comandoSql.Parameters.AddWithValue("@IDCATEGORIA", categoria.IDCategoria);
                        break;

                    case "Cliente":
                        Cliente cliente = (Cliente)paraDeletar;
                        nomeTabela = "CLIENTES";
                        instrucaoSql += string.Format(" {0} WHERE IDCLIENTE = @IDCLIENTE", nomeTabela);
                        comandoSql.Parameters.AddWithValue("@IDCLIENTE", cliente.IDCliente);
                        break;

                    case "Fornecedor":
                        Fornecedor fornecedor = (Fornecedor)paraDeletar;
                        nomeTabela = "FORNECEDORES";
                        instrucaoSql += string.Format(" {0} WHERE IDFORNECEDOR = @IDFORNECEDOR", nomeTabela);
                        comandoSql.Parameters.AddWithValue("@IDFORNECEDOR", fornecedor.IDFornecedor);
                        break;

                    case "ItensVenda":
                        ItensVenda itensVenda = (ItensVenda)paraDeletar;
                        nomeTabela = "ITENSVENDA";
                        instrucaoSql += string.Format(" {0} WHERE IDITENSVENDA = @IDITENSVENDA", nomeTabela);
                        comandoSql.Parameters.AddWithValue("@IDITENSVENDA", itensVenda.IDItensVenda);
                        break;

                    case "Peca":
                        Peca peca = (Peca)paraDeletar;
                        nomeTabela = "PECAS";
                        instrucaoSql += string.Format(" {0} WHERE IDPECA = @IDPECA", nomeTabela);
                        comandoSql.Parameters.AddWithValue("@IDPECA", peca.IDPeca);
                        break;

                    case "Veiculo":
                        Veiculo veiculo = (Veiculo)paraDeletar;
                        nomeTabela = "VEICULOS";
                        instrucaoSql += string.Format(" {0} WHERE IDVEICULO = @IDVEICULO", nomeTabela);
                        comandoSql.Parameters.AddWithValue("@IDVEICULO", veiculo.IDVeiculo);
                        break;

                    case "Venda":
                        Venda venda = (Venda)paraDeletar;
                        nomeTabela = "VENDA";
                        instrucaoSql += string.Format(" {0} WHERE IDVENDA = @IDVENDA", nomeTabela);
                        comandoSql.Parameters.AddWithValue("@IDVENDA", venda.IDVenda);
                        break;

                    case "Vendedor":
                        Vendedor vendedor = (Vendedor)paraDeletar;
                        nomeTabela = "VENDEDORES";
                        instrucaoSql += string.Format(" {0} WHERE IDVENDEDOR = @IDVENDEDOR", nomeTabela);
                        comandoSql.Parameters.AddWithValue("@IDVENDEDOR", vendedor.IDVendedor);
                        break;
                }

                comandoSql.CommandText = instrucaoSql;
                comandoSql.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                if (conexaoSql.State == ConnectionState.Open)
                {
                    conexaoSql.Close();
                }
            }
        }
    }
}