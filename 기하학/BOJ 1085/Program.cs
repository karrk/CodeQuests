string[] input = Console.ReadLine().Split(' ');

int x = int.Parse(input[0]);
int y = int.Parse(input[1]);
int w = int.Parse(input[2]);
int h = int.Parse(input[3]);

int distance = int.MaxValue;

if(x < distance)
    distance = x;

if(y < distance)
    distance = y;

if(w-x < distance)
    distance = w-x;

if(h-y < distance)
    distance = h-y;

System.Console.WriteLine( distance);