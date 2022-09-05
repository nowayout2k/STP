using Save_the_Princess.Games;
using Save_the_Princess.Utility;

namespace Save_the_Princess.Actors.Movements
{
	//Handles where and how the Ai walks
	public class WalkerAiMovement : AiMovement
	{
		public int WalkSpeed { get; }
		public WalkerAiMovement(int walkSpeed)
		{
			WalkSpeed = walkSpeed;
		}
		public override Vector3d Move(double deltaTime, Entity entity)
		{
			var newPosition = entity.Direction * deltaTime * WalkSpeed;
			if (newPosition.Y != 0)
				newPosition.Y = 0;
			return newPosition;
		}

		public override Vector3d Patrol(Vector3d position)
		{
			//Walk specific Patrol logic
			return position;
		}

		public override Vector3d Chase(Vector3d position)
		{
			//Walk specific chase logic
			return position;
		}
	}
}