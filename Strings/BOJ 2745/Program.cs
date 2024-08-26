using System.Text;

namespace BOJ_2745
{
    // 24년 08월 26일
    // 문제 : BOJ 2745 진법 변환
    // url : https://www.acmicpc.net/problem/2745

    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');

            int formation = int.Parse(inputs[1]);
            int result = 0;
            int temp;

            for (int i = 0; i < inputs[0].Length; i++)
            {
                temp = inputs[0][i];

                if (temp >= 65)
                    temp -= 7;

                temp -= 48;

                result += (int)(temp * Math.Pow(formation, inputs[0].Length - 1 - i));
            }
            Console.WriteLine(result);
        }
    }
}
