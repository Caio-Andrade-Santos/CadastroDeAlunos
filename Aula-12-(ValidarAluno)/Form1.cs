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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtCPF_TextChanged(object sender, EventArgs e)
        {
            Verificar();
        }

        public void Limpar()
        {
            txtNome.Text = "";
            txtProntuario.Text = "";
            txtCPF.Text = "";
            txtRG.Text = "";
            txtEmail.Text = "";
            txtNome.Focus();

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            Aluno aluno1 = new Aluno();
            try { aluno1.CPF = txtCPF.Text; }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtCPF.Text = "";
                txtCPF.Focus();
                return;
            }
            try { aluno1.Nome = txtNome.Text; }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtNome.Text = "";
                txtNome.Focus();
                return;
            }
            try { aluno1.RG = txtRG.Text; }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtRG.Text = "";
                txtRG.Focus();
                return;
            }
            try { aluno1.Prontuario = txtProntuario.Text; }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtProntuario.Text = "";
                txtProntuario.Focus();
                return;
            }
            try { aluno1.Email = txtEmail.Text; }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtEmail.Text = "";
                txtEmail.Focus();
                return;
            }

            aluno1.Incluir();

            MessageBox.Show("usuario incluido");

            Limpar();


        }

        public void Verificar()
        {
            bool todosPreenchidos;

            if (txtNome.Text != "" && txtProntuario.Text != "" && txtCPF.Text != "" && txtRG.Text != "" && txtEmail.Text != "")
            {
                todosPreenchidos = true;
            }
            else
            {
                todosPreenchidos = false;
            }

            btnIncluir.Enabled = todosPreenchidos;
            btnConsultar.Enabled = todosPreenchidos;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Consulta tela = new Consulta(txtProntuario.Text);
            tela.Show();
            this.Hide();
        }

        private void lbAlunos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            Verificar();
        }

        private void txtProntuario_TextChanged(object sender, EventArgs e)
        {
            Verificar();
        }

        private void txtRG_TextChanged(object sender, EventArgs e)
        {
            Verificar();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            Verificar();
        }
    }
}
