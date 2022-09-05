using Save_the_Princess.Attacks.Projectiles;
using Save_the_Princess.Games;

namespace Save_the_Princess.Attacks.Weapons
{
	//a bomb weapon
	public class Bomb : Weapon
	{
		public Bomb() : base(60, 20)
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
			//spawn a projectile from the current position in the direction vector with a velocity scalar of 20 and a lifetime of 20 secs
			Game.Instance.Spawn(new Projectile(entity.Position, entity.Direction, entity.Direction*20, 20));
		}
	}
}