using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.Weapons
{
    public class Spell
    {
        private int manaCost;
        private int damage;

        public int ManaCost
        {
            get
            {
                return this.manaCost;
            }
            set
            {
                this.manaCost = value;
            }
        }
        public int Damage
        {
            get
            {
                return this.damage;
            }
            set
            {
                this.damage = value;
            }
        }

        public Spell()
        {
            this.ManaCost = 10;
            this.Damage = 10;
        }
    }
}
