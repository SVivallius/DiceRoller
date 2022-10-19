using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    internal class Creature
    {
        public string Name { get; private set; }
        public List<Attack> attacks = new List<Attack>();

        public Creature(string name)
        {
            Name = name;
        }

        public void AddAttack(Attack attack)
        {
            attacks.Add(attack);
        }

        public void FetchCreature(string path)
        {
            List<string> inputData = new List<string>();
            using (StreamReader sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    if (sr.ReadLine() != null)
                    {
                        inputData.Add(sr.ReadLine());
                    }
                }
            }
        }
    }

    internal class Attack
    {
        private bool RollToHit { get; set; }
        public string AttackName { get; set; }

        public List<Dice> attackDamage = new List<Dice>();

        public Attack(string attackName, bool rollToHit, int die, Dice dieType)
        {
            RollToHit = rollToHit;
            AttackName = attackName;
            for (int i = 0; i < die; i++)
            {
                attackDamage.Add(dieType);
            }
        }

        public Attack(string attackName, int die, Dice dieType)
        {
            RollToHit = false;
            AttackName = attackName;
            for (int i = 0; i < die; i++)
            {
                attackDamage.Add(dieType);
            }
        }
    }
}
