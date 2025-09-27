public class Solution {
    public double[] CalcEquation(IList<IList<string>> equations, double[] values, IList<IList<string>> queries) {
        Dictionary<string, Dictionary<string, double>> graph = new Dictionary<string, Dictionary<string, double>>();
        for (int i = 0; i < equations.Count; i++) {
            string a = equations[i][0], b = equations[i][1];
            if (!graph.ContainsKey(a)) graph[a] = new Dictionary<string, double>();
            if (!graph.ContainsKey(b)) graph[b] = new Dictionary<string, double>();
            graph[a][b] = values[i];
            graph[b][a] = 1 / values[i];
        }
        double[] res = new double[queries.Count];
        for (int i = 0; i < queries.Count; i++) {
            string start = queries[i][0], end = queries[i][1];
            HashSet<string> visited = new HashSet<string>();
            res[i] = Dfs(start, end, graph, visited);
        }
        return res;
    }

    private double Dfs(string curr, string target, Dictionary<string, Dictionary<string, double>> graph, HashSet<string> visited) {
        if (!graph.ContainsKey(curr)) return -1.0;
        if (curr == target) return 1.0;
        visited.Add(curr);
        foreach (var kv in graph[curr]) {
            if (!visited.Contains(kv.Key)) {
                double tmp = Dfs(kv.Key, target, graph, visited);
                if (tmp != -1.0) return tmp * kv.Value;
            }
        }
        return -1.0;
    }
}
