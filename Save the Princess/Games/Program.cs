using System;
using System.Collections.Generic;
using Save_the_Princess.Actors.Characters;
using Save_the_Princess.Utility;

namespace Save_the_Princess.Games
{
	internal class Program
	{
		/// <summary>
		/// this program is a stub exercise and therefore does not provide some things that would be appropriate for
		/// a production environment such as, error handling, proper logic and removal of "magic numbers" and smooth
		/// transitions
		/// </summary>
		public static void Main(string[] args)
		{
			//Create the levels used in the game
			var levelOne = new Level(new List<Entity>{new Turtle(Vector3d.Zero, Vector3d.Left), new Puffer(Vector3d.Zero, Vector3d.Left)});
			var levelTwo = new Level(new List<Entity>{new Turtle(Vector3d.Zero, Vector3d.Left), new Squab(Vector3d.Zero, Vector3d.Left)});
			var levelThree = new Level(new List<Entity>{ new EvilBoss(Vector3d.Zero, Vector3d.Left), new Princess(Vector3d.Zero, Vector3d.Left) } );
			Level[] levels = { levelOne, levelTwo, levelThree };


			//create an object to manage the levels
			Game game = new Game(levels);
			
			var lastTimeCheck = DateTime.UtcNow.TimeOfDay.TotalMilliseconds;
			
			//load the first level
			game.LoadLevel();
			
			//game loop
			while (!game.IsGameOver())
			{
				var milliseconds = DateTime.UtcNow.TimeOfDay.TotalMilliseconds - lastTimeCheck;
				var deltaTime = milliseconds/1000f;
				lastTimeCheck = DateTime.Now.Ticks;
				game.UpdateLevel(deltaTime);
				game.RenderLevel();
			}
		}
	}
}