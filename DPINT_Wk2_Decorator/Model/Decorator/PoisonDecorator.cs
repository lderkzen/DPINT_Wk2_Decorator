using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPINT_Wk2_Decorator.Model.Decorator
{
	public class PoisonDecorator : BaseFighterDecorator
	{
		private int _poisonStrength;

		public PoisonDecorator(IFighter fighter, int poisonStrength = 0) : base(fighter)
		{
			_poisonStrength = poisonStrength;
		}

		public override Attack Attack()
		{
			if (_poisonStrength > 0)
			{
				TotalAttack.Messages.Add("Poison weakening, current value: " + _poisonStrength);
				TotalAttack.Value += _poisonStrength;
				_poisonStrength -= 2;
			}
			else
				TotalAttack.Messages.Add("Poison ran out.");
			return NextFighter.Attack();
		}
	} 
}
