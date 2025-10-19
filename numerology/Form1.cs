namespace numerology
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> _lifeNumberDict = new Dictionary<string, string>();
        private List<Zodiac> _zodiacList;
        public Form1()
        {
            InitializeComponent();
            CreateList();
            LoadLifeNumbers("C:\\Users\\Allen\\Desktop\\build school\\C#\\HW\\Hackathon\\�ͩR�F��.txt");
        }


        private void result_btn_Click(object sender, EventArgs e)
        {
            DateTime birthDate = dateTimePicker1.Value;
            int lifeNumber = CalculateLifeNumber(birthDate);
            string zodiac = GetZodiac(birthDate);
            string description = GetDescription(zodiac, lifeNumber);

            description_label.Text = $"����A\n\n�A���P�y�O {zodiac}\n�A���ͩR�F�� {lifeNumber} : {description}";
        }

        private int CalculateLifeNumber(DateTime date)
        {
            int sum = date.Year + date.Month + date.Day;

            while (sum > 9)
            {
                int temp = 0;
                foreach (char c in sum.ToString())
                    temp += c - '0';
                sum = temp;
            }
            return sum;
        }

        private string GetZodiac(DateTime birthDate)
        {
            int month = birthDate.Month;
            int day = birthDate.Day;

            foreach (var z in _zodiacList)
            {
                if ((month == z.StartMonth && day >= z.StartDay) 
                    || (month == z.EndMonth && day <= z.EndDay)) 
                    return z.NameCN;
            }
            return "";
        }

        private string GetDescription(string zodiacCN, int lifeNumber)
        {
            var zodiac = _zodiacList.FirstOrDefault(z => z.NameCN == zodiacCN);
            string key = zodiac.Name+ lifeNumber.ToString();
            if (_lifeNumberDict.ContainsKey(key))
                return _lifeNumberDict[key];
            return "�䤣������F�ƴy�z";
        }


        private void LoadLifeNumbers(string filePath)
        {
            if (!File.Exists(filePath))
            {
                MessageBox.Show("�䤣�� LifeNumbers.txt �ɮסI");
                return;
            }

            string[] lines = File.ReadAllLines(filePath);
            string currentZodiac = "";

            foreach (string line in lines)
            {
                string text = line.Trim();
                if (text.StartsWith("�i") && text.Contains("�y"))
                {
                    int start = text.IndexOf('�i') + 1;//�i�b�r�ꤤ����m�A+1�O�h�����A��
                    int end = text.IndexOf('�j');//�j�b�r�ꤤ����m
                    currentZodiac = text.Substring(start, end - start).Trim();//�Ѽ�1:�_�l��m�A�Ѽ�2:���w����
                }
                else if (text.StartsWith("�ͩR�F��"))
                {
                    int colonIndex = text.IndexOf('�G');//:�b�r�ꤤ����m
                    if (colonIndex > 0)
                    {
                        string num = text.Substring(4, 1); // �ͩR�F�ƫ᭱�������ӼƦr
                        string key = currentZodiac + num;
                        string value = text.Substring(colonIndex + 1).Trim();//���o:���᪺�y�z
                        if (!_lifeNumberDict.ContainsKey(key))
                            _lifeNumberDict[key] = value;
                    }
                }
            }
        }

        private void CreateList()
        {
            _zodiacList = new List<Zodiac>
            {
                new Zodiac { Name="Aries�d�Ϯy Aries", NameCN="�d�Ϯy", StartMonth=3, StartDay=21, EndMonth=4, EndDay=19 },
                new Zodiac { Name="Taurus�����y Taurus", NameCN="�����y", StartMonth=4, StartDay=20, EndMonth=5, EndDay=20 },
                new Zodiac { Name="Gemini���l�y Gemini", NameCN="���l�y", StartMonth=5, StartDay=21, EndMonth=6, EndDay=20 },
                new Zodiac { Name="Cancer���ɮy Cancer", NameCN="���ɮy", StartMonth=6, StartDay=21, EndMonth=7, EndDay=22 },
                new Zodiac { Name="Leo��l�y Leo", NameCN="��l�y", StartMonth=7, StartDay=23, EndMonth=8, EndDay=22 },
                new Zodiac { Name="Virgo�B�k�y Virgo", NameCN="�B�k�y", StartMonth=8, StartDay=23, EndMonth=9, EndDay=22 },
                new Zodiac { Name="Libra�ѯ��y Libra", NameCN="�ѯ��y", StartMonth=9, StartDay=23, EndMonth=10, EndDay=22 },
                new Zodiac { Name="Scorpio���Ȯy Scorpio", NameCN="���Ȯy", StartMonth=10, StartDay=23, EndMonth=11, EndDay=21 },
                new Zodiac { Name="Sagittarius�g��y Sagittarius", NameCN="�g��y", StartMonth=11, StartDay=22, EndMonth=12, EndDay=21 },
                new Zodiac { Name="Capricorn���~�y Capricorn", NameCN="���~�y", StartMonth=12, StartDay=22, EndMonth=1, EndDay=19 },
                new Zodiac { Name="Aquarius���~�y Aquarius", NameCN="���~�y", StartMonth=1, StartDay=20, EndMonth=2, EndDay=18 },
                new Zodiac { Name="Pisces�����y Pisces", NameCN="�����y", StartMonth=2, StartDay=19, EndMonth=3, EndDay=20 }
            };
        }
    }
}
