using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    class Bet
    {
        public int Amount; // 배팅할 돈
        public int DogNum; // 배팅할 개의 번호
        public Guy Bettor; // 배팅하는 사람

        public string GetDescription()
        {
            // 배팅한 돈이 0이거나, 배팅하는 사람의 돈을 초과해서 배팅한 경우
            if (Amount == 0 || Bettor.MyBet.Amount > Bettor.Cash)
                return Bettor.Name + " hasn't placed a bet";
            else
                return Bettor.Name + " has "
                    + Bettor.MyBet.Amount + " bucks on dog #" + Bettor.MyBet.DogNum;
        }

        public int PayOut(int Winner)
        {
            // 승자에게는 +, 패자에게는 - 배팅금액을 넘겨준다.
            if (Bettor.MyBet.DogNum == Winner)
                return Amount;
            else
                return -Amount;
        }
    }
}
