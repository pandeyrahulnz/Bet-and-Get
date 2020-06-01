using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bet_and_Get
{
    class Bet
    {
        public int Amount;
        public int Car ;
        public Guy Better ;

        public Bet(int Amount, int Car, Guy Bettor)
        {
            this.Amount = Amount;
            this.Car = Car;
            this.Better = Bettor;
        }



        public string GetDescription()
        {
            if (Amount == 0)
                return Better.Name + "hasn't placed a bet";
            else
                return Better.Name + " placed a bet of " + Amount + " dollars on F" + Car;
        }


        public int PayOut(int Winner)
        {
            if (Car == Winner)
            {
                return Amount;
            }
            return -Amount;
        }
    }
}
