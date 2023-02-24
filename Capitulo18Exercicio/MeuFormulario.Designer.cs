namespace Capitulo18Exercicio
{
    partial class MeuFormulario
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
            PainelUm = new System.Windows.Forms.Panel();
            NumericUpDownUm = new System.Windows.Forms.NumericUpDown();
            ComboBoxUm = new System.Windows.Forms.ComboBox();
            BotaoUm = new System.Windows.Forms.Button();
            VisualizadorDeDadosUm = new System.Windows.Forms.DataGridView();
            SelecionadorDeDataUm = new System.Windows.Forms.DateTimePicker();
            LabelUm = new System.Windows.Forms.Label();
            CaixaDeTextoUm = new System.Windows.Forms.TextBox();
            PainelUm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownUm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)VisualizadorDeDadosUm).BeginInit();
            SuspendLayout();
            // 
            // PainelUm
            // 
            PainelUm.Controls.Add(NumericUpDownUm);
            PainelUm.Controls.Add(ComboBoxUm);
            PainelUm.Controls.Add(BotaoUm);
            PainelUm.Controls.Add(VisualizadorDeDadosUm);
            PainelUm.Controls.Add(SelecionadorDeDataUm);
            PainelUm.Controls.Add(LabelUm);
            PainelUm.Controls.Add(CaixaDeTextoUm);
            PainelUm.Location = new System.Drawing.Point(108, 62);
            PainelUm.Name = "PainelUm";
            PainelUm.Size = new System.Drawing.Size(583, 315);
            PainelUm.TabIndex = 0;
            // 
            // NumericUpDownUm
            // 
            NumericUpDownUm.Location = new System.Drawing.Point(22, 151);
            NumericUpDownUm.Name = "NumericUpDownUm";
            NumericUpDownUm.Size = new System.Drawing.Size(200, 23);
            NumericUpDownUm.TabIndex = 6;
            // 
            // ComboBoxUm
            // 
            ComboBoxUm.FormattingEnabled = true;
            ComboBoxUm.Location = new System.Drawing.Point(22, 111);
            ComboBoxUm.Name = "ComboBoxUm";
            ComboBoxUm.Size = new System.Drawing.Size(200, 23);
            ComboBoxUm.TabIndex = 5;
            // 
            // BotaoUm
            // 
            BotaoUm.Location = new System.Drawing.Point(240, 128);
            BotaoUm.Name = "BotaoUm";
            BotaoUm.Size = new System.Drawing.Size(94, 34);
            BotaoUm.TabIndex = 4;
            BotaoUm.Text = "PrimeiroBotão";
            BotaoUm.UseVisualStyleBackColor = true;
            BotaoUm.Click += BotaoUm_Click;
            // 
            // VisualizadorDeDadosUm
            // 
            VisualizadorDeDadosUm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            VisualizadorDeDadosUm.Location = new System.Drawing.Point(361, 29);
            VisualizadorDeDadosUm.Name = "VisualizadorDeDadosUm";
            VisualizadorDeDadosUm.RowTemplate.Height = 25;
            VisualizadorDeDadosUm.Size = new System.Drawing.Size(198, 265);
            VisualizadorDeDadosUm.TabIndex = 3;
            // 
            // SelecionadorDeDataUm
            // 
            SelecionadorDeDataUm.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            SelecionadorDeDataUm.Location = new System.Drawing.Point(22, 68);
            SelecionadorDeDataUm.Name = "SelecionadorDeDataUm";
            SelecionadorDeDataUm.Size = new System.Drawing.Size(200, 23);
            SelecionadorDeDataUm.TabIndex = 2;
            // 
            // LabelUm
            // 
            LabelUm.AutoSize = true;
            LabelUm.Location = new System.Drawing.Point(22, 11);
            LabelUm.Name = "LabelUm";
            LabelUm.Size = new System.Drawing.Size(82, 15);
            LabelUm.TabIndex = 1;
            LabelUm.Text = "Primeira Label";
            // 
            // CaixaDeTextoUm
            // 
            CaixaDeTextoUm.Location = new System.Drawing.Point(22, 29);
            CaixaDeTextoUm.Name = "CaixaDeTextoUm";
            CaixaDeTextoUm.Size = new System.Drawing.Size(200, 23);
            CaixaDeTextoUm.TabIndex = 0;
            // 
            // MeuFormulario
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(PainelUm);
            Name = "MeuFormulario";
            Text = "MeuFormulario";
            PainelUm.ResumeLayout(false);
            PainelUm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownUm).EndInit();
            ((System.ComponentModel.ISupportInitialize)VisualizadorDeDadosUm).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel PainelUm;
        private System.Windows.Forms.Label LabelUm;
        private System.Windows.Forms.TextBox CaixaDeTextoUm;
        private System.Windows.Forms.DataGridView VisualizadorDeDadosUm;
        private System.Windows.Forms.DateTimePicker SelecionadorDeDataUm;
        private System.Windows.Forms.Button BotaoUm;
        private System.Windows.Forms.ComboBox ComboBoxUm;
        private System.Windows.Forms.NumericUpDown NumericUpDownUm;
    }
}