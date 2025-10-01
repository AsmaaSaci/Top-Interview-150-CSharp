public class Solution {
    public int PeakIndexInMountainArray(int[] arr) {
        int left = 0, right = arr.Length - 1;
        while (left < right) {
            int mid = left + (right - left) / 2;
            if (arr[mid] < arr[mid + 1]) {
                left = mid + 1;
            } else {
                right = mid;
            }
        }
        return left;
    }
}
