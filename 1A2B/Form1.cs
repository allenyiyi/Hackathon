using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace _1A2B
{
    public partial class Form1 : Form
    {
        private List<int> _ans;
        Random _rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {

            GenerateNewAnswer();
            start.Enabled = false;
            MessageBox.Show("�C���}�l�A�п�J4�ӼƦr");
        }

        private void see_ans_Click(object sender, EventArgs e)
        {
            if (_ans == null || start.Enabled == true)
            {
                MessageBox.Show("�Х��}�l�C��!");
                return;
            }
            else 
            {
                string ansText = string.Join("", _ans);
                MessageBox.Show($"���׬O: {ansText}");
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            if (start.Enabled == true)
            {
                MessageBox.Show("�Х��}�l�C��!");
                return;
            }
            else
            {
                reStart();
                MessageBox.Show("�w���s�}�l�C���A���פw��s�I");
            }
        }

        //Fisher�VYates Shuffle�t��k
        private void GenerateNewAnswer()
        {
            var num = Enumerable.Range(0, 10).ToList();
            for (int i = num.Count - 1; i > 0; i--)
            {
                int j = _rand.Next(i + 1);
                (num[i], num[j]) = (num[j], num[i]);
            }
            _ans = num.Take(4).ToList();
        }

        private void check_ans_Click(object sender, EventArgs e)
        {

            if (start.Enabled == true)
            {
                MessageBox.Show("�Х��}�l�C��!");
                return;
            }
            else if (input.Text.Length != 4 
                || !input.Text.All(char.IsDigit) 
                || input.Text.Distinct().Count()!=4)//���פ���4�A��J�D�Ʀr�A�קK���ƿ�J
            {
                MessageBox.Show("�Х��T����J4�Ӿ��!");
                return;
            }
            else
            {
                int A = 0;
                int B = 0;
                List<int> _input = input.Text.Select(x => int.Parse(x.ToString())).ToList();

                for (int i = 0; i < 4; i++)
                {
                    if (_input[i] == _ans[i])
                        A++;
                    else if (_ans.Contains(_input[i]))
                        B++;
                }
                answerSheet.Items.Add($"{input.Text} : {A}A{B}B");

                if (A == 4)
                {
                    MessageBox.Show("�L��");
                    reStart();
                }
                else 
                {
                    A = 0;
                    B = 0;
                }
            }
        }

        private void reStart()
        {
            _ans = null;
            input.Text = "";
            GenerateNewAnswer();
            answerSheet.Items.Clear();
        }
    }
}
