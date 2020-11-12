using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPINT_Wk2_Decorator.Model.Decorator
{
	public class ShotgunDecorator : BaseFighterDecorator
	{
		private int _shotgunRoundsFired;

		public ShotgunDecorator(IFighter fighter, int shotgunRoundsFired = 0) : base(fighter)
		{
			_shotgunRoundsFired = shotgunRoundsFired;
		}

		public override Attack Attack()
		{
			var attack = Fighter.Attack();
			if (_shotgunRoundsFired < 2)
			{
				attack.Messages.Add("Shotgun: 20");
				attack.Value += 20;
				_shotgunRoundsFired++;
			}
			else
			{
				attack.Messages.Add("Shotgun reloading, no extra damage.");
				_shotgunRoundsFired = 0;
			}
			return attack;
		}
	}
}
