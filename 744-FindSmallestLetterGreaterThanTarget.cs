public class Solution {
    public char NextGreatestLetter(char[] letters, char target) {
        int left = 0, right = letters.Length - 1;
        while (left <= right) {
            int mid = left + (right - left) / 2;
            if (letters[mid] <= target) left = mid + 1;
            else right = mid - 1;
        }
        return left < letters.Length ? letters[left] : letters[0];
    }
}
