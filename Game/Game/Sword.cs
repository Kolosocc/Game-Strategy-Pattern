using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameNamaSpaces
{
    internal class Sword : IWeapon
    {
        public void UseWeapon()
        {
            Console.WriteLine("Вы рубите врага мечом.");
        }
    }
}
