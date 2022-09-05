using Save_the_Princess.Games;

namespace Save_the_Princess.Attacks.Weapons
{
	//A battle axe weapon
	public class BattleAxe : Weapon
	{
		public BattleAxe() : base(40, 5) { }
		public override void Use(Entity entity)
		{
			base.Use(entity);
			//specific Battle axe logic for attacking
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