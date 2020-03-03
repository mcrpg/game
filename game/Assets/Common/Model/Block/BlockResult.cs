using System;

using Game.Common.Model.Interfaces;

using BlockModel = Game.Infrastructure.Models.Block;

namespace Game.Common.Model.Block
{
	public class BlockResult : IResult
	{
		public Guid Version { get; set; }
		
		public BlockModel Block { get; set; }
		
		public BlockResult()
		{
			Version = new Guid();
		}
		
		public BlockResult(BlockModel block)
		{
			Version = new Guid();
			
			Block = block;
		}
	}
}
