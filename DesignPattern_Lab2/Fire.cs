using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Lab2 {
    public class Fire : WeaponUpgrader {

        private Weapon _weapon;
        private readonly string _name;

        public Fire(Weapon weapon) {
            _weapon = weapon;
            _name = "Fire";
            _weapon.AddAddOn(_name);
            _weapon.ChangeAttackDamage(10);
        }

        public override Weapon Upgrade(Weapon weapon) {
            weapon.AddAddOn(_name);
            return weapon;
        }

        public override string GetName() {
            return _weapon.GetName();
        }

        public override int Attack() {
            return _weapon.Attack();
        }
    }
}
