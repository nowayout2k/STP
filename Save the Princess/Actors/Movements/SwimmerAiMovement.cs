using Save_the_Princess.Games;
using Save_the_Princess.Utility;

namespace Save_the_Princess.Actors.Movements
{
	//Handles where and how the Ai swims
	public class SwimmerAiMovement : AiMovement
	{
		public int SwimSpeed { get; }

		public SwimmerAiMovement(int speed)
		{
			SwimSpeed = speed;
		}
		public override Vector3d Move(double deltaTime, Entity entity)
		{
			var newPosition = entity.Direction * deltaTime * SwimSpeed;
			if (newPosition.Y >= 0)
				newPosition.Y = -1;
			return entity.Direction + newPosition;
		}

		public override Vector3d Patrol(Vector3d position)
		{
			//swim specific Patrol logic
			return position;
		}

		public override Vector3d Chase(Vector3d position)
		{
			//swim specific chase logic
			return position;
		}
	}
}