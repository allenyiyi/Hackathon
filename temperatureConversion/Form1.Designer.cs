namespace temperatureConversion
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
            CtoF = new RadioButton();
            FtoC = new RadioButton();
            panel1 = new Panel();
            num1 = new Button();
            num2 = new Button();
            num3 = new Button();
            num6 = new Button();
            num5 = new Button();
            num4 = new Button();
            num9 = new Button();
            num8 = new Button();
            num7 = new Button();
            dot = new Button();
            num0 = new Button();
            textBox1 = new TextBox();
            change = new Button();
            reset = new Button();
            result = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // CtoF
            // 
            CtoF.AutoSize = true;
            CtoF.Location = new Point(47, 17);
            CtoF.Name = "CtoF";
            CtoF.Size = new Size(109, 19);
            CtoF.TabIndex = 0;
            CtoF.TabStop = true;
            CtoF.Text = "攝氏轉換為華氏";
            CtoF.UseVisualStyleBackColor = true;
            // 
            // FtoC
            // 
            FtoC.AutoSize = true;
            FtoC.Location = new Point(47, 58);
            FtoC.Name = "FtoC";
            FtoC.Size = new Size(109, 19);
            FtoC.TabIndex = 1;
            FtoC.TabStop = true;
            FtoC.Text = "華氏轉換為攝氏";
            FtoC.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(CtoF);
            panel1.Controls.Add(FtoC);
            panel1.Location = new Point(63, 76);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 100);
            panel1.TabIndex = 2;
            // 
            // num1
            // 
            num1.Location = new Point(304, 76);
            num1.Name = "num1";
            num1.Size = new Size(40, 40);
            num1.TabIndex = 3;
            num1.Text = "1";
            num1.UseVisualStyleBackColor = true;
            num1.Click += Button_Click;
            // 
            // num2
            // 
            num2.Location = new Point(350, 76);
            num2.Name = "num2";
            num2.Size = new Size(40, 40);
            num2.TabIndex = 4;
            num2.Text = "2";
            num2.UseVisualStyleBackColor = true;
            num2.Click += Button_Click;
            // 
            // num3
            // 
            num3.Location = new Point(396, 76);
            num3.Name = "num3";
            num3.Size = new Size(40, 40);
            num3.TabIndex = 5;
            num3.Text = "3";
            num3.UseVisualStyleBackColor = true;
            num3.Click += Button_Click;
            // 
            // num6
            // 
            num6.Location = new Point(396, 124);
            num6.Name = "num6";
            num6.Size = new Size(40, 40);
            num6.TabIndex = 8;
            num6.Text = "6";
            num6.UseVisualStyleBackColor = true;
            num6.Click += Button_Click;
            // 
            // num5
            // 
            num5.Location = new Point(350, 124);
            num5.Name = "num5";
            num5.Size = new Size(40, 40);
            num5.TabIndex = 7;
            num5.Text = "5";
            num5.UseVisualStyleBackColor = true;
            num5.Click += Button_Click;
            // 
            // num4
            // 
            num4.Location = new Point(304, 124);
            num4.Name = "num4";
            num4.Size = new Size(40, 40);
            num4.TabIndex = 6;
            num4.Text = "4";
            num4.UseVisualStyleBackColor = true;
            num4.Click += Button_Click;
            // 
            // num9
            // 
            num9.Location = new Point(396, 170);
            num9.Name = "num9";
            num9.Size = new Size(40, 40);
            num9.TabIndex = 11;
            num9.Text = "9";
            num9.UseVisualStyleBackColor = true;
            num9.Click += Button_Click;
            // 
            // num8
            // 
            num8.Location = new Point(350, 170);
            num8.Name = "num8";
            num8.Size = new Size(40, 40);
            num8.TabIndex = 10;
            num8.Text = "8";
            num8.UseVisualStyleBackColor = true;
            num8.Click += Button_Click;
            // 
            // num7
            // 
            num7.Location = new Point(304, 170);
            num7.Name = "num7";
            num7.Size = new Size(40, 40);
            num7.TabIndex = 9;
            num7.Text = "7";
            num7.UseVisualStyleBackColor = true;
            num7.Click += Button_Click;
            // 
            // dot
            // 
            dot.Location = new Point(350, 216);
            dot.Name = "dot";
            dot.Size = new Size(40, 40);
            dot.TabIndex = 13;
            dot.Text = ".";
            dot.UseVisualStyleBackColor = true;
            dot.Click += Button_Click;
            // 
            // num0
            // 
            num0.Location = new Point(304, 216);
            num0.Name = "num0";
            num0.Size = new Size(40, 40);
            num0.TabIndex = 12;
            num0.Text = "0";
            num0.UseVisualStyleBackColor = true;
            num0.Click += Button_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(473, 124);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(277, 23);
            textBox1.TabIndex = 14;
            // 
            // change
            // 
            change.Location = new Point(473, 170);
            change.Name = "change";
            change.Size = new Size(75, 40);
            change.TabIndex = 15;
            change.Text = "轉換";
            change.UseVisualStyleBackColor = true;
            change.Click += change_Click;
            // 
            // reset
            // 
            reset.Location = new Point(554, 170);
            reset.Name = "reset";
            reset.Size = new Size(75, 40);
            reset.TabIndex = 16;
            reset.Text = "清除";
            reset.UseVisualStyleBackColor = true;
            reset.Click += reset_Click;
            // 
            // result
            // 
            result.AutoSize = true;
            result.Location = new Point(473, 241);
            result.Name = "result";
            result.Size = new Size(34, 15);
            result.TabIndex = 17;
            result.Text = "結果:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(result);
            Controls.Add(reset);
            Controls.Add(change);
            Controls.Add(textBox1);
            Controls.Add(dot);
            Controls.Add(num0);
            Controls.Add(num9);
            Controls.Add(num8);
            Controls.Add(num7);
            Controls.Add(num6);
            Controls.Add(num5);
            Controls.Add(num4);
            Controls.Add(num3);
            Controls.Add(num2);
            Controls.Add(num1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton CtoF;
        private RadioButton FtoC;
        private Panel panel1;
        private Button num1;
        private Button num2;
        private Button num3;
        private Button num6;
        private Button num5;
        private Button num4;
        private Button num9;
        private Button num8;
        private Button num7;
        private Button dot;
        private Button num0;
        private TextBox textBox1;
        private Button change;
        private Button reset;
        private Label result;
    }
}
