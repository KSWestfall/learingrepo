using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Test.Domain
{
    public class PoTransaction
    {
        [Key]
        public long SenderId { get; set; }
        public IList<PoInfo> PoInfo { get; set; }
    }
}
