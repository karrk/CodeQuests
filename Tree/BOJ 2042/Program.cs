Solution1 s = new Solution1();
s.Solution();

public class Solution1
{
    public void Solution()
    {

        long[] input = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);

        long n = input[0]; // 수의 개수
        long m = input[1]; // 수 변경횟수
        long k = input[2]; // 구간합 실행 횟수

        long minK = 1;

        while (true)
        {
            if (Math.Pow(2, minK) >= n + 1)
                break;

            minK++;
        }

        long[] tree = new long[(long)(Math.Pow(2, minK) * 2)];

        for (long i = (long)Math.Pow(2, minK); i < (long)Math.Pow(2, minK) + n; i++)
            tree[i] = long.Parse(Console.ReadLine());


        for (long i = (long)Math.Pow(2, minK) + n; i > 1; i--)
        {
            tree[i / 2] += tree[i];
        }

        long inputCount = 0;

        while (true)
        {
            if (inputCount >= m + k)
                break;

            input = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);

            if (input[0] == 1)
            {
                long targetIdx = input[1];
                long changeNum = input[2];

                long gap = tree[targetIdx + (long)Math.Pow(2, minK) - 1] - changeNum;
                long tempIdx = targetIdx + (long)Math.Pow(2, minK) - 1;

                tree[tempIdx] = changeNum;

                while (true)
                {
                    tempIdx /= 2;

                    tree[tempIdx] -= gap;

                    if (tempIdx == 1)
                        break;
                }
            }

            else
            {
                long start = input[1] + (long)Math.Pow(2, minK) - 1;
                long end = input[2] + (long)Math.Pow(2, minK) - 1;

                long value = 0;

                while (start <= end)
                {
                    if (start % 2 == 1) // start가 홀수이면 왼쪽 경계에 있는 것이므로 값을 더하고 한 단계 오른쪽으로 이동
                    {
                        value += tree[start];
                        start = (start + 1) / 2;
                    }
                    else
                    {
                        start /= 2;
                    }

                    if (end % 2 == 0) // end가 짝수이면 오른쪽 경계에 있는 것이므로 값을 더하고 한 단계 왼쪽으로 이동
                    {
                        value += tree[end];
                        end = (end - 1) / 2;
                    }
                    else
                    {
                        end /= 2;
                    }
                }
                System.Console.WriteLine(value);
            }

            inputCount++;
        }
    }
}
