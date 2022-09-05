using Save_the_Princess.Games;

namespace Save_the_Princess.Attacks.Abilities
{
	//shell shock ability
	public class ShellShock : Ability
	{

		public ShellShock() : base(5, 0, 0)
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
			//specific shell shock logic for attacking
		}
	}
}