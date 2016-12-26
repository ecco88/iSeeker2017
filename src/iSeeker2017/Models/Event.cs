using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iSeeker2017.Models
{
    public class Event
    {
        public int ID { get; set; }
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public String Name { get; set; }
    }

    public  class Auction : Event
    {
        public String Description { get; set; }
    }

    public class Location
    {
        public int ID { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
    }

    public class Task : Auction
    {
        public Location Location { get; set; }
    }

    public class Project : Task
    {
        public String Name { get; set; }
    }

}