namespace _1A2B
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
            start = new Button();
            see_ans = new Button();
            check_ans = new Button();
            reset = new Button();
            input = new TextBox();
            label1 = new Label();
            answerSheet = new ListBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // start
            // 
            start.Location = new Point(158, 45);
            start.Name = "start";
            start.Size = new Size(80, 40);
            start.TabIndex = 0;
            start.Text = "開始遊戲";
            start.UseVisualStyleBackColor = true;
            start.Click += start_Click;
            // 
            // see_ans
            // 
            see_ans.Location = new Point(158, 139);
            see_ans.Name = "see_ans";
            see_ans.Size = new Size(80, 40);
            see_ans.TabIndex = 1;
            see_ans.Text = "看答案";
            see_ans.UseVisualStyleBackColor = true;
            see_ans.Click += see_ans_Click;
            // 
            // check_ans
            // 
            check_ans.Location = new Point(158, 333);
            check_ans.Name = "check_ans";
            check_ans.Size = new Size(80, 40);
            check_ans.TabIndex = 2;
            check_ans.Text = "檢查答案";
            check_ans.UseVisualStyleBackColor = true;
            check_ans.Click += check_ans_Click;
            // 
            // reset
            // 
            reset.Location = new Point(262, 333);
            reset.Name = "reset";
            reset.Size = new Size(80, 40);
            reset.TabIndex = 3;
            reset.Text = "放棄重來";
            reset.UseVisualStyleBackColor = true;
            reset.Click += reset_Click;
            // 
            // input
            // 
            input.Location = new Point(158, 284);
            input.Name = "input";
            input.Size = new Size(184, 23);
            input.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(158, 255);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 5;
            label1.Text = "輸入";
            // 
            // answerSheet
            // 
            answerSheet.FormattingEnabled = true;
            answerSheet.Location = new Point(419, 57);
            answerSheet.Name = "answerSheet";
            answerSheet.Size = new Size(220, 319);
            answerSheet.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(419, 39);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 7;
            label2.Text = "遊戲歷程";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(answerSheet);
            Controls.Add(label1);
            Controls.Add(input);
            Controls.Add(reset);
            Controls.Add(check_ans);
            Controls.Add(see_ans);
            Controls.Add(start);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button start;
        private Button see_ans;
        private Button check_ans;
        private Button reset;
        private TextBox input;
        private Label label1;
        private ListBox answerSheet;
        private Label label2;
    }
}
