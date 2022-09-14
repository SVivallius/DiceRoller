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
        static public List<Dice> diceList = new List<Dice>();
        static public List<int> indivRolls = new List<int>();
        static public int amtToAdd = 0;

        static public void AddDie(Dice dice)
        {
            for (int i = 0; i < amtToAdd; amtToAdd--)
            {
                diceList.Add(dice);
            }
        }

        static public int CountDice(Dice selection)
        {
            int tempAmount = 0;
            foreach(Dice die in diceList)
            {
                if (die.sides == selection.sides)
                {
                    tempAmount++;
                }
            }
            return tempAmount;
        }

        static public void ClearDice()
        {
            diceList.Clear();
        }

        static public int Roll()
        {
            Random roll = new Random();
            int total = 0;
            indivRolls.Clear();

            foreach (Dice dice in diceList)
            {
                int thisRoll = roll.Next(1, (dice.sides + 1));

                indivRolls.Add(thisRoll);
                total += thisRoll;
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
