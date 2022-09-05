using Save_the_Princess.Actors.Movements;
using Save_the_Princess.Attacks;
using Save_the_Princess.Attacks.Abilities;
using Save_the_Princess.Attacks.Weapons;
using Save_the_Princess.Games;
using Save_the_Princess.Utility;

namespace Save_the_Princess.Actors.Characters
{
	//The End boss character with armor
	public class EvilBoss : HostileCharacter, IArmored, IMultiAttacker
	{
		protected float armor;
		
		public Ability Ability { get; }

		public Weapon Weapon { get; }
		public float Armor => armor;

		public EvilBoss(Vector3d position, Vector3d direction) : base(position, direction, 30)
		{
			movement = new WalkerFlierAiMovement(40, 50);
			Weapon = new BattleAxe();
			Ability = new Fireball();
			health = 500;
			armor = 100;
		}

		protected override bool CanAttack(Entity target)
		{
			bool canUseAbility = Ability != null && !Ability.IsOnCooldown && Ability.IsInRange(Position, target.Position);
			bool canUseWeapon = Weapon != null && Weapon.IsInRange(Position, target.Position);
			return CanSee(target) && (canUseAbility || canUseWeapon);
		}
		public override void Attack(Entity target)
		{
			if(!CanAttack(target))
				return;
			if(Ability != null && !Ability.IsOnCooldown)
				Ability.Use(target);
			else if(Weapon != null)
				Weapon.Use(target);
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
			Weapon.Load();
			Ability.Load();
		}

		public override void Unload()
		{
			//unload assets
			Weapon.Render();
			Ability.Render();
		}

		public override void Render()
		{
			//draw entity to screen
			Weapon.Render();
			Ability.Render();
		}

		public override void Update(double deltaTime)
		{
			Weapon.Update(deltaTime);
			Ability.Update(deltaTime);
		}
	}
}