using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestGame.HeroFolder;
using TestGame.Monster;
using System.Threading;

namespace TestGame
{
	class Program
	{
		static Hero Player;
		static IMonster monster;
		static void Main(string[] args)
		{
			Console.Title="Топ игра";
			Player = new Hero();
			monster = new Zombe();
			Console.WriteLine("Идя по лесу ты наткнулся на зомби." +
							"\n   Нехер было гулять так поздно" +
							"\n\n  Для продолжения нажмите Enter.");
			Console.Read();
			PrintInterface();
			Start();
		}

		static void PrintInterface()
		{
			Console.Clear();
			Player.PrintHp();

			Console.WriteLine("\nВыбирите действие:\n" +
				"|Атака| |Осмотреть| |Сбежать| \n \n \n");
		}

		static void Start()
		{
			string answer;
			bool Finish = true;
			bool turn = false;
			while (Finish)
			{
				
	
				answer = Console.ReadLine().ToUpper();
				PrintInterface();

				if (answer == "АТАКА")
				{
					Player.Attack(monster);
				}
				else if (answer == "ОСМОТРЕТЬ")
				{
					Player.checkHp(monster);
					Console.Read();
				}
				else if (answer == "СБЕЖАТЬ")
				{
					Console.WriteLine("Ну и беги, жалкий трус");
					Finish = false;
					turn = true;
					Thread.Sleep(800);
				}
				else
				{
					Console.WriteLine("Введите корректный ответ");
					turn = true;
				}

				if (Finish && !turn)
				{
					PrintInterface();

					if (monster.GetHp() <= 0)
					{
						Console.WriteLine("Монстр умер, Ты герой");
						Finish = false;
						Thread.Sleep(800);
					}
					else
					{
						Console.WriteLine("Монстр Атакует");
						monster.Attack(Player);
						Thread.Sleep(800);
					}

					if (Player.Hp <= 0)
					{
						Console.WriteLine("Ты умер, Игра окончена");
						Finish = false;
						Thread.Sleep(800);
					}
					PrintInterface();

				}
				turn = false;
			}

		}
	}
	
}
