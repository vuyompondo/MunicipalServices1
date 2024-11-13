using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalServices.Models
{
    // Define the event class
    public class Event
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }

        public Event(string name, DateTime date, string location, string description)
        {
            Name = name;
            Date = date;
            Location = location;
            Description = description;
        }
    }
}
