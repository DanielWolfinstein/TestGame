using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestGame.Monster;


namespace TestGame.HeroFolder
{
	interface IWeapon
	{
		int GetDamage();
		string GetName();
	}
}