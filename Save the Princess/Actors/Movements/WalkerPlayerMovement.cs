using Save_the_Princess.Games;
using Save_the_Princess.Utility;

namespace Save_the_Princess.Actors.Movements
{
	//Handles where and how the player walks
	public class WalkerPlayerMovement : Movement
	{
		public int WalkSpeed { get; }
		public WalkerPlayerMovement(int walkSpeed)
		{
			WalkSpeed = walkSpeed;
		}
		public override Vector3d Move(double deltaTime, Entity entity)
		{
			var newPosition = entity.Direction * WalkSpeed * deltaTime;
			if (newPosition.Y != 0)
				newPosition.Y = 0;
			return entity.Position + newPosition;
		}
 
	}
}