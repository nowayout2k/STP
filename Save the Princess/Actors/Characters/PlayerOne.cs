using Save_the_Princess.Actors.Allies;
using Save_the_Princess.Actors.Movements;
using Save_the_Princess.Weapons;

namespace Save_the_Princess.Actors.Characters
{
	public class PlayerOne : Character
	{
		public PlayerOne()
		{
			movement = new Walker();
			weapon = new Shotgun();
			ability = null;
			health = 100;
			armor = 100;
		}

		public override void Update(float deltaTime)
		{
			
		}
		
		public override void Render()
		{
 
		}
	}
}