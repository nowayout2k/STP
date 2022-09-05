using Save_the_Princess.Actors.Movements;
using Save_the_Princess.Attacks;
using Save_the_Princess.Attacks.Abilities;
using Save_the_Princess.Games;
using Save_the_Princess.Utility;

namespace Save_the_Princess.Actors.Characters
{
	//A hostile puffer character with armor
	public class Puffer : HostileCharacter, IArmored, IAbilityAttacker
	{
		public Ability Ability { get; }
		public float Armor => armor;
		
		protected float armor;
		
		public Puffer(Vector3d position, Vector3d direction) : base(position, direction, 15)
		{
			movement = new SwimmerAiMovement(20);
			Ability = new PoisonTouch();
			health = 60;
			armor = 20;
		}
		
		protected override bool CanAttack(Entity target)
		{
			bool canUseAbility = Ability != null && !Ability.IsOnCooldown && Ability.IsInRange(Position, target.Position);
			return CanSee(target) && canUseAbility;
		}
		
		public override void Attack(Entity target)
		{
			if(!CanAttack(target))
				return;
			if(Ability != null && !Ability.IsOnCooldown)
				Ability.Use(target);
		}
		
		public override void TakeDamage(int damage)
		{
			if (armor > 0)
			{
				armor += damage;
			}
			else
			{
				base.TakeDamage(damage);
			}
		}
		
		public override void Load()
		{
			//Load Assets
			Ability.Load();
		}

		public override void Unload()
		{
			//unload assets
			Ability.Render();
		}

		public override void Render()
		{
			//draw entity to screen
			Ability.Render();
		}

		public override void Update(double deltaTime)
		{
			Ability.Update(deltaTime);
		}
	}
}