using Save_the_Princess.Actors.Allies;
using Save_the_Princess.Actors.Movements;
using Save_the_Princess.Weapons;

namespace Save_the_Princess.Actors.Characters
{
	public class Puffer : Character
	{
		public Puffer()
		{
			movement = new Swimmer();
			weapon = null;
			ability = new PoisonTouch();
			health = 60;
			armor = 20;
		}
		
		public override void Update(float deltaTime)
		{
		}
		
		public override void Render()
		{
		}
	}
}