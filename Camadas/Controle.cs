using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Camadas
{
    public class Controle
    {
        Modelo modelo;

        /// <summary>
        /// Método para inserir qualquer objeto no banco de dados.
        /// </summary>
        /// <param name="paraInserir">Objeto a ser inserido.</param>
        public void ControleInserir(object paraInserir)
        {
            try
            {
                modelo = new Modelo();
                modelo.ModeloInserir(paraInserir);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        /// <summary>
        /// Método para atualizar qualquer objeto no banco de dados.
        /// </summary>
        /// <param name="paraAtualizar">Objeto a ser atualizado.</param>
        public void ControleAtualizar(object paraAtualizar)
        {
            try
            {
                modelo = new Modelo();
                modelo.ModeloAtualizar(paraAtualizar);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        /// <summary>
        /// Método para deletar qualquer objeto no banco de dados.
        /// </summary>
        /// <param name="paraDeletar">Objeto a ser deletado.</param>
        public void ControleDeletar(object paraDeletar)
        {
            try
            {
                modelo = new Modelo();
                modelo.ModeloDeletar(paraDeletar);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        /// <summary>
        /// Método para controlar a recuperação de todos os vendedores no banco de dados.
        /// </summary>
        /// <returns>Lista de vendedores.</returns>
        public List<Vendedor> ControleRecuperarVendedores()
        {
            try
            {
                return (new Modelo()).ModeloRecuperarVendedores();
            }
            catch
            {
                throw new Exception("Erro ao retornar a lista de vendedores! Camada: Controle");
            }
        }
    }
}
