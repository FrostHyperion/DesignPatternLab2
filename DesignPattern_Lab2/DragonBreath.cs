using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Lab2 {
    public class DragonBreath : WeaponUpgrader {

        private Weapon _weapon;
        private readonly string _name;

        public DragonBreath(Weapon weapon) {
            _weapon = weapon;
            _name = "DragonBreath";
            _weapon.AddAddOn(_name);
            _weapon.ChangeAttackDamage(10);
        }

        public override void Upgrade(Weapon weapon) {
            weapon.AddAddOn(_name);
        }

        public override string GetName() {
            return _weapon.GetName();
        }

        public string GetAddOnName() {
            return _name;
        }

        public override int Attack() {
            return _weapon.Attack();
        }
    }
}
