using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPINT_Wk2_Decorator.Model.Decorator
{
	public abstract class BaseFighterDecorator : IFighter
	{
		private IFighter _nextFighter;
		protected IFighter NextFighter {
			get { return _nextFighter; }
			set { _nextFighter = value; }
		}

		private Attack _totalAttack;
		protected Attack TotalAttack {
			get { return _totalAttack; }
			set { _totalAttack = value; }
		}

		private int _lives;
		public int Lives {
			get { return _lives; }
			set { _lives = value; }
		}
		private int _attackValue;
		public int AttackValue {
			get { return _attackValue; }
			set { _attackValue = value; }
		}
		private int _defenseValue;
		public int DefenseValue {
			get { return _defenseValue; }
			set { _defenseValue = value; }
		}

		public BaseFighterDecorator(IFighter fighter)
		{
			NextFighter = fighter;
		}

		public virtual Attack Attack()
		{
			return _nextFighter.Attack();
		}

		public virtual void Defend(Attack attack)
		{
			_nextFighter.Defend(attack);
		}
	}
}
