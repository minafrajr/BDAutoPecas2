using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Camadas
{
    class Operacoes
    {

        #region ValidaCNPJ
        //Função bolleana para validar o CNPJ
        /// <summary>
        /// Função boleana para validar o CNPJ
        /// </summary>
        /// <param name="_cnpj">CNPJ do Fornecedor</param>
        /// <returns>booleano</returns>
        public bool Valida_CNPJ(string _CNPJ)
        {
            int[] Multiplicador1 = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] Multiplicador2 = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            int soma;
            int resto;
            string digito;
            string tempCNPJ;
            string auxcnpj;

            auxcnpj = _CNPJ;
            if (auxcnpj.Length != 14)
                return false;

            tempCNPJ = auxcnpj.Substring(0, 12);

            soma = 0;
            for (int i = 0; i < 12; i++)
            {
                soma += int.Parse(tempCNPJ[i].ToString()) * Multiplicador1[i];
            }

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = resto.ToString();

            tempCNPJ = tempCNPJ + digito;

            soma = 0;
            for (int i = 0; i < 13; i++)
            {
                soma += int.Parse(tempCNPJ[i].ToString()) * Multiplicador2[i];
            }

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            return auxcnpj.EndsWith(digito);
        }
        #endregion ValidaCNPJ        
        
        #region ValidaCPF
        /// <summary>
        /// Funcao Boleanda para validar o CPF informado
        /// </summary>
        /// <param name="_CPF">informe o cpf a ser verificado</param>
        /// <returns>Retorna true ou false</returns>
        public bool Valida_CPF(string _CPF)
        {
            int[] Multiplicador1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] Multiplicador2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            string auxCPF = _CPF;

            if (auxCPF.Length != 11)
                return false;

            tempCpf = auxCPF.Substring(0, 9);

            soma = 0;
            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * Multiplicador1[i];

            resto = soma % 11;

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = resto.ToString();

            tempCpf = tempCpf + digito;

            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * Multiplicador2[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            return auxCPF.EndsWith(digito);
        }
        #endregion ValidaCPF



    }
}
