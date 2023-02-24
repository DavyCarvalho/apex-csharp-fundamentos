namespace Capitulo20Exercicios
{
    partial class Questao02e03
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
            textBoxDoNumeroDaConta = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            BotaoConsultarSaldo = new System.Windows.Forms.Button();
            textBoxDoSaldo = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            checkBoxChequeEspecial = new System.Windows.Forms.CheckBox();
            BotaoSacar = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxDoNumeroDaConta
            // 
            textBoxDoNumeroDaConta.Location = new System.Drawing.Point(46, 65);
            textBoxDoNumeroDaConta.Name = "textBoxDoNumeroDaConta";
            textBoxDoNumeroDaConta.Size = new System.Drawing.Size(100, 23);
            textBoxDoNumeroDaConta.TabIndex = 0;
            textBoxDoNumeroDaConta.TextChanged += textBoxDoNumeroDaConta_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(46, 47);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(94, 15);
            label1.TabIndex = 1;
            label1.Text = "Nº da sua conta:";
            // 
            // BotaoConsultarSaldo
            // 
            BotaoConsultarSaldo.Enabled = false;
            BotaoConsultarSaldo.Location = new System.Drawing.Point(167, 65);
            BotaoConsultarSaldo.Name = "BotaoConsultarSaldo";
            BotaoConsultarSaldo.Size = new System.Drawing.Size(111, 23);
            BotaoConsultarSaldo.TabIndex = 2;
            BotaoConsultarSaldo.Text = "Consultar Saldo";
            BotaoConsultarSaldo.UseVisualStyleBackColor = true;
            BotaoConsultarSaldo.Click += BotaoConsultarSaldo_Click;
            // 
            // textBoxDoSaldo
            // 
            textBoxDoSaldo.Location = new System.Drawing.Point(46, 134);
            textBoxDoSaldo.Name = "textBoxDoSaldo";
            textBoxDoSaldo.ReadOnly = true;
            textBoxDoSaldo.Size = new System.Drawing.Size(100, 23);
            textBoxDoSaldo.TabIndex = 3;
            textBoxDoSaldo.TextChanged += textBoxDoSaldo_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(46, 116);
            label2.Name = "label2";
            label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            label2.Size = new System.Drawing.Size(36, 15);
            label2.TabIndex = 4;
            label2.Text = "Saldo";
            // 
            // checkBoxChequeEspecial
            // 
            checkBoxChequeEspecial.AutoSize = true;
            checkBoxChequeEspecial.Location = new System.Drawing.Point(50, 94);
            checkBoxChequeEspecial.Name = "checkBoxChequeEspecial";
            checkBoxChequeEspecial.Size = new System.Drawing.Size(135, 19);
            checkBoxChequeEspecial.TabIndex = 5;
            checkBoxChequeEspecial.Text = "Tem cheque especial";
            checkBoxChequeEspecial.UseVisualStyleBackColor = true;
            // 
            // BotaoSacar
            // 
            BotaoSacar.Enabled = false;
            BotaoSacar.Location = new System.Drawing.Point(167, 133);
            BotaoSacar.Name = "BotaoSacar";
            BotaoSacar.Size = new System.Drawing.Size(75, 23);
            BotaoSacar.TabIndex = 6;
            BotaoSacar.Text = "Sacar";
            BotaoSacar.UseVisualStyleBackColor = true;
            BotaoSacar.Click += BotaoSacar_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(BotaoSacar);
            panel1.Controls.Add(checkBoxChequeEspecial);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBoxDoSaldo);
            panel1.Controls.Add(BotaoConsultarSaldo);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBoxDoNumeroDaConta);
            panel1.Location = new System.Drawing.Point(62, 73);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(329, 199);
            panel1.TabIndex = 2;
            // 
            // Questao02
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(448, 365);
            Controls.Add(panel1);
            Name = "Questao02";
            Text = "Questao02";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDoNumeroDaConta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BotaoConsultarSaldo;
        private System.Windows.Forms.TextBox textBoxDoSaldo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxChequeEspecial;
        private System.Windows.Forms.Button BotaoSacar;
        private System.Windows.Forms.Panel panel1;
    }
}