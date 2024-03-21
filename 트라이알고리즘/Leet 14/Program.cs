public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        List<char> tmpList = new List<char>();

            foreach (var item in strs[0])
            {
                tmpList.Add(item);
            }

            for (int i = 1; i < strs.Length; i++)
            {
                for (int j = 0; j < strs[0].Length; j++)
                {
                    if (j > tmpList.Count - 1)
                        continue;

                    if (j > strs[i].Length - 1)
                    {
                        tmpList.RemoveRange(j,(int)MathF.Abs(tmpList.Count - j));
                        continue;
                    }

                    if (strs[i][j] != tmpList[j])
                    {
                        tmpList.RemoveRange(j, (int)MathF.Abs(tmpList.Count - j));
                        continue;
                    }

                    if (strs[i][j] == tmpList[j])
                        continue;
                }
            }
            string result = "";

                foreach (var item in tmpList)
                {
                    result += item;
                }
            
            Console.WriteLine(result);
            return result;
    }
}