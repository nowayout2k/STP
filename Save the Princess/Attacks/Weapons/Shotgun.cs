using Save_the_Princess.Attacks.Projectiles;
using Save_the_Princess.Games;

namespace Save_the_Princess.Attacks.Weapons
{
	//A shotgun weapon
	public class Shotgun : Weapon
	{

		public Shotgun() : base(50, 50)
		{
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
		}

		public override void Use(Entity entity)
		{
			base.Use(entity);
			//spawn a projectile from the current position in the direction vector with a velocity scalar of 100 and a lifetime of 30 secs
			Game.Instance.Spawn(new Projectile(entity.Position, entity.Direction, entity.Direction*100, 30));
		}

	}
}