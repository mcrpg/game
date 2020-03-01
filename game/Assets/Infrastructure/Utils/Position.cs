using System;

using Game.Infrastructure.Models.Interfaces;

namespace Game.Infrastructure.Utils
{
	public class Position : Vector3
	{
		public ILevel level;
	}
}
