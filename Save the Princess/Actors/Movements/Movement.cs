using Save_the_Princess.Games;
using Save_the_Princess.Utility;

namespace Save_the_Princess.Actors.Movements
{
	//Handles where and how an entity moves
	public abstract class Movement
	{
		public abstract Vector3d Move(double deltaTime, Entity entity);
	}
}