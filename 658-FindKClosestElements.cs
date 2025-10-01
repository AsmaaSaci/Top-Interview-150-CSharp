public class Solution {
    public IList<int> FindClosestElements(int[] arr, int k, int x) {
        int n = arr.Length;
        int left = 0, right = n - k;
        
        while (left < right) {
            int mid = left + (right - left) / 2;
            if (x - arr[mid] > arr[mid + k] - x) {
                left = mid + 1;
            } else {
                right = mid;
            }
        }
        
        List<int> result = new List<int>();
        for (int i = left; i < left + k; i++) {
            result.Add(arr[i]);
        }
        return result;
    }
}
