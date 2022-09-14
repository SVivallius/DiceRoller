using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    static public class DiceRoller
    {
        static private List<Dice> diceList = new List<Dice>();

        static public void AddDie(Dice dice)
        {
            diceList.Add(dice);
        }

        static public void ClearDice()
        {
            diceList.Clear();
        }

        static public int roll()
        {
            Random roll = new Random();
            int total = 0;

            foreach (Dice dice in diceList)
            {
                total =+ roll.Next(1, dice.sides);
            }

            return total;
        }
    }
    public class Dice
    {
        internal int sides;
        public Dice()
        {
            
        }
    }

    public class D4 : Dice
    {
        public D4() :base()
        {
            base.sides = 4;
        }
    }

    public class D6 : Dice
    {
        public D6() : base()
        {
            base.sides = 6;
        }
    }

    public class D8: Dice
    {
        public D8() : base()
        {
            base.sides = 8;
        }
    }

    public class D10: Dice
    {
        public D10() : base()
        {
            base.sides = 10;
        }
    }

    public class D12: Dice
    {
        public D12() : base()
        {
            base.sides = 12;
        }
    }

    public class D20: Dice
    {
        public D20(): base()
        {
            base.sides = 20;
        }
    }
}
