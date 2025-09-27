using System;
using System.Collections.Generic;

public class MedianFinder {
    private List<int> list;

    public MedianFinder() {
        list = new List<int>();
    }

    public void AddNum(int num) {
        int idx = list.BinarySearch(num);
        if (idx < 0) idx = ~idx;
        list.Insert(idx, num);
    }

    public double FindMedian() {
        int n = list.Count;
        if (n % 2 == 1) return list[n / 2];
        return (list[(n - 1) / 2] + list[n / 2]) / 2.0;
    }
}
