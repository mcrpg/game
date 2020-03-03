using System;

using Game.Infrastructure.Utils;
using BlockModel = Game.Infrastructure.Models.Block;

namespace Game.Common.Model.Block
{
	public static class BlockFactory
	{
		public static BlockModel Create()
		{
			return new BlockModel();
		}
		
		public static BlockModel WithId(this BlockModel block, int id)
		{
			block.Id = id;
			
			return block;
		}
		
		public static BlockModel WithName(this BlockModel block, string name)
		{
			block.Name = name;
			
			return block;
		}
		
		public static BlockModel WithPosition(this BlockModel block, Position pos)
		{
			block.Position = pos;
			
			return block;
		}
	}
}
