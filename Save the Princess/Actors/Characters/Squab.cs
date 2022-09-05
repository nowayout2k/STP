using Save_the_Princess.Actors.Movements;
using Save_the_Princess.Attacks;
using Save_the_Princess.Attacks.Abilities;
using Save_the_Princess.Attacks.Weapons;
using Save_the_Princess.Games;
using Save_the_Princess.Utility;

namespace Save_the_Princess.Actors.Characters
{
	//A hostile squab character
	public class Squab : HostileCharacter, IWeaponAttacker
	{
		public Weapon Weapon { get; }

		public Squab(Vector3d position, Vector3d direction) : base(position, direction, 10)
		{
			movement = new FlierAiMovement(30);
			Weapon = new Bomb();
			health = 50;
		}
		
		public override void Load()
		{
			//Load Assets
			Weapon.Load();
		}

		public override void Unload()
		{
			//unload assets
			Weapon.Render();
		}

		public override void Render()
		{
			//draw entity to screen
			Weapon.Render();
		}

		public override void Update(double deltaTime)
		{
			Weapon.Update(deltaTime);
		}
		
		protected override bool CanAttack(Entity target)
		{
			bool canUseWeapon = Weapon != null && Weapon.IsInRange(Position, target.Position);
			return CanSee(target) && canUseWeapon;
		}
		public override void Attack(Entity target)
		{
			if(!CanAttack(target))
				return;
			if(Weapon != null)
				Weapon.Use(target);
		}
	}
}