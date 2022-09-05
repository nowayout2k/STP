using Save_the_Princess.Actors.Movements;
using Save_the_Princess.Utility;

namespace Save_the_Princess.Actors.Characters
{
	//The princess character
	public class Princess : Character
	{
		public Princess(Vector3d postion, Vector3d direction) : base(postion, direction)
		{
			movement = new WalkerAiMovement(20);
			health = 80;
		}

		public override void Load()
		{
			//Load Princess Assets

		}

		public override void Unload()
		{
			//unload Princess assets

		}

		public override void Render()
		{
			//draw princess to screen

		}

		public override void Update(double deltaTime)
		{
			//update princess
		}
 
	}
}