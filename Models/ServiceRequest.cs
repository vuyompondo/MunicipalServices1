using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalServices.Models
{
    public class ServiceRequest
    {
        public int RequestId { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public DateTime DateReported { get; set; }
        public DateTime? EstimatedCompletion { get; set; }
        public string Priority { get; set; }
        public string Location { get; set; }

        public ServiceRequest(int requestId, string category, string description, string status, DateTime dateReported, DateTime? estimatedCompletion, string priority, string location)
        {
            RequestId = requestId;
            Category = category;
            Description = description;
            Status = status;
            DateReported = dateReported;
            EstimatedCompletion = estimatedCompletion;
            Priority = priority;
            Location = location;
        }
    }

}
