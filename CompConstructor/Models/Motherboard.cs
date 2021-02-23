namespace CompConstructor.Models
{
    public class Motherboard
    {
        public string Name { get; set; }
        public string Socket { get; set; }
        public string Chipset { get; set; }
        public string Format { get; set; }
        public int MemorySlotCount { get; set; }      
        public double MaxMemoryFrequency { get; set; }
    }
}
