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
        static public List<Dice> dices;
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

    public class D6 : Dice
    {
        public int sides = 6;

        public D6(int amount) : base(amount)
        {

        }
    }

    public class D8: Dice
    {
        public D8(int amount) : base(amount)
        {

        }
    }

    public class D10: Dice
    {
        public D10(int amount) : base(amount)
        {

        }
    }

    public class D12: Dice
    {
        public D12(int amount) : base(amount)
        {

        }
    }

    public class D20: Dice
    {
        public D20(int amount): base(amount)
        {

        }
    }
}
