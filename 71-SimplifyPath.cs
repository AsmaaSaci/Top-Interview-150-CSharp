public class Solution {
    public string SimplifyPath(string path) {
        var stack = new Stack<string>();
        var parts = path.Split('/', StringSplitOptions.RemoveEmptyEntries);
        foreach (var part in parts) {
            if (part == ".") continue;
            if (part == "..") {
                if (stack.Count > 0) stack.Pop();
            } else {
                stack.Push(part);
            }
        }
        var result = "/" + string.Join("/", stack.Reverse());
        return result;
    }
}
