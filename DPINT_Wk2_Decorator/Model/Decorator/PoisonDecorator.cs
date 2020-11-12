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
			var attack = Fighter.Attack();
			if (_poisonStrength > 0)
			{
				attack.Messages.Add("Poison weakening, current value: " + _poisonStrength);
				attack.Value += _poisonStrength;
				_poisonStrength -= 2;
			}
			else
				attack.Messages.Add("Poison ran out.");
			return attack;
		}
	} 
}
