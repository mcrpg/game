using System;

using UnityEngine;

namespace Game.Common
{
	public static class Application
	{
		public static void Log(string message, params object[] objs)
		{
			Debug.Log(string.Format(message, objs));
		}
	}
}
