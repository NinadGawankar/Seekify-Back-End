using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Location
    {
        [Key]
        public int id { get; set; }
        public required string location_name { get; set; }
        public required string location_address { get; set; }
        public required string contact_number { get; set; }
        public required string opening_time { get; set; }
        public required string ending_time { get; set; }
    }
}
