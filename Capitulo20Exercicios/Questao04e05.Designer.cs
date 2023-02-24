namespace Capitulo20Exercicios
{
    partial class Questao04e05
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
            BotaoAbrirConta = new System.Windows.Forms.Button();
            DataDeNascimento = new System.Windows.Forms.DateTimePicker();
            Nome = new System.Windows.Forms.TextBox();
            TextoDigiteNome = new System.Windows.Forms.Label();
            TextoDigiteDataDeNascimento = new System.Windows.Forms.Label();
            ContaCorrente = new System.Windows.Forms.CheckBox();
            ContaPoupanca = new System.Windows.Forms.CheckBox();
            ContaUniversitaria = new System.Windows.Forms.CheckBox();
            panel1 = new System.Windows.Forms.Panel();
            PessoaFisica = new System.Windows.Forms.CheckBox();
            SemCodigoDeMatricula = new System.Windows.Forms.CheckBox();
            PessoaJuridica = new System.Windows.Forms.CheckBox();
            TextoDigiteCNPJ = new System.Windows.Forms.Label();
            CNPJ = new System.Windows.Forms.TextBox();
            TextoPassarCodDoGerente = new System.Windows.Forms.Label();
            CodigoGerente = new System.Windows.Forms.TextBox();
            ContaPJ = new System.Windows.Forms.CheckBox();
            TextoDigiteCodDaMatricula = new System.Windows.Forms.Label();
            Matricula = new System.Windows.Forms.TextBox();
            Universitario = new System.Windows.Forms.CheckBox();
            Emancipado = new System.Windows.Forms.CheckBox();
            TextoDigiteSeuCpf = new System.Windows.Forms.Label();
            Cpf = new System.Windows.Forms.TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // BotaoAbrirConta
            // 
            BotaoAbrirConta.Location = new System.Drawing.Point(301, 356);
            BotaoAbrirConta.Name = "BotaoAbrirConta";
            BotaoAbrirConta.Size = new System.Drawing.Size(111, 40);
            BotaoAbrirConta.TabIndex = 0;
            BotaoAbrirConta.Text = "Abrir conta";
            BotaoAbrirConta.UseVisualStyleBackColor = true;
            // 
            // DataDeNascimento
            // 
            DataDeNascimento.Enabled = false;
            DataDeNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            DataDeNascimento.Location = new System.Drawing.Point(227, 92);
            DataDeNascimento.Name = "DataDeNascimento";
            DataDeNascimento.Size = new System.Drawing.Size(111, 23);
            DataDeNascimento.TabIndex = 1;
            DataDeNascimento.ValueChanged += DataDeNascimento_ValueChanged;
            // 
            // Nome
            // 
            Nome.Location = new System.Drawing.Point(92, 92);
            Nome.Name = "Nome";
            Nome.Size = new System.Drawing.Size(111, 23);
            Nome.TabIndex = 2;
            Nome.TextChanged += Nome_TextChanged;
            // 
            // TextoDigiteNome
            // 
            TextoDigiteNome.AutoSize = true;
            TextoDigiteNome.Location = new System.Drawing.Point(93, 74);
            TextoDigiteNome.Name = "TextoDigiteNome";
            TextoDigiteNome.Size = new System.Drawing.Size(96, 15);
            TextoDigiteNome.TabIndex = 3;
            TextoDigiteNome.Text = "Digite seu nome:";
            // 
            // TextoDigiteDataDeNascimento
            // 
            TextoDigiteDataDeNascimento.AutoSize = true;
            TextoDigiteDataDeNascimento.Location = new System.Drawing.Point(227, 74);
            TextoDigiteDataDeNascimento.Name = "TextoDigiteDataDeNascimento";
            TextoDigiteDataDeNascimento.Size = new System.Drawing.Size(115, 15);
            TextoDigiteDataDeNascimento.TabIndex = 4;
            TextoDigiteDataDeNascimento.Text = "Data de nascimento:";
            // 
            // ContaCorrente
            // 
            ContaCorrente.AutoSize = true;
            ContaCorrente.Location = new System.Drawing.Point(91, 287);
            ContaCorrente.Name = "ContaCorrente";
            ContaCorrente.Size = new System.Drawing.Size(107, 19);
            ContaCorrente.TabIndex = 6;
            ContaCorrente.Text = "Conta Corrente";
            ContaCorrente.UseVisualStyleBackColor = true;
            ContaCorrente.Visible = false;
            // 
            // ContaPoupanca
            // 
            ContaPoupanca.AutoSize = true;
            ContaPoupanca.Location = new System.Drawing.Point(247, 287);
            ContaPoupanca.Name = "ContaPoupanca";
            ContaPoupanca.Size = new System.Drawing.Size(114, 19);
            ContaPoupanca.TabIndex = 7;
            ContaPoupanca.Text = "Conta Poupança";
            ContaPoupanca.UseVisualStyleBackColor = true;
            ContaPoupanca.Visible = false;
            // 
            // ContaUniversitaria
            // 
            ContaUniversitaria.AutoSize = true;
            ContaUniversitaria.Location = new System.Drawing.Point(398, 287);
            ContaUniversitaria.Name = "ContaUniversitaria";
            ContaUniversitaria.Size = new System.Drawing.Size(126, 19);
            ContaUniversitaria.TabIndex = 8;
            ContaUniversitaria.Text = "Conta Universitária";
            ContaUniversitaria.UseVisualStyleBackColor = true;
            ContaUniversitaria.Visible = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(PessoaFisica);
            panel1.Controls.Add(SemCodigoDeMatricula);
            panel1.Controls.Add(PessoaJuridica);
            panel1.Controls.Add(TextoDigiteCNPJ);
            panel1.Controls.Add(CNPJ);
            panel1.Controls.Add(TextoPassarCodDoGerente);
            panel1.Controls.Add(CodigoGerente);
            panel1.Controls.Add(ContaPJ);
            panel1.Controls.Add(TextoDigiteCodDaMatricula);
            panel1.Controls.Add(Matricula);
            panel1.Controls.Add(Universitario);
            panel1.Controls.Add(Emancipado);
            panel1.Controls.Add(TextoDigiteSeuCpf);
            panel1.Controls.Add(Cpf);
            panel1.Controls.Add(ContaUniversitaria);
            panel1.Controls.Add(ContaPoupanca);
            panel1.Controls.Add(ContaCorrente);
            panel1.Controls.Add(TextoDigiteDataDeNascimento);
            panel1.Controls.Add(TextoDigiteNome);
            panel1.Controls.Add(Nome);
            panel1.Controls.Add(DataDeNascimento);
            panel1.Controls.Add(BotaoAbrirConta);
            panel1.Location = new System.Drawing.Point(31, 26);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(735, 431);
            panel1.TabIndex = 3;
            // 
            // PessoaFisica
            // 
            PessoaFisica.AutoSize = true;
            PessoaFisica.Location = new System.Drawing.Point(92, 35);
            PessoaFisica.Name = "PessoaFisica";
            PessoaFisica.Size = new System.Drawing.Size(94, 19);
            PessoaFisica.TabIndex = 22;
            PessoaFisica.Text = "Pessoa Física";
            PessoaFisica.UseVisualStyleBackColor = true;
            PessoaFisica.CheckedChanged += PessoaFisica_CheckedChanged;
            // 
            // SemCodigoDeMatricula
            // 
            SemCodigoDeMatricula.AutoSize = true;
            SemCodigoDeMatricula.Location = new System.Drawing.Point(273, 171);
            SemCodigoDeMatricula.Name = "SemCodigoDeMatricula";
            SemCodigoDeMatricula.Size = new System.Drawing.Size(139, 19);
            SemCodigoDeMatricula.TabIndex = 21;
            SemCodigoDeMatricula.Text = "Não possuo o código";
            SemCodigoDeMatricula.UseVisualStyleBackColor = true;
            SemCodigoDeMatricula.Visible = false;
            SemCodigoDeMatricula.CheckedChanged += SemCodigoDeMatricula_CheckedChanged;
            // 
            // PessoaJuridica
            // 
            PessoaJuridica.AutoSize = true;
            PessoaJuridica.Location = new System.Drawing.Point(201, 35);
            PessoaJuridica.Name = "PessoaJuridica";
            PessoaJuridica.Size = new System.Drawing.Size(105, 19);
            PessoaJuridica.TabIndex = 20;
            PessoaJuridica.Text = "Pessoa Jurídica";
            PessoaJuridica.UseVisualStyleBackColor = true;
            PessoaJuridica.CheckedChanged += PessoaJuridica_CheckedChanged;
            // 
            // TextoDigiteCNPJ
            // 
            TextoDigiteCNPJ.AutoSize = true;
            TextoDigiteCNPJ.Location = new System.Drawing.Point(91, 209);
            TextoDigiteCNPJ.Name = "TextoDigiteCNPJ";
            TextoDigiteCNPJ.Size = new System.Drawing.Size(81, 15);
            TextoDigiteCNPJ.TabIndex = 19;
            TextoDigiteCNPJ.Text = "Digite o CNPJ:";
            TextoDigiteCNPJ.Visible = false;
            // 
            // CNPJ
            // 
            CNPJ.Location = new System.Drawing.Point(92, 227);
            CNPJ.Name = "CNPJ";
            CNPJ.Size = new System.Drawing.Size(133, 23);
            CNPJ.TabIndex = 18;
            CNPJ.Visible = false;
            // 
            // TextoPassarCodDoGerente
            // 
            TextoPassarCodDoGerente.AutoSize = true;
            TextoPassarCodDoGerente.Location = new System.Drawing.Point(453, 151);
            TextoPassarCodDoGerente.Name = "TextoPassarCodDoGerente";
            TextoPassarCodDoGerente.Size = new System.Drawing.Size(223, 15);
            TextoPassarCodDoGerente.TabIndex = 17;
            TextoPassarCodDoGerente.Text = "Passe o código do gerente para exceções";
            TextoPassarCodDoGerente.Visible = false;
            // 
            // CodigoGerente
            // 
            CodigoGerente.Location = new System.Drawing.Point(496, 171);
            CodigoGerente.Name = "CodigoGerente";
            CodigoGerente.Size = new System.Drawing.Size(133, 23);
            CodigoGerente.TabIndex = 16;
            CodigoGerente.Visible = false;
            // 
            // ContaPJ
            // 
            ContaPJ.AutoSize = true;
            ContaPJ.Location = new System.Drawing.Point(544, 287);
            ContaPJ.Name = "ContaPJ";
            ContaPJ.Size = new System.Drawing.Size(71, 19);
            ContaPJ.TabIndex = 15;
            ContaPJ.Text = "Conta PJ";
            ContaPJ.UseVisualStyleBackColor = true;
            ContaPJ.Visible = false;
            // 
            // TextoDigiteCodDaMatricula
            // 
            TextoDigiteCodDaMatricula.AutoSize = true;
            TextoDigiteCodDaMatricula.Location = new System.Drawing.Point(90, 151);
            TextoDigiteCodDaMatricula.Name = "TextoDigiteCodDaMatricula";
            TextoDigiteCodDaMatricula.Size = new System.Drawing.Size(160, 15);
            TextoDigiteCodDaMatricula.TabIndex = 14;
            TextoDigiteCodDaMatricula.Text = "Digite o código da matrícula:";
            TextoDigiteCodDaMatricula.Visible = false;
            // 
            // Matricula
            // 
            Matricula.Location = new System.Drawing.Point(91, 169);
            Matricula.Name = "Matricula";
            Matricula.Size = new System.Drawing.Size(159, 23);
            Matricula.TabIndex = 13;
            Matricula.Visible = false;
            // 
            // Universitario
            // 
            Universitario.AutoSize = true;
            Universitario.Location = new System.Drawing.Point(323, 35);
            Universitario.Name = "Universitario";
            Universitario.Size = new System.Drawing.Size(103, 19);
            Universitario.TabIndex = 12;
            Universitario.Text = "Universitário/a";
            Universitario.UseVisualStyleBackColor = true;
            Universitario.CheckedChanged += Universitario_CheckedChanged;
            // 
            // Emancipado
            // 
            Emancipado.AutoSize = true;
            Emancipado.Location = new System.Drawing.Point(227, 121);
            Emancipado.Name = "Emancipado";
            Emancipado.Size = new System.Drawing.Size(103, 19);
            Emancipado.TabIndex = 11;
            Emancipado.Text = "Emancipado/a";
            Emancipado.UseVisualStyleBackColor = true;
            Emancipado.CheckedChanged += Emancipado_CheckedChanged;
            // 
            // TextoDigiteSeuCpf
            // 
            TextoDigiteSeuCpf.AutoSize = true;
            TextoDigiteSeuCpf.Location = new System.Drawing.Point(366, 74);
            TextoDigiteSeuCpf.Name = "TextoDigiteSeuCpf";
            TextoDigiteSeuCpf.Size = new System.Drawing.Size(86, 15);
            TextoDigiteSeuCpf.TabIndex = 10;
            TextoDigiteSeuCpf.Text = "Digite seu CPF:";
            TextoDigiteSeuCpf.Visible = false;
            // 
            // Cpf
            // 
            Cpf.Location = new System.Drawing.Point(365, 92);
            Cpf.Name = "Cpf";
            Cpf.Size = new System.Drawing.Size(133, 23);
            Cpf.TabIndex = 9;
            Cpf.Visible = false;
            // 
            // Questao04e05
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(801, 482);
            Controls.Add(panel1);
            Name = "Questao04e05";
            Text = "Questao04";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button BotaoAbrirConta;
        private System.Windows.Forms.DateTimePicker DataDeNascimento;
        private System.Windows.Forms.TextBox Nome;
        private System.Windows.Forms.Label TextoDigiteNome;
        private System.Windows.Forms.Label TextoDigiteDataDeNascimento;
        private System.Windows.Forms.CheckBox ContaCorrente;
        private System.Windows.Forms.CheckBox ContaPoupanca;
        private System.Windows.Forms.CheckBox ContaUniversitaria;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox PessoaFisica;
        private System.Windows.Forms.CheckBox SemCodigoDeMatricula;
        private System.Windows.Forms.CheckBox PessoaJuridica;
        private System.Windows.Forms.Label TextoDigiteCNPJ;
        private System.Windows.Forms.TextBox CNPJ;
        private System.Windows.Forms.Label TextoPassarCodDoGerente;
        private System.Windows.Forms.TextBox CodigoGerente;
        private System.Windows.Forms.CheckBox ContaPJ;
        private System.Windows.Forms.Label TextoDigiteCodDaMatricula;
        private System.Windows.Forms.TextBox Matricula;
        private System.Windows.Forms.CheckBox Universitario;
        private System.Windows.Forms.CheckBox Emancipado;
        private System.Windows.Forms.Label TextoDigiteSeuCpf;
        private System.Windows.Forms.TextBox Cpf;
    }
}