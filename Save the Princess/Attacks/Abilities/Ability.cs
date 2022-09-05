using System;
using Save_the_Princess.Actors.Characters;
using Save_the_Princess.Games;

namespace Save_the_Princess.Attacks.Abilities
{
	//A type of attack that has a cooldown
	public abstract class Ability : Attack
	{
		protected int cooldown;

		private double lastUseTimeSeconds;

		public bool IsOnCooldown => lastUseTimeSeconds + cooldown <= DateTime.UtcNow.TimeOfDay.TotalSeconds;
		protected Ability(int damage, int range, int cooldown) : base(damage, range)
		{
			this.cooldown = cooldown;
		}

		public override void Use(Entity entity)
		{
			if (IsOnCooldown)
				return;
			
			lastUseTimeSeconds = DateTime.UtcNow.TimeOfDay.TotalSeconds;
			if (Game.Instance.Player is Character c)
			{
				c.TakeDamage(Damage);
			}
		}

	}
}