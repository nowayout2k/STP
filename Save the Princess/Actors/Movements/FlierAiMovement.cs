using Save_the_Princess.Games;
using Save_the_Princess.Utility;

namespace Save_the_Princess.Actors.Movements
{
	//Handles where and how the Ai flies
	public class FlierAiMovement : AiMovement
	{
		public int FlySpeed { get; }
		
		public FlierAiMovement(int speed)
		{
			FlySpeed = speed;
		}

		public override Vector3d Move(double deltaTime, Entity entity)
		{
			var newPosition = entity.Direction * deltaTime * FlySpeed;
			if (newPosition.Y <= 0)
				newPosition.Y = 1;
			return newPosition;
		}

		public override Vector3d Patrol(Vector3d position)
		{
			//fly specific Patrol logic
			return position;
		}

		public override Vector3d Chase(Vector3d position)
		{
			//fly specific chase logic
			return position;
		}
	}
}