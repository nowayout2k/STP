using Save_the_Princess.Attacks.Abilities;

namespace Save_the_Princess.Attacks
{
	
	public interface IAbilityAttacker : IAttacker
	{
		Ability Ability { get; }
	}
}