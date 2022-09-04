using System;
using Save_the_Princess.Actors.Characters;

namespace Save_the_Princess
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			int currentLevel = 0;
			Level[] levels = { new Level(), new Level(), new Level() };
			PlayerOne playerOne = new PlayerOne();
			long lastTimeCheck = DateTime.Now.Ticks;
			
			while (playerOne.IsAlive && currentLevel < levels.Length)
			{
				long tickDifference = DateTime.Now.Ticks - lastTimeCheck;
				var milliseconds = new TimeSpan(tickDifference).Milliseconds;
				float deltaTime = milliseconds/1000f;
				lastTimeCheck = DateTime.Now.Ticks;
				levels[currentLevel].Update(deltaTime);
				levels[currentLevel].Render();
				if(levels[currentLevel].IsComplete())
				{
					currentLevel++;
				}
			}
		}
	}
}