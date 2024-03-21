public class Solution {
    public int FindJudge(int n, int[][] trust) {
        if (n == 1)
                return 1;

            Dictionary<int, int> idxVotes = new Dictionary<int, int>();
            HashSet<int> people = new HashSet<int>();

            for (int i = 0; i < trust.GetLength(0); i++)
            {
                if (!idxVotes.ContainsKey(trust[i][1])) 

                    idxVotes.Add(trust[i][1], 0);

                idxVotes[trust[i][1]]++;

                people.Add(trust[i][0]);
            }

            int judgeLabel = -1;

            foreach (KeyValuePair<int, int> item in idxVotes)
            {
                if (item.Value == n - 1 && !people.Contains(item.Key))
                    judgeLabel = item.Key;
            }
            
            return judgeLabel;
    }
}