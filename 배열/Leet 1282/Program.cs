public class Solution {
    public IList<IList<int>> GroupThePeople(int[] groupSizes) {
        Dictionary<int, List<int>> tempDic = new Dictionary<int, List<int>>();

            IList<IList<int>> resultList = new List<IList<int>>();

            for (int i = 0; i < groupSizes.Length; i++)
            {
                List<int> tempList;

                if (!tempDic.ContainsKey(groupSizes[i]))
                    tempDic.Add(groupSizes[i], tempList = new List<int>());

                else
                    tempList = tempDic[groupSizes[i]];

                tempList.Add(i);

                if (groupSizes[i] == tempList.Count)
                {
                    resultList.Add(tempList);
                    tempDic[groupSizes[i]] = new List<int>();
                }
            }

            return resultList;
    }
}