using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPINT_Wk2_Decorator.Model.Decorator
{
	public class StrengthenDecorator : BaseFighterDecorator
	{
		private double _attackMultiplier;
		private double _defenseMultiplier;

		public StrengthenDecorator(IFighter fighter, double attackMultiplier = 1.1, double defenseMultiplier = 1.1) : base(fighter)
		{
			_attackMultiplier = attackMultiplier;
			_defenseMultiplier = defenseMultiplier;
		}

		public override Attack Attack()
		{
			AttackValue = Convert.ToInt32(AttackValue * _attackMultiplier);
			TotalAttack.Messages.Add("Strengthened your attack stat by:" + _attackMultiplier);
			return NextFighter.Attack();
		}

		public override void Defend(Attack attack)
		{
			DefenseValue = Convert.ToInt32(DefenseValue * _defenseMultiplier);
			TotalAttack.Messages.Add("Strengthened your defense stat by:" + _defenseMultiplier);
			NextFighter.Defend(attack);
		}
	}
}
