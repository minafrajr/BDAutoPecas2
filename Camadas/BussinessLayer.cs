using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Camadas
{
    public class BussinessLayer
    {
        DataAccess Acessoadados = new DataAccess(); //objeto da camada de acesso a dados


        public DataTable pesquisa_ID_Cliente(string pesquisa)
        {

            DataTable data = Acessoadados.ConsultaIDCliente(pesquisa);
            return data;
        }

        public DataTable pesquisa_ID_Peca(string pesquisa)
        {
            DataTable data = Acessoadados.ConsultaIDPeca(pesquisa);
            return data;
        }

        public string ID_UltimaVenda()
        {
            string idVenda = Acessoadados.UltimaVenda();
            return idVenda;

        }



        public int contapeca()
        {
            try
            {
                return Acessoadados.numpecas();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        #region Leitura

        public DataTable LerDados(string tabela)
        {
            try
            {
                return Acessoadados.CarregaTabela(tabela);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        #endregion

        #region Atualizar



        public void AtualizarCliente(Cliente cliente)
        {
            try
            {
                Acessoadados.AtualizaCliente(cliente);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void Atualizar(Peca peca)
        {
            try
            {
                Acessoadados.Atualiza(peca);

            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        public void AtualizarVeiculo(Veiculo veiculo)
        {
            try
            {
                Acessoadados.AtualizaVeiculo(veiculo);

            }
            catch (Exception erro)
            {

                throw erro;
            }
        }
        public void AtualizarCategoria(Categoria categoria)
        {
            try
            {
                Acessoadados.AtualizaCategoria(categoria);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void AutalizarFornecedor(Fornecedor fornecedor)
        {
            try
            {
                Acessoadados.AtualizaFornecedor(fornecedor);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void AtualizarVendedor(Vendedor vendedor)
        {
            try
            {
                Acessoadados.AtualizaVendedor(vendedor);
            }
            catch (Exception erro)
            {
                throw erro;
            }

        }

        #endregion

        #region Pesquisar

        public DataTable PocurarCliente(string pesquisa)
        {
            try
            {
                return Acessoadados.PesquisaCliente(pesquisa);

            }
            catch (Exception erro)
            {
                
                throw erro;
            }
        }
        
        
        public DataTable Procurar(string pesquisa)
        {
            try
            {
                return Acessoadados.PesquisaPeca(pesquisa);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public DataTable PesquisarFornecedor(string pesquisa)
        {
            try
            {
                return Acessoadados.PesquisaFornecedor(pesquisa);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        public DataTable PesquisarVendedor(string pesquisa)
        {
            try
            {
                return Acessoadados.PesquisaVendedor(pesquisa);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public DataTable PesquisarCategoria(string pesquisa)
        {
            try
            {
                return Acessoadados.PesquisaCategoria(pesquisa);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        #endregion

        #region Gravar

        public void GravarPeca(Peca peca)
        {
            try
            {
                Acessoadados.Gravar(peca);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void GravarCategorias(Categoria categoria)
        {
            try
            {
                Acessoadados.GravarCategoria(categoria);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void GravarVeiculos(Veiculo veiculo)
        {
            try
            {
                Acessoadados.GravaVeiculo(veiculo);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void GravarVendedor(Vendedor vendedor)
        {
            try
            {
                Acessoadados.GravarVendedor(vendedor);
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
                Acessoadados.GravarFornecedor(fornecedor);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void GravarCliente(Cliente cliente)
        {
            try
            {
                Acessoadados.GravarCliente(cliente);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        #endregion

        #region Deletar



        public void DeletarCliente(Cliente cliente)
        {
            try
            {
                Acessoadados.DeletaCliente(cliente);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public void DeletarPeca(Peca peca)
        {
            try
            {
                Acessoadados.DeletePeca(peca);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void DeletarVeiculo(Veiculo veiculo)
        {
            try
            {
                Acessoadados.DeletaVeiculo(veiculo);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void DeletarCategoria(Categoria categoria)
        {
            try
            {
                Acessoadados.DeleteCategoria(categoria);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void DeletarPhilipe(Object obj)
        {
            Acessoadados.Deleta(obj);
        }

        public void DeletarFornecedor(Fornecedor Modelo)
        {
            try
            {
                Acessoadados.DeletaFornecedor(Modelo);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void DeletarVendedor(Vendedor vendedor)
        {
            try
            {
                Acessoadados.DeletaVendedor(vendedor);
            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion

        #region Filtros

        public DataTable FiltrarPeca(string pesquisa)
        {
            try
            {
                return Acessoadados.Filtrapeca(pesquisa);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        public DataTable FiltrarCliente(string pesquisa)
        {
            try
            {
                return Acessoadados.PesquisaCliente(pesquisa);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        public DataTable FiltrarVendedor(string pesquisa)
        {
            try
            {
                return Acessoadados.FiltraVendedor(pesquisa);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public DataTable FiltrarFornecedor(string pesquisa)
        {
            try
            {
                return Acessoadados.Filtrafornecedor(pesquisa);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public DataTable FiltrarCategoria(string pesquisa)
        {
            try
            {
                return Acessoadados.PesquisaCategoria(pesquisa);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        #endregion
    }


}
