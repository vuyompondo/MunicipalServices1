using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalServices.Models
{
    public class TreeNode
    {
        public ServiceRequest Request { get; set; }
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }

        public TreeNode(ServiceRequest request)
        {
            Request = request;
            Left = null;
            Right = null;
        }
    }
}
