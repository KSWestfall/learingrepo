using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace test.Models.Data
{
    public class PoInfo
    {
        [ForeignKey("line_items")]
        public int Id { get; set; }
        public int unit_type { get; set; }
        public int po { get; set; }
        public string notes { get; set; }
        public string sidemark { get; set; }
        public string st_name { get; set; }
        public string st_address1 { get; set; }
        public string st_address2 { get; set; }
        public string st_city { get; set; }
        public string st_state { get; set; }
        public string st_zip { get; set; }
        public string st_phone { get; set; }
        public List<LineItem> line_items { get; set; }
    }
}
