using Save_the_Princess.Attacks.Weapons;

namespace Save_the_Princess.Attacks
{

	public interface IWeaponAttacker : IAttacker
	{
		Weapon Weapon { get; }
	}
}