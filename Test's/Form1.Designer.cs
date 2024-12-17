namespace Test_s
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
            Question = new Label();
            Result = new Label();
            Answer = new TextBox();
            SuspendLayout();
            // 
            // Question
            // 
            Question.BackColor = SystemColors.Desktop;
            Question.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Question.ForeColor = SystemColors.MenuHighlight;
            Question.Location = new Point(280, 115);
            Question.Name = "Question";
            Question.Size = new Size(274, 50);
            Question.TabIndex = 0;
            Question.Text = "Question";
            Question.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Result
            // 
            Result.AutoSize = true;
            Result.BackColor = SystemColors.ButtonFace;
            Result.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Result.Location = new Point(280, 100);
            Result.Name = "Result";
            Result.Size = new Size(155, 65);
            Result.TabIndex = 1;
            Result.Text = "label2";
            Result.Visible = false;
            Result.Click += Result_Click;
            // 
            // Answer
            // 
            Answer.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Answer.Location = new Point(280, 192);
            Answer.Name = "Answer";
            Answer.Size = new Size(100, 71);
            Answer.TabIndex = 2;
            Answer.KeyDown += Answer_KeyDown;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(948, 566);
            Controls.Add(Answer);
            Controls.Add(Result);
            Controls.Add(Question);
            Name = "Form1";
            Text = "Form1";
            Load += Question_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Question;
        private Label Result;
        private TextBox Answer;
    }
}
