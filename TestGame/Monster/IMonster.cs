using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestGame.HeroFolder;

namespace TestGame.Monster
{
	public interface IMonster
	{
		int GetHp();
		string GetName();
		void GetDamage(int Damage);
		void Attack(Hero hero);
	}
}
