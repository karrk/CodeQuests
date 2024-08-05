Solution solution = new Solution();

System.Console.WriteLine(solution.IsPalindrome(0));

public class Solution {
    public bool IsPalindrome(int x) {
        if(x < 0)
            return false;

        if(x == 0)
            return true;

        List<int> ls = new List<int>();

        while (true)
        {
            if(x <= 0)
                break;

            ls.Add(x%10);

            x /= 10;
        }

        for (int i = 0; i <= ls.Count/2; i++)
        {
            if(ls[i] != ls[ls.Count-(1+i)])
                return false;
        }

        return true;
    }
}