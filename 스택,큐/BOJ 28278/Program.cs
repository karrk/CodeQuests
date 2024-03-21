StreamReader reader = new StreamReader(Console.OpenStandardInput());
StreamWriter writer = new StreamWriter(Console.OpenStandardOutput());

int count = int.Parse(reader.ReadLine());

Stack<int> st = new Stack<int>();

for (int i = 0; i < count; i++)
{
    string[] input = reader.ReadLine().Split(' ');

    if(input[0] == "1")
    {
        st.Push(int.Parse(input[1]));
    }
    else if(input[0] == "2")
    {
        if(st.Count > 0)
            writer.WriteLine(st.Pop());
        else
            writer.WriteLine(-1);
    }    
    else if(input[0] == "3")
    {
         writer.WriteLine(st.Count);
    }    
    else if(input[0] == "4")
    {
        if(st.Count > 0)
           writer.WriteLine(0);
        else
            writer.WriteLine(1);
    }    
    else
    {
        if(st.Count > 0)
            writer.WriteLine(st.Peek());
        else
            writer.WriteLine(-1);
    }  
}

writer.Flush();