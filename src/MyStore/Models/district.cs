using System;
using System.Collections.Generic;

namespace MyStore.Models
{
    public partial class district
    {
        public district()
        {
            person = new HashSet<person>();
        }

        public int DISTRICT_ID { get; set; }
        public int? AMPHUR_ID { get; set; }
        public string DISTRICT_CODE { get; set; }
        public string DISTRICT_NAME { get; set; }
        public int? GEO_ID { get; set; }
        public int PROVINCE_ID { get; set; }

        public virtual ICollection<person> person { get; set; }
        public virtual amphur AMPHUR { get; set; }
        public virtual geography GEO { get; set; }
        public virtual province PROVINCE { get; set; }
    }
}
