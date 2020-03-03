using System;

using Game.Common.Model.Interfaces;
using Game.Common.Structure;

namespace Game.Common.Model.Block
{
	public class StoneBlock : BlockBase
	{
		public const string NAME = "Stone Block";
		
		public override IResult Initialize()
		{
			Block = BlockFactory.Create().WithId(BlocksIdentifiers.BLOCK_STONE).WithName(NAME);
			
			return this;
		}
		
		public override IResult Call()
		{
			return this;
		}
	}
}
