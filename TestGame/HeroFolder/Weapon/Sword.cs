using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestGame.Monster;

namespace TestGame.HeroFolder.Weapon
{
	class Sword : IWeapon
	{
		int Damage = 10;
		string WeaponName;
		public int GetDamage()
		{
			return Damage;
		}
		public string GetName()
		{
			return WeaponName;
		}

	}
}
