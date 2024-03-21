public class Solution {
    public IList<string> LetterCombinations(string digits)
    {
        IList<string> list = new List<string>();

        if (digits == "")
            return list;

        Dictionary<int, char[]> dic = new Dictionary<int, char[]>();

        int charNum = 'a';

        for (int i = 2; i <= 9; i++)
        {
            dic.Add(i, null);

            if (i == 7 || i == 9)
                dic[i] = new char[4];

            else
                dic[i] = new char[3];

            for (int j = 0; j < dic[i].Length; j++)
            {
                dic[i][j] = (char)charNum;
                charNum++;
            }
        }

        void Test(int idx, string result)
        {
            if (idx == digits.Length)
            {
                list.Add(result);
                return;
            }

            char[] chars = dic[int.Parse(digits[idx].ToString())];
            for (int i = 0; i < chars.Length; i++)
            {
                Test(idx + 1, result + chars[i]);
            }
        }

        Test(0,"");

        return list;
    }
}