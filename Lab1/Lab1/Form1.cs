using System;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        const int MAX_COUNT_DOGS = 4;
        const int MAX_COUNT_GUYS = 3;

        Dog[] dogs = new Dog[MAX_COUNT_DOGS];
        Guy[] guys = new Guy[MAX_COUNT_GUYS];

        struct GuyInfo
        {
            public string Name { get; private set; }
            public int Cash { get; private set; }

            public void Set(string name, int cash)
            {
                Name = name;
                Cash = cash;
            }
        }

        GuyInfo[] guyInfos = new GuyInfo[MAX_COUNT_GUYS];

        public Form1()
        {
            InitializeComponent();
            InitializeGuys(MAX_COUNT_GUYS); // 플레이어 초기화
            InitializeDogs(MAX_COUNT_DOGS); // 개 초기화
            InitializeUI();// 배팅 전 레이스 버튼 비활성화
        }

        void LoadDB()
        {
            guyInfos[0].Set("Joe", 50);
            guyInfos[1].Set("Bob", 75);
            guyInfos[2].Set("Al", 75);
        }

        void InitializeUI()
        {
            RaceBtn.Enabled = false;
            MinBet_Info.Text = "Minimum Bet : " + (int)bucks.Minimum + " bucks";
        }

        void InitializeGuys(int maxCount)
        {
            Label[] labelGuys = new Label[] { GuyBet1, GuyBet2, GuyBet3 };
            RadioButton[] radioButtonsGuys = new RadioButton[] { GuyRadio1, GuyRadio2, GuyRadio3 };

            if (radioButtonsGuys.Length != maxCount || labelGuys.Length != maxCount)
                return;

            LoadDB();

            for (int i = 0; i < maxCount; i++)
            {
                guys[i] = new Guy()
                {
                    Cash = guyInfos[i].Cash,
                    Name = guyInfos[i].Name,
                    label = labelGuys[i],
                    radioButton = radioButtonsGuys[i]
                };
                guys[i].MyBet = new Bet(guys[i]);
                guys[i].UpdateLabels();
            }
        }

        void InitializeDogs(int maxCount)
        {
            PictureBox[] imageDogs = new PictureBox[] { Dog1, Dog2, Dog3, Dog4 };

            if (imageDogs.Length != maxCount)
                return;

            // 개 초기화
            int pos = 0;
            for (int i = 0; i < maxCount; i++)
            {
                dogs[i] = new Dog()
                {
                    RaceTrack = pictureBox1.Width,
                    StartPosX = pictureBox1.Location.X,
                    StartPosY = 12 + pos,
                    pictureBox = imageDogs[i]
                };
                pos += 50;
            }
            Dog.random = new Random();
        }

        void StartPlay()
        {
            // 경주시 모든 버튼 비활성화
            RaceBtn.Enabled = false;
            BetBtn.Enabled = false;

            bool win = false;

            while (!win)
            {
                pictureBox1.Refresh();
                System.Threading.Thread.Sleep(10); // 0.005초 단위로 루프 실행
                for (int i = 0; i < dogs.Length; i++)
                {
                    if (dogs[i].Run())
                    {
                        win = true;
                        FinishedGame(i);
                        break;
                    }
                }
            }
        }

        void FinishedGame(int winDogNum)
        {
            // 경기가 끝나면 메시지박스로 알리기
            MessageBox.Show("We have a winner - dog #" + (winDogNum + 1) + "!", "Race Over");

            // 배팅결과에 따른 돈 정산
            for (int i = 0; i < guys.Length; i++)
            {
                if (guys[i].MyBet.Amount >= bucks.Minimum && guys[i].Cash > 0)
                    guys[i].Collect(winDogNum + 1);
                guys[i].ClearBet();
            }

            // 개들을 시작점으로
            for (int i = 0; i < dogs.Length; i++)
            {
                dogs[i].TakeStartPos();
            }

            // bucks.Minimum++;
            bucks.Value = bucks.Minimum;
            dogNum.Value = dogNum.Minimum;
            GuyRadio1.Checked = true; // 1번 배팅자 버튼을 초기 선택 버튼으로 초기화

            BetBtn.Enabled = true;
            RaceBtn.Enabled = false;

            if (guys[0].Cash < bucks.Minimum && guys[1].Cash < bucks.Minimum && guys[2].Cash < bucks.Minimum)
            {
                MessageBox.Show("All Guys lost all their Money!", "Game Over");
                BetBtn.Enabled = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            selectName.Text = "Joe";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            selectName.Text = "Bob";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            selectName.Text = "Al";
        }

        private void Race_Click(object sender, EventArgs e)
        {
            StartPlay();
        }

        private void BetBtn_Click(object sender, EventArgs e)
        {
            bool chk = false;
            if (GuyRadio1.Checked) chk = guys[0].PlaceBet((int)bucks.Value, (int)dogNum.Value);
            if (GuyRadio2.Checked) chk = guys[1].PlaceBet((int)bucks.Value, (int)dogNum.Value);
            if (GuyRadio3.Checked) chk = guys[2].PlaceBet((int)bucks.Value, (int)dogNum.Value);

            if(chk)
            {
                RaceBtn.Enabled = true;
                bucks.Value = bucks.Minimum;
                dogNum.Value = dogNum.Minimum;
            }
            else
            {
                bucks.Value = bucks.Minimum;
                dogNum.Value = dogNum.Minimum;
            }
        }
    }
}
