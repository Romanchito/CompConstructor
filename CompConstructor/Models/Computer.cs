using System.Collections.Generic;

namespace CompConstructor.Models
{
    public class Computer
    {
        public CPU CPU { get; set; }
        public Motherboard Motherboard { get; set; }
        public Case Case { get; set; }
        public PowerSupply PowerSupply { get; set; }
        public VideoCard VideoCard { get; set; }
        public CoolingSystem CoolingSystem { get; set; }
        public List<MemoryModule> MemoryModules { get; set; }

        public Computer()
        {
            MemoryModules = new List<MemoryModule>();
        }
    }
}
