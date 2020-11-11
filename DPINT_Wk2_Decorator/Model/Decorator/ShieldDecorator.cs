using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPINT_Wk2_Decorator.Model.Decorator
{
	public class ShieldDecorator : BaseFighterDecorator
	{
		private int _shieldDefends;

		public ShieldDecorator(IFighter fighter, int shieldDefends = 0) : base(fighter)
		{
			_shieldDefends = shieldDefends;
		}

		public override void Defend(Attack attack)
		{
			if (_shieldDefends > 0)
			{
				attack.Messages.Add("Shield protected, attack value = 0");
				attack.Value = 0;
				_shieldDefends--;
			}
			NextFighter.Defend(attack);
		}
	}
}
