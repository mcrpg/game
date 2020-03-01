using System;

using Game.Infrastructure.Models;
using Game.Infrastructure.Models.Interfaces;
using Game.Infrastructure.Providers.Interfaces;

namespace Game.Infrastructure.Providers
{
	public class LevelProvider : ILevelProvider
	{
		public ILevel level { get; set; }
		
		public LevelProvider(ILevel level)
		{
			this.level = level;
		}
		
        public Block GetBlock(int x, int y, int z)
        {
        	throw new NotImplementedException();
        }
        
        public void UnsetBlock(int x, int y, int z)
        {
        	
        }
        
        public void UnsetBlock(Block block)
        {
        	
        }
        
        public void SetBlock(int x, int y, int z, Block block)
        {
        	
        }
        
        public void SetBlock(ILevel level, Block block)
        {
        	
        }
	}
}
