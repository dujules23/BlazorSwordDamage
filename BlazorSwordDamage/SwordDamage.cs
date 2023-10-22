using System;
using System.Diagnostics;
namespace BlazorSwordDamage
{
	public class SwordDamage
	{
		public SwordDamage()
		{
			Console.WriteLine("Created an instance of SwordDamage");
		}

		public const int BASE_DAMAGE = 3;
		public const int FLAME_DAMAGE = 2;

		public int Roll;
		public decimal MagicMultiplier = 1M;
		public int FlamingDamage = 0;
		public int Damage;

		public void CalculateDamage()
		{
			Damage = (int)(Roll * MagicMultiplier) + BASE_DAMAGE + FlamingDamage;
			Console.WriteLine($"CalculateDamage finished: {Damage} (roll: {Roll})");
		}

		public void SetMagic(bool isMagic)
		{
			if (isMagic)
			{
				MagicMultiplier = 1.75M;
			}
			else
			{
				MagicMultiplier = 1M;
			}
			CalculateDamage();
            Console.WriteLine($"CalculateDamage finished: {Damage} (roll: {Roll})");
        }

		public void SetFlaming(bool isFlaming)
		{
			CalculateDamage();
			if (isFlaming)
			{
				Damage += FLAME_DAMAGE;
			}
            Console.WriteLine($"CalculateDamage finished: {Damage} (roll: {Roll})");
        }
	}
}

