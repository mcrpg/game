using System;

using Game.Infrastructure.DataTransfer;
using Game.Infrastructure.Models.Interfaces;

namespace Game.Infrastructure.Models
{
	public class Level : DataTransferObject, ILevel
	{
		public string Name { get; set; }
	}
}