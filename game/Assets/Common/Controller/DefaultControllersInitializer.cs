using System;

using Game.Common.Controller;
using Game.Common.Controller.Interfaces;

namespace Game.Common.Controller
{
	public static class DefaultControllersInitializer
	{
		public static void InitializeAll()
		{
			InitializeControllers(
				new PlayerMovementController(),
				new LevelController()
			);
		}
		
		private static void InitializeControllers(params IController[] controllers)
		{
			foreach(IController c in controllers)
			{
				BaseController.Controllers.Add(c);
			}
		}
	}
}
