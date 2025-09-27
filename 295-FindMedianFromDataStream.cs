using System.Collections.Generic;

public class MedianFinder {
    private PriorityQueue<int, int> maxHeap; // left half
    private PriorityQueue<int, int> minHeap; // right half

    public MedianFinder() {
        maxHeap = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b - a)); // max-heap
        minHeap = new PriorityQueue<int, int>(); // min-heap
    }

    public void AddNum(int num) {
        maxHeap.Enqueue(num, num);
        minHeap.Enqueue(maxHeap.Dequeue(), maxHeap.Peek());
        if (maxHeap.Count < minHeap.Count) {
            maxHeap.Enqueue(minHeap.Dequeue(), minHeap.Peek());
        }
    }

    public double FindMedian() {
        if (maxHeap.Count > minHeap.Count) return maxHeap.Peek();
        return (maxHeap.Peek() + minHeap.Peek()) / 2.0;
    }
}
