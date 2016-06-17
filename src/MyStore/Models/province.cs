using System;
using System.Collections.Generic;

namespace MyStore.Models
{
    public partial class province
    {
        public province()
        {
            amphur = new HashSet<amphur>();
            district = new HashSet<district>();
            person = new HashSet<person>();
        }

        public int PROVINCE_ID { get; set; }
        public int? GEO_ID { get; set; }
        public string PROVINCE_CODE { get; set; }
        public string PROVINCE_NAME { get; set; }

        public virtual ICollection<amphur> amphur { get; set; }
        public virtual ICollection<district> district { get; set; }
        public virtual ICollection<person> person { get; set; }
        public virtual geography GEO { get; set; }
    }
}
