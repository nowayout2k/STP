using Save_the_Princess.Actors.Characters;
using Save_the_Princess.Games;

namespace Save_the_Princess.Attacks.Abilities
{
	//poison touch ability
	public class PoisonTouch : Ability
	{
		public PoisonTouch() : base(20, 0, 0)
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
			//specific poison touch logic for attacking
		}
 
	}
}