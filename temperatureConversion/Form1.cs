using System;

namespace temperatureConversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void change_Click(object sender, EventArgs e)
        {
            var input = double.Parse(textBox1.Text);
            if (CtoF.Checked == true)
            {
                double F = (9.0 / 5) * input + 32;
                result.Text = $"結果: {input}℃ = {F.ToString()}°F";
            }
            else
            {
                double C = (input - 32) * (5.0 / 9);
                result.Text = $"結果: {input}°F = {C.ToString()}℃";
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            result.Text = "";
            textBox1.Focus();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            string currentText = textBox1.Text;

            if (btn.Text == ".")
            {
                // 1. TextBox 為空，不能輸入 dot
                if (string.IsNullOrEmpty(currentText))
                    return;

                // 2. TextBox 已經有 dot，也不能再輸入 dot
                if (currentText.Contains("."))
                    return;

                // 其他情況可以輸入 dot
                textBox1.Text += ".";
            }
            else
            {
                // 數字按鈕直接加到 TextBox
                textBox1.Text += btn.Text;
            }
        }
    }
}
