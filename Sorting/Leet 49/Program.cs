public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        
        Dictionary<int,List<string>> dic = new Dictionary<int, List<string>>();

        foreach (string str in strs)
        {
            int total = 0;

            for (int i = 0; i < str.Length; i++)
            {
                total += (int)Math.Pow(str[i],4);
            }

            if(!dic.ContainsKey(total))
                dic.Add(total,new List<string>());

            dic[total].Add(str);

        }

        IList<IList<string>> result = new List<IList<string>>();

        foreach (var item in dic)
        {
            result.Add(item.Value);
        }

        return result;
    }
}