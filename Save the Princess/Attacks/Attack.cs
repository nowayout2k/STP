using Save_the_Princess.Games;
using Save_the_Princess.Utility;

namespace Save_the_Princess.Attacks
{
	/// <summary>
	/// An Attack with damage and range that a character can use
	/// </summary>
	public abstract class Attack : Entity
	{
		private readonly int range;
		private readonly int damage;
		
		public int Damage => damage;
		protected Attack(int damage, int range)
		{
			this.range = range;
		}
		public bool IsInRange(Vector3d source, Vector3d destination)
		{
			return (source - destination).Magnitude <= range;
		}
		
		public abstract void Use(Entity entity);
	}
}