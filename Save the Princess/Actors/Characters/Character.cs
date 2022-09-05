using Save_the_Princess.Actors.Movements;
using Save_the_Princess.Attacks.Abilities;
using Save_the_Princess.Games;
using Save_the_Princess.Utility;

namespace Save_the_Princess.Actors.Characters
{
	/// <summary>
	/// A type of entity that can be killed and has movement
	/// </summary>
	public abstract class Character : Entity
	{
		protected Character(Vector3d position, Vector3d direction) : base(position, direction)
		{
			
		}
		
		public float Health => health;

		protected float health;

		protected Movement movement;

		public bool IsAlive => health > 0;

		public void LookAtEntity(Entity target)
		{
			direction = (target.Position - Position).Normalize();
		}

		public virtual void TakeDamage(int damage)
		{
			health += damage;
		}
	}
}