namespace numerology
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
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            result_btn = new Button();
            description_label = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 52);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 0;
            label1.Text = "請選擇生日";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(84, 98);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(213, 23);
            dateTimePicker1.TabIndex = 1;
            // 
            // result_btn
            // 
            result_btn.Location = new Point(84, 191);
            result_btn.Name = "result_btn";
            result_btn.Size = new Size(104, 60);
            result_btn.TabIndex = 2;
            result_btn.Text = "分析結果";
            result_btn.UseVisualStyleBackColor = true;
            result_btn.Click += result_btn_Click;
            // 
            // description_label
            // 
            description_label.AutoSize = true;
            description_label.Location = new Point(428, 52);
            description_label.Name = "description_label";
            description_label.Size = new Size(0, 15);
            description_label.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(description_label);
            Controls.Add(result_btn);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Button result_btn;
        private Label description_label;
    }
}
