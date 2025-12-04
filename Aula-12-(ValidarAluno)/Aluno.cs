using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Aula_12__ValidarAluno_
{
    internal class Aluno
    {
        private string prontuario;
        private string nome;
        private string cpf;
        private string rg;
        private string email;

        public string CPF
        {
            get { return cpf; }
            set
            {
                if (Validacoes.ValidaCPF(value))
                {
                    cpf = value;
                }
                else { throw new Exception("CPF inválido!"); }
            }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }



        public string RG
        {
            get { return rg; }
            set
            {
                if (Validacoes.ValidaRG(value))
                {
                    rg = value;
                }
                else
                {
                    throw new Exception("RG inválido!");
                }
            }
        }

        public string Prontuario
        {
            get { return prontuario; }
            set
            {
                if (Validacoes.ValidaProntuario(value))
                {
                    prontuario = value;
                }
                else
                {
                    throw new Exception("Prontuário inválido!");
                }
            }
        }
        public string Email
        {
            get { return email; }
            set
            {
                if (Validacoes.ValidaEmail(value))
                {
                    email = value;
                }
                else
                {
                    throw new Exception("E-mail inválido!");
                }
            }
        }

        public void Incluir()
        {
            SqlConnection Con = new SqlConnection();
            try
            {
                Con.ConnectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=dbAcademico;Integrated Security=True";
                SqlCommand Comando = new SqlCommand();
                Comando.Connection = Con;
                Comando.CommandType = CommandType.Text;
                Comando.CommandText = "insert into Alunos (Prontuario,Nome,CPF,RG,Email) Values (@Prontuario,@Nome,@CPF,@RG,@Email)";
                Comando.Parameters.AddWithValue("@Prontuario", Prontuario);
                Comando.Parameters.AddWithValue("@Nome", Nome);
                Comando.Parameters.AddWithValue("@CPF", CPF);
                Comando.Parameters.AddWithValue("@RG", RG);
                Comando.Parameters.AddWithValue("@Email", Email);

                // Abro a conexão

                Con.Open();

                //execultado o comando, sem dwvolver nadad

                Comando.ExecuteNonQuery();
            }
            catch (Exception ex) {
                throw new Exception("erro");
            }
            finally
            {
                Con.Close();
            }
        }
       public bool Consultar()
        {
            SqlConnection Con = new SqlConnection();
            Con.ConnectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=dbAcademico;Integrated Security=True";
            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Con;
            Comando.CommandType = CommandType.Text;
            Comando.CommandText = "Select Prontuario, Nome, CPF, RG, Email From Alunos Where Prontuario = @Prontuario ";
            Comando.Parameters.AddWithValue("@Prontuario", Prontuario);
            Con.Open();
            SqlDataReader DR = Comando.ExecuteReader();
            if (!DR.Read()) { 
                return false;
            }
            this.Nome = DR["Nome"].ToString();
            this.CPF = DR["CPF"].ToString();
            this.RG = DR["RG"].ToString();
            this.Email = DR["Email"].ToString();
            return true;
        }
       public void Editar()
        {
            SqlConnection Con = new SqlConnection();
            Con.ConnectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=dbAcademico;Integrated Security=True";
            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Con;
            Comando.CommandType = CommandType.Text;
            Comando.CommandText = "Update Alunos Set Nome=@Nome, CPF=@CPF, RG=@RG, Email=@Email Where Prontuario=@Prontuario";
            Comando.Parameters.AddWithValue("@Prontuario", Prontuario);
            Comando.Parameters.AddWithValue("@Nome", Nome);
            Comando.Parameters.AddWithValue("@CPF", CPF);
            Comando.Parameters.AddWithValue("@RG", RG);
            Comando.Parameters.AddWithValue("@Email", Email);
            Con.Open();
            Comando.ExecuteNonQuery();
            Con.Close();
        }

        public void Excluir()
        {
            SqlConnection Con = new SqlConnection();
            Con.ConnectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=dbAcademico;Integrated Security=True";
            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Con;
            Comando.CommandType = CommandType.Text;
            Comando.CommandText = "Delete From Alunos Where Prontuario=@Prontuario";
            Comando.Parameters.AddWithValue("@Prontuario", Prontuario);
            Con.Open();
            Comando.ExecuteNonQuery();
            Con.Close();
        }
    }
}
