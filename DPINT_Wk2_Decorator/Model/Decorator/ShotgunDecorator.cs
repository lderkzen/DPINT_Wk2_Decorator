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
			if (_shotgunRoundsFired < 2)
			{
				TotalAttack.Messages.Add("Shotgun: 20");
				TotalAttack.Value += 20;
				_shotgunRoundsFired++;
			}
			else
			{
				TotalAttack.Messages.Add("Shotgun reloading, no extra damage.");
				_shotgunRoundsFired = 0;
			}
			return NextFighter.Attack();
		}
	}
}
