using System.ComponentModel.DataAnnotations;

namespace test.Models.Data
{
    public class LineItem
    {
        [Key]
        public int Id { get; set; }
        public long PoInfoId { get; set; }
        public string sku { get; set; }
        public string model { get; set; }
        public int quantity { get; set; }
        public string color { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public string mount { get; set; }
        public string control_type { get; set; }
        public string sidemark { get; set; }
        public string special_instructions { get; set; }
        public string hand_sample { get; set; }
    }
}
