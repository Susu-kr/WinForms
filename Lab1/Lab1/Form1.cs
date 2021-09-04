using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        Dog[] dogs = new Dog[4];
        Guy[] guys = new Guy[3];

        public Form1()
        {
            InitializeComponent();

            // 사람 초기화
            guys[0] = new Guy() { Cash = 50, Name = "Joe", MyBet = new Bet(), label = GuyBet1, radioButton = GuyRadio1 };
            guys[1] = new Guy() { Cash = 75, Name = "Bob", MyBet = new Bet(), label = GuyBet2, radioButton = GuyRadio2 };
            guys[2] = new Guy() { Cash = 45, Name = "Al", MyBet = new Bet(), label = GuyBet3, radioButton = GuyRadio3 };

            for(int i = 0; i < guys.Length; i++)
            {
                guys[i].MyBet.Amount = 0;
                guys[i].MyBet.DogNum = 0;
                guys[i].MyBet.Bettor = guys[i];
                guys[i].UpdateLabels();
            }

            // 개 초기화
            int pos = 0;
            for(int i = 0; i < dogs.Length; i++)
            {
                dogs[i] = new Dog();
                dogs[i].RaceTrack = pictureBox1.Width;
                dogs[i].StartPosX = pictureBox1.Location.X;
                dogs[i].StartPosY = 12 + pos;
                dogs[i].random = new Random();
                dogs[i].distance = random.Next(4) + 1; // 랜덤 거리 1 ~ 4 생성, 초당 이동거리
                pos += 50;
            }

            Dog1.BackColor = Color.Transparent;
            Dog2.BackColor = Color.Transparent;
            Dog3.BackColor = Color.Transparent;
            Dog4.BackColor = Color.Transparent;

            dogs[0].pictureBox = Dog1;
            dogs[1].pictureBox = Dog2;
            dogs[2].pictureBox = Dog3;
            dogs[3].pictureBox = Dog4;

            // 배팅 전 레이스 버튼 비활성화
            RaceBtn.Enabled = false;

            MinBet_Info.Text = "Minimum Bet : " + (int)bucks.Minimum + " bucks";

        }

        private void Race_Click(object sender, EventArgs e)
        {
            // 경주시 모든 버튼 비활성화
            RaceBtn.Enabled = false;
            BetBtn.Enabled = false;

            bool win = false;
            int winDogNum = 0;

            while(!win)
            {
                for(int i = 0; i < dogs.Length; i++)
                {
                    if(dogs[i].Run())
                    {
                        win = true;
                        winDogNum = i;
                    }
                }
                System.Threading.Thread.Sleep(10); // 0.005초 단위로 루프 실행
            }

            // 경기가 끝나면 메시지박스로 알리기
            MessageBox.Show("We have a winner - dog #" + (winDogNum + 1) + "!", "Race Over");

            // 배팅결과에 따른 돈 정산
            for(int i = 0; i < guys.Length; i++)
            {
                if (guys[i].MyBet.Amount >= bucks.Minimum && guys[i].Cash > 0)
                    guys[i].Collect(winDogNum + 1);
                guys[i].ClearBet();
            }

            // 개들을 시작점으로
            for(int i = 0; i < dogs.Length; i++)
            {
                dogs[i].TakeStartPos();
                dogs[i].distance = random.Next(4)+1;
            }

            // bucks.Minimum++;
            bucks.Value = bucks.Minimum;
            dogNum.Value = dogNum.Minimum;
            GuyRadio1.Checked = true; // 1번 배팅자 버튼을 초기 선택 버튼으로 초기화

            BetBtn.Enabled = true;
            RaceBtn.Enabled = false;

            if(guys[0].Cash < bucks.Minimum && guys[1].Cash < bucks.Minimum && guys[2].Cash < bucks.Minimum)
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

        private void BetBtn_Click(object sender, EventArgs e)
        {
            bool chk = false;
            if(GuyRadio1.Checked)
                chk = guys[0].PlaceBet((int)bucks.Value, (int)dogNum.Value);
            if (GuyRadio2.Checked)
                chk = guys[1].PlaceBet((int)bucks.Value, (int)dogNum.Value);
            if (GuyRadio3.Checked)
                chk = guys[2].PlaceBet((int)bucks.Value, (int)dogNum.Value);

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
