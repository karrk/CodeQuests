public class Solution {
    void FindPaths(int pos, int[][] graph, int dest,IList<int> paths)
        {
            paths.Add(pos);

            if (pos == dest)
            {
                pathsResult.Add(paths);
            }
            else
            {
                int[] otherPaths = graph[pos];

                for (int i = 0; i < otherPaths.Length; i++)
                {
                    FindPaths(otherPaths[i], graph, dest,new List<int>(paths));
                }
            }
        }

        IList<IList<int>> pathsResult = new List<IList<int>>();

        public IList<IList<int>> AllPathsSourceTarget(int[][] graph)
        {
            int current = 0;
            int destination = graph.Length - 1;

            int[] otherPaths = graph[current];

            for (int i = 0; i < graph[current].Length; i++)
            {
                IList<int> tempList = new List<int>() { current };
                FindPaths(otherPaths[i], graph, destination,tempList);
            }

            return pathsResult;
        }
}