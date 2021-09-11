using System.Windows.Forms;

namespace Lab1
{
    public class Guy
    {
        public string Name; // 사람 이름
        public Bet MyBet; // Bet()의 인스턴스
        public int Cash; // 갖고있는 돈

        public RadioButton radioButton;
        public Label label;

        // 텍스트 변경
        public void UpdateLabels()
        {
            radioButton.Text = this.Name + " has " + this.Cash + " bucks";
            label.Text = this.MyBet.GetDescription();
        }

        // 배팅 초기화
        public void ClearBet()
        {
            MyBet.Amount = 0;
            radioButton.Text = this.Name + " has " + this.Cash + " bucks";
            label.Text = this.Name + " hasn't placed a bet";
        }

        // 배팅하기
        public bool PlaceBet(int amount, int dog)
        {
            MyBet = new Bet(this) { Amount = amount, DogNum = dog };
            if(this.Cash > MyBet.Amount)
            {
                this.UpdateLabels();
                return true;
            }
            else return false;
        }

        // 경주 후 합계 금액
        public void Collect(int Winner)
        {
            this.Cash += MyBet.PayOut(Winner);
        }
    }
}
