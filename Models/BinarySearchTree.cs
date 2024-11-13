using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MunicipalServices.Models
{
    public class BinarySearchTree
    {
        private TreeNode root;

        private class TreeNode
        {
            public ServiceRequest Request;
            public TreeNode Left;
            public TreeNode Right;

            public TreeNode(ServiceRequest request)
            {
                Request = request;
                Left = null;
                Right = null;
            }
        }

        public void Insert(ServiceRequest request)
        {
            root = InsertRec(root, request);
        }

        private TreeNode InsertRec(TreeNode root, ServiceRequest request)
        {
            if (root == null)
            {
                root = new TreeNode(request);
                return root;
            }

            if (request.RequestId < root.Request.RequestId)
                root.Left = InsertRec(root.Left, request);
            else if (request.RequestId > root.Request.RequestId)
                root.Right = InsertRec(root.Right, request);

            return root;
        }

        // Method to perform in-order traversal
        public List<ServiceRequest> InOrderTraversal()
        {
            var result = new List<ServiceRequest>();
            InOrderTraversal(root, result);
            return result;
        }

        private void InOrderTraversal(TreeNode node, List<ServiceRequest> result)
        {
            if (node != null)
            {
                InOrderTraversal(node.Left, result);
                result.Add(node.Request);
                InOrderTraversal(node.Right, result);
            }
        }

        // Search method for service requests
        public List<ServiceRequest> Search(string searchTerm)
        {
            List<ServiceRequest> results = new List<ServiceRequest>();
            SearchRec(root, searchTerm, results);
            return results;
        }

        private void SearchRec(TreeNode root, string searchTerm, List<ServiceRequest> results)
        {
            if (root != null)
            {
                // Check the current node for matches
                if (root.Request.Description.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0 ||
            root.Request.Category.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0 ||
            root.Request.RequestId.ToString().IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0 ||
            root.Request.Location.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0 ||
            root.Request.DateReported.ToShortDateString().IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    results.Add(root.Request);
                }
                // Search left and right
                SearchRec(root.Left, searchTerm, results);
                SearchRec(root.Right, searchTerm, results);
            }
        }
    }
}

