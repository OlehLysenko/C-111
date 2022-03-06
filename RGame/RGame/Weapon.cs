using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RGame
{
    struct Weapon
    {
        private int dph, hit_number;
        public int damage(int dph, int hit_number)  //dph - damage per hit
        {
            this.dph = dph;
            this.hit_number = hit_number;
            return dph * hit_number;

        }
        public string info()
        {
            return "Урон за атаку: " + dph + " Атак за ход: " + hit_number;
        }
        
    }
}
