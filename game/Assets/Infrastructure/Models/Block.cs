using System;
using System.Collections.Generic;

using Game.Infrastructure.DataTransfer;
using Game.Infrastructure.Utils;

namespace Game.Infrastructure.Models
{
	public class Block : DataTransferObject
	{
		public int Id { get; set; }
		
		public Position Position { get; set; }
		
		public string Name { set; get; }
	}
}