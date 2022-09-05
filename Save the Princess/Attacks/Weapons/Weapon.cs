using Save_the_Princess.Games;

namespace Save_the_Princess.Attacks.Weapons
{
	/// <summary>
	/// An attack that has durability that lowers upon use
	/// </summary>
	public abstract class Weapon : Attack
	{
		private float durability = 100.0f;
		protected Weapon(int damage, int range) : base(damage, range)
		{
		}

		public override void Use(Entity entity)
		{
			if(durability <= 0)
				return;
			durability -= .02f;
		}
	}
}