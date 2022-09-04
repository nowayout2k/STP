using Save_the_Princess.Actors.Allies;
using Save_the_Princess.Attacks;

namespace Save_the_Princess.Weapons
{
	public abstract class Ability : Attack, IRender, IUpdate
	{
		protected bool isPassive;

		protected int cooldown;

		public bool IsPassive => isPassive;

		public int Cooldown => cooldown;

		public abstract void Render();

		public abstract void Update(float deltaTime);
	}
}