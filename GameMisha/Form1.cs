namespace GameMisha
{
    public partial class Form1 : Form
    {
        public int money = 0;
        public int lvl = 0;
        public int Mistakes = 0;

        public Dictionary<string, List<string>> fruitsImages = new Dictionary<string, List<string>>() {
            ["bad"] = new List<string>() { "2.jpg" },
            ["good"] = new List<string> { "1.jpg"}
        };

        
        public Form1()
        {
            InitializeComponent();
            ShoeLvl();
            ShowMoney();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            GetFruits();
        }

        private void GetFruits() {
            PictureBox[] pictureBoxes = new PictureBox[] { pcb1, pcb2 };

            var idBadPcb = new Random().Next(0, pictureBoxes.Length);
            int idGoodPcb;

            switch (idBadPcb) {
                case 0:
                    idGoodPcb = 1;
                    break;
                case 1:
                    idGoodPcb = 0;
                    break;
                default:
                    idGoodPcb = 1;
                    idBadPcb = 0;
                    break;
            }

            var pcbGood = pictureBoxes[idGoodPcb];
            var pcbBad = pictureBoxes[idBadPcb];

            pcbBad.ImageLocation = $@"..\..\..\Images\Bad\{fruitsImages["bad"][new Random().Next(fruitsImages["bad"].Count)]}"; 
            pcbGood.ImageLocation = $@"..\..\..\Images\Good\{fruitsImages["good"][new Random().Next(fruitsImages["good"].Count)]}";
        }

        private void pcb1_Click(object sender, EventArgs e)
        {
            CheckAnswer(pcb1);
        }

        public void CheckAnswer(PictureBox pictureBox)
        {
            var type = pictureBox.ImageLocation.Split(@"\")[^2];

            switch (type)
            {
                case "Bad":
                    if (money >= 20)
                        money -= 20;
                    if (lvl > 0)
                        lvl--;
                    Mistakes++;
                    MessageBox.Show("BAD!");
                    break;
                case "Good":
                    money += 40;
                    lvl++;
                    break;
                default:
                    MessageBox.Show("Что-то пошло не так.");
                    break;
            }
            ShoeLvl();
            ShowMoney();
            CheckWin();
            GetFruits();
        }

        private void ShowMoney() => lblMoney.Text = money.ToString();
        private void ShoeLvl() => lblLvl.Text = lvl.ToString();
        private void CheckWin()
        {
            if (lvl == 11)
            {
                MessageBox.Show($"Победа!\nДеньги: {money}\nОшибок: {Mistakes}");
                lvl = 0;
                money = 0;
                Mistakes = 0;
                ShowMoney();
                ShoeLvl();
            }
        }

        private void pcb2_Click(object sender, EventArgs e)
        {
            CheckAnswer(pcb2);
        }
    }
}