namespace MathPracticeApp
{
    partial class FrmLogin
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
            lblDob = new Label();
            dtpDOB = new DateTimePicker();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // lblDob
            // 
            lblDob.AutoSize = true;
            lblDob.Location = new Point(187, 53);
            lblDob.Name = "lblDob";
            lblDob.Size = new Size(123, 15);
            lblDob.TabIndex = 0;
            lblDob.Text = "ENTER DATE OF BIRTH";
            // 
            // dtpDOB
            // 
            dtpDOB.Location = new Point(164, 97);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(196, 23);
            dtpDOB.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(187, 158);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(134, 26);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click1;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(569, 496);
            Controls.Add(btnLogin);
            Controls.Add(dtpDOB);
            Controls.Add(lblDob);
            Name = "FrmLogin";
            Text = "FrmLogin";
            Load += FrmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDob;
        private DateTimePicker dtpDOB;
        private Button btnLogin;
    }
}
