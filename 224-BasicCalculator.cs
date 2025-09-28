public class Solution {
    public int Calculate(string s) {
        var stack = new Stack<int>();
        int num = 0, sign = 1, result = 0;
        foreach (var c in s) {
            if (char.IsDigit(c)) {
                num = num * 10 + (c - '0');
            } else if (c == '+') {
                result += sign * num;
                num = 0;
                sign = 1;
            } else if (c == '-') {
                result += sign * num;
                num = 0;
                sign = -1;
            } else if (c == '(') {
                stack.Push(result);
                stack.Push(sign);
                result = 0;
                sign = 1;
            } else if (c == ')') {
                result += sign * num;
                num = 0;
                result *= stack.Pop();
                result += stack.Pop();
            }
        }
        return result + sign * num;
    }
}
