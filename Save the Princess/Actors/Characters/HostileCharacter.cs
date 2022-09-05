using Save_the_Princess.Actors.Movements;
using Save_the_Princess.Attacks;
using Save_the_Princess.Games;
using Save_the_Princess.Utility;

namespace Save_the_Princess.Actors.Characters
{
	//A type of character that has a state and sight distance
	public abstract class HostileCharacter : Character, IAttacker
	{
		public enum HostileState
		{
			Patrol,
			Chase,
			Attack
		}
		
		private Vector3d initialPos;

		//A state that determines what actions this character will take
		protected HostileState state;
		
		//the distance at which this character can see other entities
		protected int sightDistance;
		
		public HostileState State => state;

		protected HostileCharacter(Vector3d position, Vector3d direction, int sightDistance) : base(position, direction)
		{
			initialPos = position;
			state = HostileState.Patrol;
			this.sightDistance = sightDistance;
		}

		~HostileCharacter()
		{
			initialPos = Vector3d.Zero;
			state = HostileState.Patrol;
			sightDistance = 0;
		}

		protected bool CanSee(Entity target)
		{
			return IsFacing(target) && (Position - target.Position).Magnitude <= sightDistance;
		}
 
		private bool IsFacing(Entity target)
		{
			double dot = target.Direction.Dot(target.Position - Position);
			return dot > 0;
		}

		public void ResetPosition()
		{
			//Move back to patrol position
			//this would normally be movement over time but I am just setting it directly for this demo
			position = initialPos;
		}

		private void ChangeState(HostileState newState)
		{
			state = newState;
		}

		//Can this entity see the player?
		public bool OutOfRange()
		{
			return true;
		}

		public override void Update(double deltaTime)
		{
			switch (state)
			{
				case HostileState.Attack:
					if (OutOfRange())
						ChangeState(HostileState.Chase);
					else
					{
						LookAtEntity(Game.Instance.Player);
						Attack(Game.Instance.Player);
					}
					break;
				case HostileState.Chase:
					if (!CanSee(Game.Instance.Player))
						ChangeState(HostileState.Patrol);
					else if(!OutOfRange())
						ChangeState(HostileState.Attack);
					else if (movement is AiMovement m)
					{
						LookAtEntity(Game.Instance.Player);
						position = m.Chase(Game.Instance.Player.Position);
					}
					break;
				case HostileState.Patrol:
					if (!CanSee(Game.Instance.Player))
					{
						ChangeState(HostileState.Chase);
					}
					else if(movement is AiMovement m)
						position = m.Patrol(initialPos);
					break;
			}
		}
		
		
		protected abstract bool CanAttack(Entity target);
		public abstract void Attack(Entity target);
	}
}