using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Lab2
{
    public abstract class WeaponUpgrader : Weapon {
        public abstract Weapon Upgrade(Weapon weapon);
    }
}
