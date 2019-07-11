using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestGame.Monster;

namespace TestGame.HeroFolder
{
	public class Hero
	{
		public int Hp = 100;
		IWeapon weapon = new Weapon.Sword();

		public void PrintHp() //То, что пишет хп
		{
			Console.WriteLine("|HP: "+Hp+"|");
		}

		public void GetAttack(int Damage)
		{
			Hp -= Damage;
		}
		public void Attack(IMonster monster)
		{
			Console.WriteLine("Вы атаковали монстра");
			monster.GetDamage(weapon.GetDamage());
		}

		public void checkHp(IMonster monster)
		{
			Console.WriteLine("|HP "+monster.GetName()+": " + monster.GetHp() + "|");
		}
	}
}
