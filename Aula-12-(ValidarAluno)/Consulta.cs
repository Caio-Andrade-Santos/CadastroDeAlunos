using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_12__ValidarAluno_
{
    public partial class Consulta : Form
    {
        public Consulta(string prontuario)
        {
            InitializeComponent();
            txtProntuario.Text = prontuario;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void txtProntuario_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;

            Aluno aluno3 = new Aluno();
            aluno3.Prontuario = txtProntuario.Text;
            if (aluno3.Consultar())
            {
                gbDados.Visible = true;

                foreach (Control c in gbDados.Controls)
                {
                    if (c.Visible == false)
                    {
                        c.Visible = true;
                    }
                }
                foreach(Control c in panelDados.Controls)
                {
                    if (c.Visible == false)
                    {
                        c.Visible = true;
                    }
                }
                txtNome.Text = aluno3.Nome;
                txtCPF.Text = aluno3.CPF;
                txtRG.Text = aluno3.RG;
                txtEmail.Text = aluno3.Email;
            }
            else
            {
                MessageBox.Show("Aluno não encontrado");
                txtProntuario.Text = "";
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            foreach(Control c in gbDados.Controls)
            {
                if (c.Enabled == false)
                {
                    c.Enabled = true;
                }
            }
            foreach (Control c in panelDados.Controls)
            {
                if (c.Enabled == false)
                {
                    c.Enabled = true;
                }
            }
            if (btnEditar.Text == "Editar")
            {
                btnEditar.Text = "Salvar";
            }
            else
            {
                Aluno aluno4 = new Aluno();
                aluno4.Prontuario = txtProntuario.Text;
                aluno4.Nome = txtNome.Text;
                aluno4.CPF = txtCPF.Text;
                aluno4.RG = txtRG.Text;
                aluno4.Email = txtEmail.Text;
                try
                {
                    aluno4.Editar();
                    MessageBox.Show("Dados atualizados com sucesso!");
                    btnEditar.Text = "Editar";
                    foreach (Control c in gbDados.Controls)
                    {
                        c.Enabled = false;
                    }
                    foreach (Control c in panelDados.Controls)
                    {
                        c.Enabled = false;
                        c.Text= "Usuario Atualizado";
                    }
                    btnEditar.Enabled = false;
                    btnExcluir.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Aluno aluno5 = new Aluno();
            aluno5.Prontuario = txtProntuario.Text;
            try
            {
                DialogResult resposta = MessageBox.Show(
                "Deseja realmente continuar?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
);

                if (resposta == DialogResult.Yes)
                {
                    aluno5.Excluir();
                    MessageBox.Show("Aluno Excluido com sucesso");
                    txtProntuario.Text = "";
                    foreach (Control c in panelDados.Controls)
                    {
                        c.Text = "Usuario Excluido";
                    }
                    btnExcluir.Enabled = false;
                    btnEditar.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
 