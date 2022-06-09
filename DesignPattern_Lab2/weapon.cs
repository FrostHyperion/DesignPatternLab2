using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Lab2 {
    public class Weapon {
        private int _attackDamage = 0;
        private string _name;
        private readonly List<string> _addOns = new();

        public int ChangeAttackDamage(int attackDamage) {
            _attackDamage += attackDamage;
            return _attackDamage;
        }

        public virtual int Attack() {
            return _attackDamage;
        }

        public virtual string GetName() {
            return _name;
        }

        public virtual void SetName(string name) {
            _name = name;
        }

        public List<string> GetAddOns() {
            return _addOns;
        }

        public void AddAddOn(string addOn) {
            _addOns.Add(addOn);
        }
    }
}
