using Save_the_Princess.Attacks.Projectiles;
using Save_the_Princess.Games;

namespace Save_the_Princess.Attacks.Abilities
{
	//fireball ability
	public class Fireball : Ability
	{
		public Fireball() : base(20, 5, 50) { }
		
		public override void Use(Entity entity)
		{
			base.Use(entity);
			Game.Instance.Spawn(new Projectile(entity.Position, entity.Direction, entity.Direction*20, 20));
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
	}
}