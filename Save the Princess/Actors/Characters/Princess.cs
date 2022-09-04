using Save_the_Princess.Actors.Allies;
using Save_the_Princess.Actors.Movements;

namespace Save_the_Princess.Actors.Characters
{
	public class Princess : Character
	{
		Princess()
		{
			movement = new Walker();
			weapon = null;
			ability = null;
			health = 80;
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