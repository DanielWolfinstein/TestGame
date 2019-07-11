using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestGame.HeroFolder;

namespace TestGame.Monster
{
	class Zombe : IMonster
	{
		public int HP = 50;
		public int Damage = 5;
		public string Name = "Зомби";

		public int GetHp()
		{
			return HP;
		}
		public string GetName()
		{
			return Name;
		}
		public void GetDamage(int Damage)
		{
			HP -= Damage;
		}
		public void Attack(Hero hero)
		{
			hero.GetAttack(Damage);
		}


	}
}
