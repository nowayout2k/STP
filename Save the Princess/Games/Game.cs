using Save_the_Princess.Actors.Characters;
using Save_the_Princess.Utility;

namespace Save_the_Princess.Games
{
	//manages the lifecycle of the current level and loads new levels 
	public class Game
	{
		public static Game Instance { get; private set; }

		private int levelIndex;

		private Level[] levels;
		
		public Entity Player
		{
			get;
		}

		public Game(Entity player, Level[] levels)
		{
			Instance = this;
			this.levels = levels;
			levelIndex = 0;
			Player = player;
		}
		
		public void Spawn(Entity entity)
		{
			levels[levelIndex].SpawnEntity(entity);
		}
		
		public void RemoveEntity(Entity entity)
		{
			levels[levelIndex].RemoveEntity(entity);
		}
		
		public void LoadLevel()
		{
			levels[levelIndex].Load();
		}

		private void UnloadLevel()
		{
			levels[levelIndex].Load();
		}

		public void RenderLevel()
		{
			levels[levelIndex].Render();
		}

		public void UpdateLevel(double deltaTime)
		{
			if(levels[levelIndex].IsComplete())
			{
				UnloadLevel();
				levelIndex++;
				LoadLevel();
			}
			
			levels[levelIndex].Update(deltaTime);
		}
	}
}