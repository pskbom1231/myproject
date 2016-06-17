using System;
using System.Collections.Generic;

namespace MyStore.Models
{
    public partial class geography
    {
        public geography()
        {
            amphur = new HashSet<amphur>();
            district = new HashSet<district>();
            province = new HashSet<province>();
        }

        public int GEO_ID { get; set; }
        public string GEO_NAME { get; set; }

        public virtual ICollection<amphur> amphur { get; set; }
        public virtual ICollection<district> district { get; set; }
        public virtual ICollection<province> province { get; set; }
    }
}
