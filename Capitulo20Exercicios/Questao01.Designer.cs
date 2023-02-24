namespace Capitulo20Exercicios
{
    partial class Questao01
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
            textBoxNota1 = new System.Windows.Forms.TextBox();
            textBoxNota2 = new System.Windows.Forms.TextBox();
            textBoxNota3 = new System.Windows.Forms.TextBox();
            textBoxNota4 = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            BotaoDeCalcularMedia = new System.Windows.Forms.Button();
            textBoxDoResultado = new System.Windows.Forms.TextBox();
            labelDoResultado = new System.Windows.Forms.Label();
            botaoLimpar = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // textBoxNota1
            // 
            textBoxNota1.Location = new System.Drawing.Point(272, 83);
            textBoxNota1.Name = "textBoxNota1";
            textBoxNota1.Size = new System.Drawing.Size(230, 23);
            textBoxNota1.TabIndex = 0;
            // 
            // textBoxNota2
            // 
            textBoxNota2.Location = new System.Drawing.Point(272, 122);
            textBoxNota2.Name = "textBoxNota2";
            textBoxNota2.Size = new System.Drawing.Size(230, 23);
            textBoxNota2.TabIndex = 1;
            // 
            // textBoxNota3
            // 
            textBoxNota3.Location = new System.Drawing.Point(272, 165);
            textBoxNota3.Name = "textBoxNota3";
            textBoxNota3.Size = new System.Drawing.Size(230, 23);
            textBoxNota3.TabIndex = 2;
            // 
            // textBoxNota4
            // 
            textBoxNota4.Location = new System.Drawing.Point(272, 208);
            textBoxNota4.Name = "textBoxNota4";
            textBoxNota4.Size = new System.Drawing.Size(230, 23);
            textBoxNota4.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(212, 83);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(54, 20);
            label1.TabIndex = 4;
            label1.Text = "Nota 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(212, 121);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(54, 20);
            label2.TabIndex = 5;
            label2.Text = "Nota 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(212, 165);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(54, 20);
            label3.TabIndex = 6;
            label3.Text = "Nota 3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(212, 208);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(54, 20);
            label4.TabIndex = 7;
            label4.Text = "Nota 4";
            // 
            // BotaoDeCalcularMedia
            // 
            BotaoDeCalcularMedia.Location = new System.Drawing.Point(320, 262);
            BotaoDeCalcularMedia.Name = "BotaoDeCalcularMedia";
            BotaoDeCalcularMedia.Size = new System.Drawing.Size(130, 23);
            BotaoDeCalcularMedia.TabIndex = 8;
            BotaoDeCalcularMedia.Text = "Calcular Média";
            BotaoDeCalcularMedia.UseVisualStyleBackColor = true;
            BotaoDeCalcularMedia.Click += BotaoDeCalcularMedia_Click;
            // 
            // textBoxDoResultado
            // 
            textBoxDoResultado.Enabled = false;
            textBoxDoResultado.Location = new System.Drawing.Point(336, 323);
            textBoxDoResultado.Name = "textBoxDoResultado";
            textBoxDoResultado.Size = new System.Drawing.Size(100, 23);
            textBoxDoResultado.TabIndex = 9;
            // 
            // labelDoResultado
            // 
            labelDoResultado.AutoSize = true;
            labelDoResultado.Location = new System.Drawing.Point(272, 326);
            labelDoResultado.Name = "labelDoResultado";
            labelDoResultado.Size = new System.Drawing.Size(59, 15);
            labelDoResultado.TabIndex = 10;
            labelDoResultado.Text = "Resultado";
            // 
            // botaoLimpar
            // 
            botaoLimpar.Location = new System.Drawing.Point(348, 378);
            botaoLimpar.Name = "botaoLimpar";
            botaoLimpar.Size = new System.Drawing.Size(75, 23);
            botaoLimpar.TabIndex = 11;
            botaoLimpar.Text = "Limpar";
            botaoLimpar.UseVisualStyleBackColor = true;
            botaoLimpar.Click += BotaoLimpar_Click;
            // 
            // Questao01
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(776, 450);
            Controls.Add(botaoLimpar);
            Controls.Add(labelDoResultado);
            Controls.Add(textBoxDoResultado);
            Controls.Add(BotaoDeCalcularMedia);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxNota4);
            Controls.Add(textBoxNota3);
            Controls.Add(textBoxNota2);
            Controls.Add(textBoxNota1);
            Name = "Questao01";
            Text = "Questao01";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNota1;
        private System.Windows.Forms.TextBox textBoxNota2;
        private System.Windows.Forms.TextBox textBoxNota3;
        private System.Windows.Forms.TextBox textBoxNota4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BotaoDeCalcularMedia;
        private System.Windows.Forms.TextBox textBoxDoResultado;
        private System.Windows.Forms.Label labelDoResultado;
        private System.Windows.Forms.Button botaoLimpar;
    }
}