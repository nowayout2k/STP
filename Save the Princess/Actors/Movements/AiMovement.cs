using Save_the_Princess.Utility;

namespace Save_the_Princess.Actors.Movements
{
	//Handles where and how the Ai moves. adds functionality for a patrol or chase state
	public abstract class AiMovement : Movement
	{
		public abstract Vector3d Patrol(Vector3d position);

		public abstract Vector3d Chase(Vector3d position);
	}
}