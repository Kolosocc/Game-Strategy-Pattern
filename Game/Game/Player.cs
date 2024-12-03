using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameNamaSpaces
{

        internal class Player
        {
            private IWeapon _weapon; 
            private string _name; 

            public Player(IWeapon weapon, string name)
            {
                _weapon = weapon;
                _name = name;
            }

            public void SetWeapon(IWeapon weapon)
            {
                _weapon = weapon;
                Console.WriteLine($"{_name} теперь использует новое оружие.");
            }

            public void UseWeapon()
            {
                Console.Write($"{_name} атакует: ");
                _weapon.UseWeapon();
            }
        }
    

}
