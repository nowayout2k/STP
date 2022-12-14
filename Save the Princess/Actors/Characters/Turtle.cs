using Save_the_Princess.Actors.Movements;
using Save_the_Princess.Attacks;
using Save_the_Princess.Attacks.Abilities;
using Save_the_Princess.Games;
using Save_the_Princess.Utility;

namespace Save_the_Princess.Actors.Characters
{
	//A hostile turtle character with armor
	public class Turtle : HostileCharacter, IArmored, IAbilityAttacker
	{
		protected float armor;
		protected Ability ability;
		public float Armor => armor;
		public Ability Ability => ability;

		public Turtle(Vector3d position, Vector3d direction) : base(position, direction, 20)
		{
			movement = new WalkerAiMovement(10);
			ability = new ShellShock();
			health = 60;
			armor = 50;
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