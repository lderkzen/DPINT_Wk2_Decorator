using System;

namespace DPINT_Wk2_Decorator.Model.Decorator
{
	public abstract class BaseFighterDecorator : IFighter
	{
		private IFighter _fighter;
		public IFighter Fighter {
			get { return _fighter; }
			set { _fighter = value; }
		}

		public int Lives { get => Fighter.Lives; set => Fighter.Lives = value; }
		public int AttackValue { get => Fighter.AttackValue; set => Fighter.AttackValue = value; }
		public int DefenseValue { get => Fighter.DefenseValue; set => Fighter.DefenseValue = value; }

		public BaseFighterDecorator(IFighter fighter)
		{
			Fighter = fighter;
		}

		public virtual Attack Attack()
		{
			if (!(Fighter is null))
				return Fighter.Attack();
			throw new NullReferenceException();
		}

		public virtual void Defend(Attack attack)
		{
			if (!(Fighter is null))
				Fighter.Defend(attack);
		}
	}
}
