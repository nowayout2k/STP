using System;
using System.Threading;
using Save_the_Princess.Actors.Allies;
using Timer = System.Timers.Timer;

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
			
			while (playerOne.IsAlive && currentLevel >= levels.Length)
			{
				long deltaTime = DateTime.Now.Ticks - lastTimeCheck;
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