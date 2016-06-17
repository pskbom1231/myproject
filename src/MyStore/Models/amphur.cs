using System;
using System.Collections.Generic;

namespace MyStore.Models
{
    public partial class amphur
    {
        public amphur()
        {
            district = new HashSet<district>();
            person = new HashSet<person>();
        }

        public int AMPHUR_ID { get; set; }
        public string AMPHUR_CODE { get; set; }
        public string AMPHUR_NAME { get; set; }
        public int? GEO_ID { get; set; }
        public int PROVINCE_ID { get; set; }

        public virtual ICollection<district> district { get; set; }
        public virtual ICollection<person> person { get; set; }
        public virtual geography GEO { get; set; }
        public virtual province PROVINCE { get; set; }
    }
}
