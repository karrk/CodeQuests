int stars = int.Parse(Console.ReadLine());

float[,] arr = new float[stars,2];

Dictionary<(float,float),int> visited = new Dictionary<(float, float), int>();

PriorityQueue<(float,float,float),float> pq = 
    new PriorityQueue<(float, float, float), float>();

for (int i = 0; i < stars; i++)
{
    float[] input = Array.ConvertAll(Console.ReadLine().Split(' '),float.Parse);

    arr[i,0] = input[0];
    arr[i,1] = input[1];

    visited.Add((input[0],input[1]),0);
}

pq.Enqueue((arr[0,0],arr[0,1],0),0);

float distance = 0;

while (true)
{
    if(stars <= 0)
        break;

    var temp = pq.Dequeue();

    float cur_x = temp.Item1;
    float cur_y = temp.Item2;
    
    if(visited[(cur_x,cur_y)] == 1)
        continue;

    visited[(cur_x,cur_y)] = 1;
   
    stars--;
    distance += temp.Item3;

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        float temp_x = arr[i,0];
        float temp_y = arr[i,1];

        if(visited[(temp_x,temp_y)] == 1)
            continue;

        float tempDist_x = Math.Abs(cur_x - temp_x);
        float tempDist_y = Math.Abs(cur_y - temp_y);

        float hypotenuse =
        (float)Math.Sqrt(Math.Pow(tempDist_x,2)+Math.Pow(tempDist_y,2));

        pq.Enqueue((temp_x,temp_y,hypotenuse),hypotenuse);
    }
}

System.Console.WriteLine(distance);