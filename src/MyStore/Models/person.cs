using System;
using System.Collections.Generic;

namespace MyStore.Models
{
    public partial class person
    {
        public int Person_id { get; set; }
        public string Address { get; set; }
        public string Alley { get; set; }
        public int Amphur { get; set; }
        public string Confirm_password { get; set; }
        public int District { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Moo { get; set; }
        public string Password { get; set; }
        public int Post_code { get; set; }
        public int Province { get; set; }
        public string Road { get; set; }
        public int Status { get; set; }
        public string Username { get; set; }
        public string Village { get; set; }

        public virtual amphur AmphurNavigation { get; set; }
        public virtual district DistrictNavigation { get; set; }
        public virtual province ProvinceNavigation { get; set; }
    }
}
