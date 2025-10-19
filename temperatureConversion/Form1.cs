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
                result.Text = $"���G: {input}�J = {F.ToString()}�XF";
            }
            else
            {
                double C = (input - 32) * (5.0 / 9);
                result.Text = $"���G: {input}�XF = {C.ToString()}�J";
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
                // 1. TextBox ���šA�����J dot
                if (string.IsNullOrEmpty(currentText))
                    return;

                // 2. TextBox �w�g�� dot�A�]����A��J dot
                if (currentText.Contains("."))
                    return;

                // ��L���p�i�H��J dot
                textBox1.Text += ".";
            }
            else
            {
                // �Ʀr���s�����[�� TextBox
                textBox1.Text += btn.Text;
            }
        }
    }
}
