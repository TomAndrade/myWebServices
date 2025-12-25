namespace FormsClientApp
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
            buttonGetFromTheServer = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // buttonGetFromTheServer
            // 
            buttonGetFromTheServer.Location = new Point(52, 90);
            buttonGetFromTheServer.Name = "buttonGetFromTheServer";
            buttonGetFromTheServer.Size = new Size(145, 23);
            buttonGetFromTheServer.TabIndex = 0;
            buttonGetFromTheServer.Text = "Get from the server";
            buttonGetFromTheServer.UseVisualStyleBackColor = true;
            buttonGetFromTheServer.Click += buttonGetFromTheServer_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 61);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(243, 23);
            textBox1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(267, 159);
            Controls.Add(textBox1);
            Controls.Add(buttonGetFromTheServer);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonGetFromTheServer;
        private TextBox textBox1;
    }
}
