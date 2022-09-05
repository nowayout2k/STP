using System.Collections.Generic;
using Save_the_Princess.Actors.Characters;

namespace Save_the_Princess.Games
{
	/// <summary>
	/// A level manages the lifecycle of entities, this includes loading, unloading, updating, and rendering
	/// </summary>
	public class Level : Entity
	{
		//All entities currently in the level
		private readonly List<Entity> entities;

		public Level(List<Entity> entities)
		{
			this.entities = entities;
		}

		~Level()
		{
			Unload();
			entities?.Clear();
		}

		public void RemoveEntity(Entity entity)
		{
			entity.Unload();
			entities.Remove(entity);
		}
		
		public void SpawnEntity(Entity entity)
		{
			entity.Load();
			entities.Add(entity);
		}
		
		//Determines whether the win condition has been met
		public bool IsComplete()
		{
			foreach (var e in entities)
			{
				if (e is HostileCharacter hs && hs.IsAlive)
				{
					return false;
				}
			}
			
			return true;
		}

		public override void Load()
		{
			if (entities != null)
			{
				foreach (var e in entities)
				{
					e.Load();
				}
			}
		}

		public override void Unload()
		{
			if (entities != null)
			{
				foreach (var e in entities)
				{
					e.Unload();
				}
			}
		}


		public override void Update(double deltaTime)
		{
			if (entities != null)
			{
				foreach (var e in entities)
				{
					e.Update(deltaTime);
				}
			}
		}

		public override void Render()
		{
			if (entities != null)
			{
				foreach (var e in entities)
				{
					e.Render();
				}
			}
		}
	}
}