namespace FormsFrameworkClientApp
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSendTo = new System.Windows.Forms.Button();
            this.buttonGetFrom = new System.Windows.Forms.Button();
            this.textBoxStringFrom = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonSendTo
            // 
            this.buttonSendTo.Location = new System.Drawing.Point(12, 48);
            this.buttonSendTo.Name = "buttonSendTo";
            this.buttonSendTo.Size = new System.Drawing.Size(110, 23);
            this.buttonSendTo.TabIndex = 0;
            this.buttonSendTo.Text = "Send to server";
            this.buttonSendTo.UseVisualStyleBackColor = true;
            this.buttonSendTo.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonGetFrom
            // 
            this.buttonGetFrom.Location = new System.Drawing.Point(12, 77);
            this.buttonGetFrom.Name = "buttonGetFrom";
            this.buttonGetFrom.Size = new System.Drawing.Size(110, 23);
            this.buttonGetFrom.TabIndex = 1;
            this.buttonGetFrom.Text = "Get from server";
            this.buttonGetFrom.UseVisualStyleBackColor = true;
            this.buttonGetFrom.Click += new System.EventHandler(this.buttonGetFrom_Click);
            // 
            // textBoxStringFrom
            // 
            this.textBoxStringFrom.Location = new System.Drawing.Point(128, 79);
            this.textBoxStringFrom.Name = "textBoxStringFrom";
            this.textBoxStringFrom.Size = new System.Drawing.Size(100, 20);
            this.textBoxStringFrom.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxStringFrom);
            this.Controls.Add(this.buttonGetFrom);
            this.Controls.Add(this.buttonSendTo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSendTo;
        private System.Windows.Forms.Button buttonGetFrom;
        private System.Windows.Forms.TextBox textBoxStringFrom;
    }
}

