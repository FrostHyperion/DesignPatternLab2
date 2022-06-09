using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Lab2 {
    public abstract class Enemy {
        private int _health;
        private readonly int _damage;

        protected Enemy(int damage, int health) {
            _damage = damage;
            _health = health;
        }

        public int Attack() {
            return _damage;
        }
    }
}
