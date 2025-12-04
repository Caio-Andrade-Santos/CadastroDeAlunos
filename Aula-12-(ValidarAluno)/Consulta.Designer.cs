namespace Aula_12__ValidarAluno_
{
    partial class Consulta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consulta));
            this.laProntuario = new System.Windows.Forms.Label();
            this.txtProntuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.gbDados = new System.Windows.Forms.GroupBox();
            this.panelDados = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbDados.SuspendLayout();
            this.panelDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // laProntuario
            // 
            this.laProntuario.AutoSize = true;
            this.laProntuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laProntuario.Location = new System.Drawing.Point(108, 73);
            this.laProntuario.Name = "laProntuario";
            this.laProntuario.Size = new System.Drawing.Size(67, 12);
            this.laProntuario.TabIndex = 0;
            this.laProntuario.Text = "Prontuario:";
            // 
            // txtProntuario
            // 
            this.txtProntuario.BackColor = System.Drawing.Color.Beige;
            this.txtProntuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProntuario.Location = new System.Drawing.Point(191, 70);
            this.txtProntuario.Name = "txtProntuario";
            this.txtProntuario.Size = new System.Drawing.Size(369, 20);
            this.txtProntuario.TabIndex = 1;
            this.txtProntuario.TextChanged += new System.EventHandler(this.txtProntuario_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "CPF:";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "RG:";
            this.label4.Visible = false;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "Email:";
            this.label5.Visible = false;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.Beige;
            this.txtNome.Enabled = false;
            this.txtNome.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(2, 10);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(326, 20);
            this.txtNome.TabIndex = 6;
            this.txtNome.Visible = false;
            // 
            // txtCPF
            // 
            this.txtCPF.BackColor = System.Drawing.Color.Beige;
            this.txtCPF.Enabled = false;
            this.txtCPF.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPF.Location = new System.Drawing.Point(2, 46);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(326, 20);
            this.txtCPF.TabIndex = 7;
            this.txtCPF.Visible = false;
            // 
            // txtRG
            // 
            this.txtRG.BackColor = System.Drawing.Color.Beige;
            this.txtRG.Enabled = false;
            this.txtRG.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRG.Location = new System.Drawing.Point(2, 80);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(326, 20);
            this.txtRG.TabIndex = 8;
            this.txtRG.Visible = false;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Beige;
            this.txtEmail.Enabled = false;
            this.txtEmail.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(2, 115);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(326, 20);
            this.txtEmail.TabIndex = 9;
            this.txtEmail.Visible = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(39, 396);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(131, 23);
            this.btnVoltar.TabIndex = 10;
            this.btnVoltar.Text = "voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulta.Location = new System.Drawing.Point(593, 68);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(166, 23);
            this.btnConsulta.TabIndex = 11;
            this.btnConsulta.Text = "Consultar";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(326, 396);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(152, 23);
            this.btnEditar.TabIndex = 12;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(593, 396);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(168, 23);
            this.btnExcluir.TabIndex = 13;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // gbDados
            // 
            this.gbDados.Controls.Add(this.panelDados);
            this.gbDados.Controls.Add(this.label5);
            this.gbDados.Controls.Add(this.label4);
            this.gbDados.Controls.Add(this.label3);
            this.gbDados.Controls.Add(this.label2);
            this.gbDados.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDados.Location = new System.Drawing.Point(130, 138);
            this.gbDados.Name = "gbDados";
            this.gbDados.Size = new System.Drawing.Size(477, 213);
            this.gbDados.TabIndex = 14;
            this.gbDados.TabStop = false;
            this.gbDados.Text = "Dados:";
            this.gbDados.Visible = false;
            // 
            // panelDados
            // 
            this.panelDados.Controls.Add(this.txtEmail);
            this.panelDados.Controls.Add(this.txtRG);
            this.panelDados.Controls.Add(this.txtCPF);
            this.panelDados.Controls.Add(this.txtNome);
            this.panelDados.Location = new System.Drawing.Point(82, 37);
            this.panelDados.Name = "panelDados";
            this.panelDados.Size = new System.Drawing.Size(348, 159);
            this.panelDados.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(322, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 22);
            this.label1.TabIndex = 15;
            this.label1.Text = "Pesquisar Usuario";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Aula_12__ValidarAluno_.Properties.Resources.IFSP_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(247, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbDados);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.txtProntuario);
            this.Controls.Add(this.laProntuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Consulta";
            this.Text = "Consulta";
            this.gbDados.ResumeLayout(false);
            this.gbDados.PerformLayout();
            this.panelDados.ResumeLayout(false);
            this.panelDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label laProntuario;
        private System.Windows.Forms.TextBox txtProntuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.GroupBox gbDados;
        private System.Windows.Forms.Panel panelDados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}