using System.Collections.Generic;
using Save_the_Princess.Actors.Movements;
using Save_the_Princess.Weapons;

namespace Save_the_Princess.Actors.Allies
{
	public abstract class Character : IRender, IUpdate
	{
		public float Health => health;
		
		public float Armor => armor;

		public Weapon Weapon => weapon;
		
		public Ability Ability => ability;
		
		protected float health;
		
		protected float armor;
		
		protected Weapon weapon;
		
		protected Ability ability;

		protected Movement movement;

		public bool IsAlive => health > 0;

		public abstract void Render();

		public abstract void Update(float deltaTime);
	}
}