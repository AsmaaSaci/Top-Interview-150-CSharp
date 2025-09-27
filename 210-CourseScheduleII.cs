public class Solution {
    public int[] FindOrder(int numCourses, int[][] prerequisites) {
        List<int>[] graph = new List<int>[numCourses];
        for (int i = 0; i < numCourses; i++) graph[i] = new List<int>();
        foreach (var pre in prerequisites) graph[pre[1]].Add(pre[0]);
        bool[] visited = new bool[numCourses];
        bool[] recStack = new bool[numCourses];
        List<int> order = new List<int>();

        bool Dfs(int node) {
            if (recStack[node]) return false;
            if (visited[node]) return true;
            visited[node] = true;
            recStack[node] = true;
            foreach (var nei in graph[node]) {
                if (!Dfs(nei)) return false;
            }
            recStack[node] = false;
            order.Add(node);
            return true;
        }

        for (int i = 0; i < numCourses; i++) {
            if (!Dfs(i)) return new int[0];
        }
        order.Reverse();
        return order.ToArray();
    }
}
