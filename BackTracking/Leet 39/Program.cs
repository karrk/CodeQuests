public class Solution {
    public IList<IList<int>> CombinationSum(int[] candidates, int target) 
    {
        IList<IList<int>> result = new List<IList<int>>();

        DFS(candidates, 0, 0, target, result,new List<int>());

        return result;

    }

    void DFS(int[] candidate, int currentSum, int currentIdx, int target, IList<IList<int>> result, List<int> currentList)
    {
        if(currentSum > target)
            return;

        if(currentSum == target)
        {
            result.Add(new List<int>(currentList));
            return;
        }

        for (int i = currentIdx; i < candidate.Length; i++)
        {
            currentList.Add(candidate[i]);
            DFS(candidate, currentSum+candidate[i],i,target,result,currentList);
            currentList.RemoveAt(currentList.Count-1);
        }
    }
}