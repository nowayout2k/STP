using Save_the_Princess.Games;

namespace Save_the_Princess.Attacks
{
	//An object that has a weapon, ability and can attack an Entity
	public interface IAttacker
	{
		void Attack(Entity target);
	}
}