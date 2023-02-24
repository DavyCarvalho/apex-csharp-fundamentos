namespace WinFormsValidacoes
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            botaoEnviar = new System.Windows.Forms.Button();
            textBox1 = new System.Windows.Forms.TextBox();
            labelDoTextBox = new System.Windows.Forms.Label();
            labelDeErro = new System.Windows.Forms.Label();
            labelDeSucesso = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            comboBox1 = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // botaoEnviar
            // 
            botaoEnviar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            botaoEnviar.Location = new System.Drawing.Point(137, 146);
            botaoEnviar.Name = "botaoEnviar";
            botaoEnviar.Size = new System.Drawing.Size(75, 23);
            botaoEnviar.TabIndex = 0;
            botaoEnviar.Text = "Enviar";
            botaoEnviar.UseVisualStyleBackColor = false;
            botaoEnviar.Click += BotaoEnviar_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(137, 7);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(100, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox_TextChanged;
            textBox1.Leave += textBox_Leave;
            // 
            // labelDoTextBox
            // 
            labelDoTextBox.AutoSize = true;
            labelDoTextBox.Location = new System.Drawing.Point(80, 10);
            labelDoTextBox.Name = "labelDoTextBox";
            labelDoTextBox.Size = new System.Drawing.Size(51, 15);
            labelDoTextBox.TabIndex = 2;
            labelDoTextBox.Text = "TextBox:";
            // 
            // labelDeErro
            // 
            labelDeErro.AutoSize = true;
            labelDeErro.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelDeErro.ForeColor = System.Drawing.Color.IndianRed;
            labelDeErro.Location = new System.Drawing.Point(153, 172);
            labelDeErro.Name = "labelDeErro";
            labelDeErro.Size = new System.Drawing.Size(33, 17);
            labelDeErro.TabIndex = 3;
            labelDeErro.Text = "Erro";
            labelDeErro.Visible = false;
            // 
            // labelDeSucesso
            // 
            labelDeSucesso.AutoSize = true;
            labelDeSucesso.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelDeSucesso.ForeColor = System.Drawing.Color.OliveDrab;
            labelDeSucesso.Location = new System.Drawing.Point(137, 172);
            labelDeSucesso.Name = "labelDeSucesso";
            labelDeSucesso.Size = new System.Drawing.Size(56, 17);
            labelDeSucesso.TabIndex = 4;
            labelDeSucesso.Text = "Sucesso";
            labelDeSucesso.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(61, 40);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(70, 15);
            label1.TabIndex = 6;
            label1.Text = "ComboBox:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Opção 1", "Opção 2", "Opção 3" });
            comboBox1.Location = new System.Drawing.Point(137, 36);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(121, 23);
            comboBox1.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(39, 71);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(92, 15);
            label2.TabIndex = 8;
            label2.Text = "DateTimePicker:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(29, 94);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(102, 15);
            label3.TabIndex = 9;
            label3.Text = "NumericUpDown:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dateTimePicker1.Location = new System.Drawing.Point(137, 65);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            dateTimePicker1.TabIndex = 10;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new System.Drawing.Point(137, 92);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new System.Drawing.Size(120, 23);
            numericUpDown1.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ActiveBorder;
            ClientSize = new System.Drawing.Size(350, 206);
            Controls.Add(numericUpDown1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(labelDeSucesso);
            Controls.Add(labelDeErro);
            Controls.Add(labelDoTextBox);
            Controls.Add(textBox1);
            Controls.Add(botaoEnviar);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button botaoEnviar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelDoTextBox;
        private System.Windows.Forms.Label labelDeErro;
        private System.Windows.Forms.Label labelDeSucesso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}
