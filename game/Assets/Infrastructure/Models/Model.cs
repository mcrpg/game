using System;

using UnityEngine;

using Game.Infrastructure.Models.Interfaces;

namespace Game.Infrastructure.Models
{
	public class Model : IModel
	{
		public static GameObject GameModel;
		
		public GameObject LocalGameModel;
		
		public int Id { protected set; get; }
	}
}
