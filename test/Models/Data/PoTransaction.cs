using System.ComponentModel.DataAnnotations;

namespace test.Models.Data
{
    public class PoTransaction
    {
        [Key]
        public long sender_id { get; set; }
        public PoInfo po_info { get; set; }
    }
}
