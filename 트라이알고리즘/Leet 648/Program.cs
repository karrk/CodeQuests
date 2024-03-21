using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;

class Node
{
    public Node[] children = new Node[26];
    public bool isEnd = false;

    public Node()
    {
        for (int i = 0; i < 26; i++)
        {
            children[i] = null;
        }

    }
}

public class Solution {
    public string ReplaceWords(IList<string> dictionary, string sentence) {
        Node node = new Node();

        for (int i = 0; i < dictionary.Count; i++)
        {
            Insert(node, dictionary[i]);
        }

        StringBuilder result = new StringBuilder();

        string[] strs = sentence.Split(' ');

        for (int i = 0; i < strs.Length; i++)
        {
            result.Append(Search(node, strs[i]));

            if (i != strs.Length - 1)
                result.Append(" ");
        }

        return result.ToString();
    }

    void Insert(Node node,string str)
    {
        for (int i = 0; i < str.Length; i++)
        {
            int point = str[i] - 'a';

            if (node.children[point] == null)
                node.children[point] = new Node();

            node = node.children[point];
        }
        node.isEnd = true;
    }

    string Search(Node node,string target)
    {
        StringBuilder answer = new StringBuilder();
        
        for (int i = 0; i < target.Length; i++)
        {
            int point = target[i] - 'a';

            if (node.children[point] == null)
                return target;

            answer.Append((char)(point+'a'));

            node = node.children[point];

            if (node.isEnd)
                break;
        }

        return answer.ToString();
    }
}