public class Solution {
    public int RomanToInt(string s) {
        char[] ch = s.ToCharArray();

            int result = 0;
            int intVal, nextIntVal;

            Dictionary<char, int> numDic = new Dictionary<char, int>
            {
                {'I',1 },
                {'V',5 },
                {'X',10 },
                {'L',50 },
                {'C',100 },
                {'D',500 },
                {'M',1000 },
            };

            for (int i = 0; i < ch.Length; i++)
            {
                intVal = numDic[ch[i]];

                if(i != ch.Length - 1)
                {
                    nextIntVal = numDic[ch[i + 1]];

                    if (nextIntVal > intVal)
                    {
                        intVal = nextIntVal - intVal;
                        i++;
                    }
                }
                result += intVal;
            }
            return result;
    }
}