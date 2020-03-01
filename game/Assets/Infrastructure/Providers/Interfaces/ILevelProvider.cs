using System;

using Game.Infrastructure.Models;
using Game.Infrastructure.Models.Interfaces;

namespace Game.Infrastructure.Providers.Interfaces
{
	public interface ILevelProvider
	{
		ILevel level { get; set; }
		
		Block GetBlock(int x, int y, int z);
			
		void UnsetBlock(int x, int y, int z);
		
		void UnsetBlock(Block block);
		
		void SetBlock(int x, int y, int z, Block block);
		
		void SetBlock(ILevel level, Block block);
	}
}
