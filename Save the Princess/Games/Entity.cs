using Save_the_Princess.Utility;

namespace Save_the_Princess.Games
{
	/// <summary>
	/// A base class for all objects that can be placed in a level.
	/// Entites have a position, direction and velocity and can be Loaded, Unloaded, Rendered and Updated
	/// </summary>
	public abstract class Entity
	{
		
		protected Vector3d position;
		protected Vector3d direction;
		protected Vector3d velocity;
		public Vector3d Position => position;
		public Vector3d Direction => direction;
		public Vector3d Velocity => velocity;
		
		protected Entity()
		{
			position = new Vector3d(0,0,0);
			direction = new Vector3d(0,1,0);
			velocity = new Vector3d(0,1,0);
		}
		
		protected Entity(Vector3d position, Vector3d direction)
		{
			this.position = position;
			this.direction = direction;
			velocity = new Vector3d(0,1,0);
		}
		
		protected Entity(Vector3d position, Vector3d direction, Vector3d velocity)
		{
			this.position = position;
			this.direction = direction;
			this.velocity = velocity;
		}

		//creates any assets needed for this entity 
		public abstract void Load();
		//destroys any assets needed for this entity
		public abstract void Unload();
		//draws any assets needed for this entity
		public abstract void Render();
		//updates any assets needed for this entity
		public abstract void Update(double deltaTime);
	}
}