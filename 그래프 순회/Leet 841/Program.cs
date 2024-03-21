public class Solution {
    public bool CanVisitAllRooms(IList<IList<int>> rooms) {
        bool[] visited = new bool[rooms.Count];
            
            Dictionary<int, List<int>> nodes = new Dictionary<int, List<int>>();

            for (int i = 0; i < rooms.Count; i++)
            {
                nodes.Add(i, new List<int>());

                foreach (var next in rooms[i])
                {
                    nodes[i].Add(next);
                }
            }

            visited[0] = true;

            // 갈수있는 방을 전부 돌면서 true를 찍어준다.
            for (int i = 0; i < nodes[0].Count; i++)
            {
                Test(nodes, visited, nodes[0][i]);
            }

            foreach (var value in visited)
            {
                if (!value)
                    return false;
            }

            return true;
    }

    void Test(Dictionary<int, List<int>> eachNodes,bool[] visit,int curr)
        {
            if (visit[curr] == true)
                return;

            List<int> keys = eachNodes[curr];

            visit[curr] = true;

            for (int i = 0; i < keys.Count; i++)
            {
                Test(eachNodes, visit, keys[i]);
            }
        }
}