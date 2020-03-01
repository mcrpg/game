using System;
using System.Collections.Generic;

using Game.Common.Controller.Interfaces;

namespace Game.Common.Controller
{
	public abstract class BaseController : IController
	{
		public static readonly List<IController> Controllers = new List<IController>();
		
		public static void CallOnEnabled()
		{
			Controllers.ForEach(c => c.OnEnabled());
		}
		
		public static void CallOnDisabled()
		{
			Controllers.ForEach(c => c.OnDisabled());
		}
		
		public static void CallOnUpdate()
		{
			Controllers.ForEach(c => c.OnUpdate());
		}
		
		public abstract void OnEnabled();
		
		public abstract void OnDisabled();
		
		public abstract void OnUpdate();
	}
}
