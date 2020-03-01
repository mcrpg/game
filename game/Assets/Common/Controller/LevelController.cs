using System;

using Game.Common.Controller.Interfaces;

using Game.Infrastructure.Models;
using Game.Infrastructure.Models.Interfaces;
using Game.Infrastructure.Providers;
using Game.Infrastructure.Providers.Interfaces;

namespace Game.Common.Controller
{
	public sealed class LevelController : BaseController, ILevelController
	{
		private ILevelProvider levelProvider;
		private ILevel level;
		
		public override void OnEnabled()
		{
			level = new Level 
			{
				Name = "Default Level"
			};
			
			levelProvider = new LevelProvider(level);
		}
		
		public override void OnDisabled()
		{
			
		}
		
		public override void OnUpdate()
		{
			
		}
	}
}
