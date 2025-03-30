// 25/03/30
// BOJ 3046
// URL : https://www.acmicpc.net/problem/3046

// S = (R1 + R2)/2
// S = R1/2 + R2/2
// R2/2 = -R1/2 +S
// R2 = 2S - R1

int[] input = Array.ConvertAll(Console.ReadLine().Split(' '),int.Parse);
System.Console.WriteLine(2*input[1] - input[0]);
