using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Aula_12__ValidarAluno_
{
    public static class Validacoes
    {
        public static bool ValidaCPF(string cpf)
        {
            int soma = 0, resto, dig;
            //retiro caracteres ". / -"
            cpf = cpf.Replace(".", "").Replace("-", "").Replace("/", "").Replace(" ", "");
            //verifico se sobrou 11 caracteres
            if (cpf.Length != 11)
                return false;

            //verificação do primeiro dígito
            for (int i = 0; i < 9; i++)
            {
                soma += int.Parse(cpf[i].ToString()) * (10 - i);
            }
            //verifico o resto da divisao da soma por 11
            resto = soma % 11;
            //se resto = 0 ou resto = 1 --> digito = 0
            if (resto < 2)
            {
                dig = 0;
            }
            else
            {
                dig = 11 - resto;
            }
            if (dig.ToString() != cpf[9].ToString())
                return false;
            //se chegou até aqui verifico o segundo dígito
            soma = 0;
            for (int i = 0; i < 10; i++)
            {
                soma += int.Parse(cpf[i].ToString()) * (11 - i);
            }
            //verifico o resto da divisao da soma por 11
            resto = soma % 11;
            //se resto = 0 ou resto = 1 --> digito = 0
            if (resto < 2)
            {
                dig = 0;
            }
            else
            {
                dig = 11 - resto;
            }
            if (dig.ToString() != cpf[10].ToString())
                return false;
            else
                return true;
        }

        public static bool ValidaRG(string rg)
        {
            int soma = 0;
            int resto;
            string digito;
            //retiro caracteres ". / -"
            rg = rg.Replace(".", "").Replace("-", "").Replace("/", "").Replace(" ", "");
            //verifico se sobrou 11 caracteres
            if (rg.Length != 9)
                return false;
            //multiplico os termos
            for (int i = 0; i < 8; i++)
                soma += int.Parse(rg[i].ToString()) * (2 + i);

            resto = soma % 11;
            if (resto == 10)
                digito = "X";
            else if (resto == 0)
                digito = "0";
            else
                digito = (11 - resto).ToString();

            if (digito == rg[8].ToString())
                return true;
            else
                return false;


        }

        public static bool ValidaProntuario(string prontuario)
        {
            if (prontuario.Length != 9) return false;      //tem menos digítos que o necessário
            string numeros = prontuario.Substring(2, 6);  //separo os números sem o dígito
            string digito = prontuario.Substring(8, 1).ToUpper();
            string digitocalculado;
            int num, resto, dv;
            int[] pesos = { 7, 6, 5, 4, 3, 2 };
            int soma = 0;
            for (int i = 0; i < pesos.Length; i++)
            {
                num = int.Parse(numeros[i].ToString());
                soma += num * pesos[i];
            }

            resto = soma % 11;
            dv = 11 - resto;

            if (dv == 10)
                digitocalculado = "X";
            else if (dv == 11)
                digitocalculado = "1";
            else
                digitocalculado = dv.ToString();

            if (digito == digitocalculado)
                return true;
            else
                return false;
        }
        public static bool ValidaEmail(string email)
        {
            // Expressão regular para validar o formato do e-mail
            string padrao = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Usa Regex.IsMatch() para comparar
            return Regex.IsMatch(email, padrao);
        }
    }
}
