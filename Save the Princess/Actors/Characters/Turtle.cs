using Save_the_Princess.Actors.Allies;
using Save_the_Princess.Actors.Movements;
using Save_the_Princess.Weapons;

namespace Save_the_Princess.Actors.Characters
{
	public class Turtle : Character
	{
		public Turtle()
		{
			movement = new Walker();
			weapon = null;
			ability = new ShellShock();
			health = 60;
			armor = 50;
		}
		
		public override void Update(float deltaTime)
		{
			
		}
		
		public override void Render()
		{
		}
	}
}