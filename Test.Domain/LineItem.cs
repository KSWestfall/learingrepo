using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Test.Domain
{
    public class LineItem
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Sku { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public string Color { get; set; }
        [Required]
        public int Width { get; set; }
        [Required]
        public int Height { get; set; }
        [Required]
        public string Mount { get; set; }
        [Required]
        public string ControlType { get; set; }
        [Required]
        public string Sidemark { get; set; }
        public string SpecialInstructions { get; set; }
        [Required]
        public string HandSample { get; set; }
        [Required]
        public PoInfo PoInfo { get; set; }
    }
}
