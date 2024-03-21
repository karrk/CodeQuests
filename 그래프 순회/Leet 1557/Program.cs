public class Solution {
    public IList<int> FindSmallestSetOfVertices(int n, IList<IList<int>> edges) {
        IList<int> result = new List<int>();
            HashSet<int> temp = new HashSet<int>();

            foreach (var nodes in edges)
            {
                temp.Add(nodes[1]);
            }

            for (int i = 0; i < n; i++)
            {
                if (!temp.Contains(i))
                    result.Add(i);

                if (result.Count == n - temp.Count)
                    break;
            }

            return result;

    }
}