using System.ComponentModel.DataAnnotations;

namespace Test.Domain
{
    public class LineItem
    {
        [Key]
        public int Id { get; set; }
        public long PoInfoId { get; set; }
        public string Sku { get; set; }
        public string Model { get; set; }
        public int Quantity { get; set; }
        public string Color { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string Mount { get; set; }
        public string ControlType { get; set; }
        public string Sidemark { get; set; }
        public string SpecialInstructions { get; set; }
        public string HandSample { get; set; }
        public virtual PoInfo PoInfo { get; set; }
    }
}
