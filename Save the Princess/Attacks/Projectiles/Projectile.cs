using Save_the_Princess.Games;
using Save_the_Princess.Utility;

namespace Save_the_Princess.Attacks.Projectiles
{
	//Represents a projectile from a location with a velocity and a lifespan in seconds
	public class Projectile : Entity
	{
		private float lifetime;
		public Projectile(Vector3d position, Vector3d direction, Vector3d velocity, float lifetime) : base(position, direction, velocity)
		{
			this.lifetime = lifetime;
		}
		public override void Load()
		{
			//Load Assets
		}

		public override void Unload()
		{
			//unload assets
		}

		public override void Render()
		{
			//draw entity to screen
		}

		public override void Update(double deltaTime)
		{
			//update position
			
			//kill if lifetime is exceeded or after collision
			Game.Instance.RemoveEntity(this);
		}
	}
}