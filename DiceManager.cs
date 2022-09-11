using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    static class DiceRoller
    {
        static List<Dice> dices;
    }
    public class Dice
    {
        private int amount;
        public Dice(int num)
        {
            this.amount = num;
        }
    }

    public class D4 : Dice
    {
        private int sides = 4;

        public D4(int amount) :base(amount)
        {
            
        }
    }
}
