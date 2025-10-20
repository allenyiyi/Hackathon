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
            LoadLifeNumbers("生命靈數.txt");
        }


        private void result_btn_Click(object sender, EventArgs e)
        {
            DateTime birthDate = dateTimePicker1.Value;
            int lifeNumber = CalculateLifeNumber(birthDate);
            string zodiac = GetZodiac(birthDate);
            string description = GetDescription(zodiac, lifeNumber);

            description_label.Text = $"關於你\n\n你的星座是 {zodiac}\n你的生命靈數 {lifeNumber} : {description}";
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
            return "找不到對應靈數描述";
        }


        private void LoadLifeNumbers(string filePath)
        {
            if (!File.Exists(filePath))
            {
                MessageBox.Show("找不到 LifeNumbers.txt 檔案！");
                return;
            }

            string[] lines = File.ReadAllLines(filePath);
            string currentZodiac = "";

            foreach (string line in lines)
            {
                string text = line.Trim();
                if (text.StartsWith("【") && text.Contains("座"))
                {
                    int start = text.IndexOf('【') + 1;//【在字串中的位置，+1是去掉左括號
                    int end = text.IndexOf('】');//】在字串中的位置
                    currentZodiac = text.Substring(start, end - start).Trim();//參數1:起始位置，參數2:指定長度
                }
                else if (text.StartsWith("生命靈數"))
                {
                    int colonIndex = text.IndexOf('：');//:在字串中的位置
                    if (colonIndex > 0)
                    {
                        string num = text.Substring(4, 1); // 生命靈數後面接的那個數字
                        string key = currentZodiac + num;
                        string value = text.Substring(colonIndex + 1).Trim();//取得:之後的描述
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
                new Zodiac { Name="Aries牡羊座 Aries", NameCN="牡羊座", StartMonth=3, StartDay=21, EndMonth=4, EndDay=19 },
                new Zodiac { Name="Taurus金牛座 Taurus", NameCN="金牛座", StartMonth=4, StartDay=20, EndMonth=5, EndDay=20 },
                new Zodiac { Name="Gemini雙子座 Gemini", NameCN="雙子座", StartMonth=5, StartDay=21, EndMonth=6, EndDay=20 },
                new Zodiac { Name="Cancer巨蟹座 Cancer", NameCN="巨蟹座", StartMonth=6, StartDay=21, EndMonth=7, EndDay=22 },
                new Zodiac { Name="Leo獅子座 Leo", NameCN="獅子座", StartMonth=7, StartDay=23, EndMonth=8, EndDay=22 },
                new Zodiac { Name="Virgo處女座 Virgo", NameCN="處女座", StartMonth=8, StartDay=23, EndMonth=9, EndDay=22 },
                new Zodiac { Name="Libra天秤座 Libra", NameCN="天秤座", StartMonth=9, StartDay=23, EndMonth=10, EndDay=22 },
                new Zodiac { Name="Scorpio天蠍座 Scorpio", NameCN="天蠍座", StartMonth=10, StartDay=23, EndMonth=11, EndDay=21 },
                new Zodiac { Name="Sagittarius射手座 Sagittarius", NameCN="射手座", StartMonth=11, StartDay=22, EndMonth=12, EndDay=21 },
                new Zodiac { Name="Capricorn摩羯座 Capricorn", NameCN="摩羯座", StartMonth=12, StartDay=22, EndMonth=1, EndDay=19 },
                new Zodiac { Name="Aquarius水瓶座 Aquarius", NameCN="水瓶座", StartMonth=1, StartDay=20, EndMonth=2, EndDay=18 },
                new Zodiac { Name="Pisces雙魚座 Pisces", NameCN="雙魚座", StartMonth=2, StartDay=19, EndMonth=3, EndDay=20 }
            };
        }
    }
}
