using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPINT_Wk2_Decorator.Model.Decorator
{
	public class DoubleHandedDecorator : BaseFighterDecorator
	{
		public DoubleHandedDecorator(IFighter fighter) : base(fighter) { }

		public override Attack Attack()
		{
			TotalAttack.Value += AttackValue;
			TotalAttack.Messages.Add("Doubled the original attack value: " + AttackValue);
			return NextFighter.Attack();
		}

		public override void Defend(Attack attack)
		{
			TotalAttack.Messages.Add("One hand defended the attack: -" + DefenseValue);
			TotalAttack.Value -= DefenseValue;
			NextFighter.Defend(attack);
		}
	}
}
