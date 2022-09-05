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
		
		public Character Player { get; }

		public Game(Level[] levels)
		{
			Instance = this;
			this.levels = levels;
			levelIndex = 0;
						
			//create the player
			Player = new PlayerOne(Vector3d.Zero, Vector3d.Right);
		}

		~Game()
		{
			Instance = null;
			levels = null;
			levelIndex = 0;
		}
		
		private void UnloadLevel()
		{
			levels[levelIndex].Load();
		}
		
		public bool IsGameOver()
		{
			if (levelIndex >= levels.Length || !Player.IsAlive)
				return true;

			return false;
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
			if(levelIndex < levels.Length)
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
			else
			{
				levels[levelIndex].Update(deltaTime);
			}
		}
	}
}