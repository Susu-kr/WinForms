namespace Lab1
{
    public class Bet
    {
        public int Amount; // 배팅할 돈
        public int DogNum; // 배팅할 개의 번호
        public Guy Bettor; // 배팅하는 사람

        public Bet(Guy better)
        {
            Bettor = better;    
        }

        public string GetDescription()
        {
            // 배팅한 돈이 0이거나, 배팅하는 사람의 돈을 초과해서 배팅한 경우
            string desc = " hasn't placed a bet";
            if (Amount != 0 || Bettor.MyBet.Amount > Bettor.Cash)
                desc = " has " + Bettor.MyBet.Amount + " bucks on dog #" + Bettor.MyBet.DogNum;

            return Bettor.Name + desc;
        }

        public int PayOut(int Winner)
        {
            // 승자에게는 +, 패자에게는 - 배팅금액을 넘겨준다.
            return DogNum == Winner ? Amount : -Amount;
        }
    }
}
