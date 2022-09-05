using Save_the_Princess.Games;
using Save_the_Princess.Utility;

namespace Save_the_Princess.Actors.Movements
{
	//Handles where and how the Ai flies or walks
	public class WalkerFlierAiMovement : AiMovement
	{
		public int FlySpeed { get; }
		public int WalkSpeed { get; }
		
		public WalkerFlierAiMovement(int flySpeed, int walkSpeed)
		{
			FlySpeed = flySpeed;
			WalkSpeed = walkSpeed;
		}
		public override Vector3d Move(double deltaTime, Entity entity)
		{
			var newPosition = entity.Direction * deltaTime * FlySpeed;
			if (newPosition.Y < 0)
				newPosition.Y = 0;
			return entity.Position + newPosition;
		}
		public override Vector3d Patrol(Vector3d position)
		{
			//Walk/Fly specific Patrol logic
			return position;
		}

		public override Vector3d Chase(Vector3d position)
		{
			//Walk/Fly specific chase logic
			return position;
		}
	}
}