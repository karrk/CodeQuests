Dictionary<string,float> dic = new Dictionary<string, float>{
    {"A+",4.5f},
    {"A0",4f},
    {"B+",3.5f},
    {"B0",3f},
    {"C+",2.5f},
    {"C0",2f},
    {"D+",1.5f},
    {"D0",1f},
    {"F",0f},
};

float sumValue = 0;
float totalAvg = 0;

for (int i = 0; i < 20; i++)
{
    string[] input = Console.ReadLine().Split(' ');

    if(input[2] == "P")
        continue;

    sumValue += float.Parse(input[1]);
    totalAvg += float.Parse(input[1]) * dic[input[2]];
}

System.Console.WriteLine(totalAvg/sumValue);
