using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalServices.Models
{
    public class Announcement
    {
        public string Title { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
        public bool IsImportant { get; set; }  // Add this property to indicate if it's important

        public Announcement(string title, string message, DateTime date, bool isImportant = false)
        {
            Title = title;
            Message = message;
            Date = date;
            IsImportant = isImportant;
        }
    }
}
