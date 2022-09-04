using Save_the_Princess.Actors.Allies;
using Save_the_Princess.Actors.Movements;
using Save_the_Princess.Weapons;

namespace Save_the_Princess.Actors.Characters
{
	public class EvilBoss : Character
	{
		EvilBoss()
		{
			movement = new WalkAndFly();
			weapon = new BattleAxe();
			ability = new Fireball();
			health = 500;
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