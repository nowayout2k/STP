using Save_the_Princess.Actors.Movements;
using Save_the_Princess.Attacks;
using Save_the_Princess.Attacks.Weapons;
using Save_the_Princess.Games;
using Save_the_Princess.Utility;

namespace Save_the_Princess.Actors.Characters
{
	/// <summary>
	/// A character representing the player. This character takes input to move the character
	/// </summary>
	public class PlayerOne : Character, IAttacker, IArmored
	{
		protected float armor;
		protected Weapon weapon;

		public float Armor => armor;
		public Weapon Weapon => weapon;

		public PlayerOne(Vector3d position, Vector3d direction) : base(position, direction)
		{
			movement = new WalkerPlayerMovement(20);
			weapon = new Shotgun();
			health = 100;
			armor = 100;
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

		public override void Update(double deltaTime)
		{
			Weapon.Update(deltaTime);
			direction = new Vector3d(1,0,0);//this would normally be based on input
			movement.Move(deltaTime, this);
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
 
		public void Attack(Entity target)
		{
			//Use an attack
			Weapon.Use(target);
		}
	}
}