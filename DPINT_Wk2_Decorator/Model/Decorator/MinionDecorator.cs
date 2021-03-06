﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPINT_Wk2_Decorator.Model.Decorator
{
	public class MinionDecorator : BaseFighterDecorator
	{
		private int _minionLives;
		private int _minionAttackValue;

		public MinionDecorator(IFighter fighter, int minionLives = 0, int minionAttackValue = 0) : base(fighter)
		{
			_minionLives = minionLives;
			_minionAttackValue = minionAttackValue;
		}

		public override Attack Attack()
		{
			var attack = Fighter.Attack();
			if (_minionLives > 0)
			{
				attack.Messages.Add("Minion helping the attack: " + _minionAttackValue);
				attack.Value += _minionAttackValue;
			}
			return attack;
		}

		public override void Defend(Attack attack)
		{
			if (_minionLives > 0)
			{
				int tmpLives = _minionLives;
				_minionLives -= Math.Max(0, attack.Value);
				attack.Value -= Math.Max(0, tmpLives - _minionLives);
				attack.Messages.Add("Minion defended from the attack: -" + attack.Value);
			}
			Fighter.Defend(attack);
		}
	}
}
