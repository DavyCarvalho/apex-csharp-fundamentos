namespace Capitulo22
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
            botaoAbrirForm2 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // botaoAbrirForm2
            // 
            botaoAbrirForm2.Location = new System.Drawing.Point(285, 165);
            botaoAbrirForm2.Name = "botaoAbrirForm2";
            botaoAbrirForm2.Size = new System.Drawing.Size(212, 84);
            botaoAbrirForm2.TabIndex = 0;
            botaoAbrirForm2.Text = "AbrirForm2";
            botaoAbrirForm2.UseVisualStyleBackColor = true;
            botaoAbrirForm2.Click += botaoAbrirForm2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(botaoAbrirForm2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button botaoAbrirForm2;
    }
}
