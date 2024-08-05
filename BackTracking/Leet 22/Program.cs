public class Solution {
    public IList<string> GenerateParenthesis(int n) {
        List<string> list = new List<string>();
        DFS(list,n,"",0,0);
        
        return list;
    }

    void DFS(IList<string> list,int n,string str,int left,int right)
    {
        if(str.Length == n*2)
            {
                list.Add(str);
                return;
            }

        if(left < n)
        {
            DFS(list,n,str+"(",left+1,right);
        }
        
        if(left > right)
            DFS(list,n,str+")",left,right+1);

        
    }

}