using System;

namespace Lab_6
{
	class stats
	{
		public int health = 1;         // Здоровье
		public int strenght = 1;       // Сила
		public int dexterity = 1;      // Ловкость
		public int intelligense = 1;   // Интеллект
		public int luck = 1;           // Удача

		public void print()
		{
			Console.WriteLine("Stats:\nHealth = " + health + "\nStrenght = " + strenght + "\nDexterity = " + dexterity + "\nIntelligense = " + intelligense + "\nluck = " + luck + "\n\n"); 
		}
	};

	class healthbar
	{
		public int health;
		public int mana;
		public void print() { Console.WriteLine("Health = " + health + "\nMana = " + mana + "\n\n"); }
	};

	class actions
	{
		public string first_action = "Точный удар";
		public int damage_first_action;
		public string second_action = "Сильный удар";
		public int damage_second_action;
		public string third_action = "Заклинание фаербола";
		public int damage_third_action;
		public string fourth_action = "Побег";
		public int percent_luck;
	};

	class main_hero
	{ // Главный класс
		public string name;
		public stats hero;
		public healthbar info;
		public actions movement;

		public main_hero()
		{
			Console.WriteLine("Введите имя персонажа");
			name = Console.ReadLine();
			Console.WriteLine("\n");
			
			info = new healthbar();
			hero = new stats();
			movement = new actions();
			
			info.health = 20 + (5 * hero.health);
			info.mana = 15 + (2 * hero.intelligense);

			movement.damage_first_action = 7 + (3 * hero.dexterity);
			movement.damage_second_action = 7 + (3 * hero.strenght);
			movement.damage_third_action = 10 + (5 * hero.intelligense);
			movement.percent_luck = 3 + (2 * hero.luck);
		}
	};

	internal class Program
    {
        static void Main(string[] args)
        {
			// Создание главного героя
			var one = new main_hero();
			// Вывод данных о главном герое
			one.hero.print();
			one.info.print();
		}
    }
}