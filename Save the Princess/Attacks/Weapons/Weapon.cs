using Save_the_Princess.Actors.Allies;
using Save_the_Princess.Attacks;

namespace Save_the_Princess.Weapons
{
	public abstract class Weapon : Attack, IRender, IUpdate
	{
		protected int attackPower;

		protected float durability;

		public float Durability => durability;

		public int AttackPower => attackPower;

		public abstract void Render();
		
		public abstract void Update(float deltaTime);
	}
}