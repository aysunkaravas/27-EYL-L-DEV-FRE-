namespace _27_EYLÜL_ÖDEV_ŞİFRE_
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
            lblsifreKontrol = new Label();
            textSifreGir = new TextBox();
            SuspendLayout();
            // 
            // lblsifreKontrol
            // 
            lblsifreKontrol.AutoSize = true;
            lblsifreKontrol.Location = new Point(201, 163);
            lblsifreKontrol.Name = "lblsifreKontrol";
            lblsifreKontrol.Size = new Size(153, 20);
            lblsifreKontrol.TabIndex = 0;
            lblsifreKontrol.Text = "------------------------";
            // 
            // textSifreGir
            // 
            textSifreGir.Location = new Point(201, 102);
            textSifreGir.Name = "textSifreGir";
            textSifreGir.Size = new Size(346, 27);
            textSifreGir.TabIndex = 1;
            textSifreGir.TextChanged += textSifreGir_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textSifreGir);
            Controls.Add(lblsifreKontrol);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblsifreKontrol;
        private TextBox textSifreGir;
    }
}