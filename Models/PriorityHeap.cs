using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalServices.Models
{
    public class PriorityHeap
    {
        private List<ServiceRequest> heap;
        private bool isMinHeap; // true for Min-Heap, false for Max-Heap

        public PriorityHeap(bool isMinHeap = true)
        {
            this.heap = new List<ServiceRequest>();
            this.isMinHeap = isMinHeap;
        }

        private int Compare(ServiceRequest a, ServiceRequest b)
        {
            int aPriority = GetPriorityValue(a.Priority);
            int bPriority = GetPriorityValue(b.Priority);

            // Min-heap: prioritize lower values, Max-heap: prioritize higher values
            return isMinHeap ? aPriority.CompareTo(bPriority) : bPriority.CompareTo(aPriority);
        }

        public void Insert(ServiceRequest request)
        {
            heap.Add(request);
            HeapifyUp(heap.Count - 1);
        }

        public ServiceRequest Extract()
        {
            if (heap.Count == 0)
                throw new InvalidOperationException("Heap is empty.");

            ServiceRequest root = heap[0];
            heap[0] = heap[heap.Count - 1];
            heap.RemoveAt(heap.Count - 1);
            HeapifyDown(0);

            return root;
        }

        private void HeapifyUp(int index)
        {
            int parent = (index - 1) / 2;
            if (index > 0 && Compare(heap[index], heap[parent]) < 0)
            {
                Swap(index, parent);
                HeapifyUp(parent);
            }
        }

        private void HeapifyDown(int index)
        {
            int left = 2 * index + 1;
            int right = 2 * index + 2;
            int smallest = index;

            if (left < heap.Count && Compare(heap[left], heap[smallest]) < 0)
                smallest = left;
            if (right < heap.Count && Compare(heap[right], heap[smallest]) < 0)
                smallest = right;

            if (smallest != index)
            {
                Swap(index, smallest);
                HeapifyDown(smallest);
            }
        }

        private void Swap(int a, int b)
        {
            var temp = heap[a];
            heap[a] = heap[b];
            heap[b] = temp;
        }

        private int GetPriorityValue(string priority)
        {
            if (priority == "High") return 1;
            if (priority == "Medium") return 2;
            if (priority == "Low") return 3;
            return int.MaxValue; // Lowest priority for undefined priorities
        }

    }
}
