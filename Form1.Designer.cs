namespace Analizador
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAnalizar = new System.Windows.Forms.Button();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.textBoxDetalles = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(48)))), ((int)(((byte)(56)))));
            this.label1.Location = new System.Drawing.Point(190, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(505, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "Analizador Léxico";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(48)))), ((int)(((byte)(56)))));
            this.label2.Location = new System.Drawing.Point(33, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresa la cadena a analizar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(48)))), ((int)(((byte)(56)))));
            this.label3.Location = new System.Drawing.Point(286, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(343, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Detalles de la cadena ingresada";
            // 
            // buttonAnalizar
            // 
            this.buttonAnalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(162)))), ((int)(((byte)(97)))));
            this.buttonAnalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAnalizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAnalizar.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAnalizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(48)))), ((int)(((byte)(56)))));
            this.buttonAnalizar.Location = new System.Drawing.Point(679, 135);
            this.buttonAnalizar.Name = "buttonAnalizar";
            this.buttonAnalizar.Size = new System.Drawing.Size(221, 74);
            this.buttonAnalizar.TabIndex = 3;
            this.buttonAnalizar.Text = "Analizar";
            this.buttonAnalizar.UseVisualStyleBackColor = false;
            // 
            // textBoxInput
            // 
            this.textBoxInput.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxInput.Location = new System.Drawing.Point(359, 155);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(270, 35);
            this.textBoxInput.TabIndex = 4;
            // 
            // textBoxDetalles
            // 
            this.textBoxDetalles.Enabled = false;
            this.textBoxDetalles.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDetalles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(48)))), ((int)(((byte)(56)))));
            this.textBoxDetalles.Location = new System.Drawing.Point(232, 322);
            this.textBoxDetalles.Multiline = true;
            this.textBoxDetalles.Name = "textBoxDetalles";
            this.textBoxDetalles.ReadOnly = true;
            this.textBoxDetalles.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxDetalles.Size = new System.Drawing.Size(450, 150);
            this.textBoxDetalles.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(157)))), ((int)(((byte)(143)))));
            this.ClientSize = new System.Drawing.Size(941, 494);
            this.Controls.Add(this.textBoxDetalles);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.buttonAnalizar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Analizador Léxico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonAnalizar;
        private TextBox textBoxInput;
        private TextBox textBoxDetalles;
    }
}