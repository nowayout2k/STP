using Save_the_Princess.Actors.Allies;
using Save_the_Princess.Actors.Movements;
using Save_the_Princess.Weapons;

namespace Save_the_Princess.Actors.Characters
{
	public class Squab : Character
	{
		public Squab()
		{
			movement = new Flier();
			weapon = new Bomb();
			ability = null;
			health = 50;
			armor = 0;
		}
		
		public override void Update(float deltaTime)
		{
		}
		
		public override void Render()
		{
		}
	}
}