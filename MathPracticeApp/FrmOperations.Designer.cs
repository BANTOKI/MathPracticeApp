namespace MathPracticeApp
{
    partial class FrmOperations
    {
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

        private void InitializeComponent()
        {
            lblGrade = new Label();
            cboGrade = new ComboBox();
            btnGenerate = new Button();
            lblNum1 = new Label();
            lblNum2 = new Label();
            lblOperator = new Label();
            txtOperator = new TextBox();
            lblQuestion = new Label();
            lblAnswer = new Label();
            lblQuestion1 = new Label();
            lblAnswer1 = new Label();
            txtAnswer = new TextBox();
            btnCheck = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblGrade
            // 
            lblGrade.AutoSize = true;
            lblGrade.Location = new Point(26, 22);
            lblGrade.Name = "lblGrade";
            lblGrade.Size = new Size(72, 15);
            lblGrade.TabIndex = 0;
            lblGrade.Text = "Select Grade";
            // 
            // cboGrade
            // 
            cboGrade.FormattingEnabled = true;
            cboGrade.Items.AddRange(new object[] { "Grade 1", "Grade 2", "Grade 3" });
            cboGrade.Location = new Point(118, 19);
            cboGrade.Name = "cboGrade";
            cboGrade.Size = new Size(137, 23);
            cboGrade.TabIndex = 1;
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = SystemColors.ButtonHighlight;
            btnGenerate.Location = new Point(127, 60);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(117, 45);
            btnGenerate.TabIndex = 2;
            btnGenerate.Text = "Generate Random Numbers";
            btnGenerate.UseVisualStyleBackColor = false;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // lblNum1
            // 
            lblNum1.AutoSize = true;
            lblNum1.Location = new Point(26, 115);
            lblNum1.Name = "lblNum1";
            lblNum1.Size = new Size(40, 15);
            lblNum1.TabIndex = 3;
            lblNum1.Text = "Num1";
            // 
            // lblNum2
            // 
            lblNum2.AutoSize = true;
            lblNum2.Location = new Point(26, 146);
            lblNum2.Name = "lblNum2";
            lblNum2.Size = new Size(40, 15);
            lblNum2.TabIndex = 4;
            lblNum2.Text = "Num2";
            // 
            // lblOperator
            // 
            lblOperator.AutoSize = true;
            lblOperator.Location = new Point(26, 180);
            lblOperator.Name = "lblOperator";
            lblOperator.Size = new Size(54, 15);
            lblOperator.TabIndex = 5;
            lblOperator.Text = "Operator";
            // 
            // txtOperator
            // 
            txtOperator.Location = new Point(97, 177);
            txtOperator.Name = "txtOperator";
            txtOperator.Size = new Size(158, 23);
            txtOperator.TabIndex = 6;
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Location = new Point(28, 236);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(0, 15);
            lblQuestion.TabIndex = 7;
            // 
            // lblAnswer
            // 
            lblAnswer.AutoSize = true;
            lblAnswer.Location = new Point(41, 281);
            lblAnswer.Name = "lblAnswer";
            lblAnswer.Size = new Size(0, 15);
            lblAnswer.TabIndex = 8;
            // 
            // lblQuestion1
            // 
            lblQuestion1.AutoSize = true;
            lblQuestion1.Location = new Point(139, 217);
            lblQuestion1.Name = "lblQuestion1";
            lblQuestion1.Size = new Size(55, 15);
            lblQuestion1.TabIndex = 9;
            lblQuestion1.Text = "Question";
            // 
            // lblAnswer1
            // 
            lblAnswer1.AutoSize = true;
            lblAnswer1.Location = new Point(29, 272);
            lblAnswer1.Name = "lblAnswer1";
            lblAnswer1.Size = new Size(46, 15);
            lblAnswer1.TabIndex = 10;
            lblAnswer1.Text = "Answer";
            // 
            // txtAnswer
            // 
            txtAnswer.BackColor = SystemColors.InactiveBorder;
            txtAnswer.Location = new Point(86, 269);
            txtAnswer.Name = "txtAnswer";
            txtAnswer.Size = new Size(169, 23);
            txtAnswer.TabIndex = 11;
            // 
            // btnCheck
            // 
            btnCheck.BackColor = SystemColors.ActiveCaption;
            btnCheck.Location = new Point(29, 351);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(136, 23);
            btnCheck.TabIndex = 12;
            btnCheck.Text = "Check Answer";
            btnCheck.UseVisualStyleBackColor = false;
            btnCheck.Click += btnCheck_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.Info;
            btnExit.Location = new Point(306, 347);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(127, 27);
            btnExit.TabIndex = 13;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // FrmOperations
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(547, 467);
            Controls.Add(btnExit);
            Controls.Add(btnCheck);
            Controls.Add(txtAnswer);
            Controls.Add(lblAnswer1);
            Controls.Add(lblQuestion1);
            Controls.Add(lblAnswer);
            Controls.Add(lblQuestion);
            Controls.Add(txtOperator);
            Controls.Add(lblOperator);
            Controls.Add(lblNum2);
            Controls.Add(lblNum1);
            Controls.Add(btnGenerate);
            Controls.Add(cboGrade);
            Controls.Add(lblGrade);
            Name = "FrmOperations";
            Text = "FrmOperations";
            Load += FrmOperations_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGrade;
        private ComboBox cboGrade;
        private Button btnGenerate;
        private Label lblNum1;
        private Label lblNum2;
        private Label lblOperator;
        private TextBox txtOperator;
        private Label lblQuestion;
        private Label lblAnswer;
        private Label lblQuestion1;
        private Label lblAnswer1;
        private TextBox txtAnswer;
        private Button btnCheck;
        private Button btnExit;
    }
}
