using System;

using Game.Common.Model.Interfaces;

using BlockModel = Game.Infrastructure.Models.Block;

namespace Game.Common.Model.Block
{
	public abstract class BlockBase : IInitialized, ICallable, IResult
	{
		public Guid Version { get; set; }
		
		public BlockModel Block { get; set; }
		
		public abstract IResult Initialize();
		
		public abstract IResult Call();
		
		protected BlockBase()
		{
			Version = new Guid();
		}
	}
}
