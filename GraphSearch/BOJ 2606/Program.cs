namespace BOJ_2606
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            bool[] visited = new bool[input+1];
            bool[,] nodes = new bool[input+1, input+1];
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                int[] temp = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                nodes[temp[0], temp[1]] = true;
                nodes[temp[1], temp[0]] = true;
            }

            Queue<int> queue = new Queue<int>();
            count = -1;

            queue.Enqueue(1);

            while (true)
            {
                if (queue.Count <= 0)
                    break;

                int node = queue.Dequeue();

                if (visited[node])
                    continue;
                
                visited[node] = true;
                count++;

                for (int i = 1; i < nodes.GetLength(0); i++)
                {
                    if (nodes[node, i] && !visited[i])
                        queue.Enqueue(i);
                }
            }

            Console.WriteLine(count);
        }
    }
}
