using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameNamaSpaces
{
    internal class Axe : IWeapon
    {
        public void UseWeapon()
        {
            Console.WriteLine("Вы размахиваете топором.");
        }
    }
}
