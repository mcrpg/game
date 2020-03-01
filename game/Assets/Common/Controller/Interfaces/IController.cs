
using System;

namespace Game.Common.Controller.Interfaces
{
	public interface IController
	{
		void OnEnabled();
		
		void OnDisabled();
		
		void OnUpdate();
	}
}
