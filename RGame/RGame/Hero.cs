using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RGame
{
    class Hero
    {
        private string hero_name;
        private int hero_hp;


        public void setValues(string hero_name, int hero_hp, string weapon_name, int weapon_damage)
        {
            this.hero_name = hero_name;
            this.hero_hp = hero_hp;
            
        }
       
    }
}
