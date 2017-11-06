using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Test.Domain
{
    public class PoInfo
    {
        public int Id { get; set; }
        public int SenderId { get; set; }
        public int UnitType { get; set; }
        public int Po { get; set; }
        [Required]
        public string Notes { get; set; }
        [Required]
        public string Sidemark { get; set; }
        [Required]
        public string StName { get; set; }
        [Required]
        public string StAddress1 { get; set; }
        public string StAddress2 { get; set; }
        [Required]
        public string StCity { get; set; }
        [Required]
        public string StState { get; set; }
        [Required]
        public string StZip { get; set; }
        [Required]
        public string StPhone { get; set; }
        [Required]
        public IList<LineItem> LineItems { get; set; }
    }
}
