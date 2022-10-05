public class Solution {
    public bool IsValid(string s) 
    {   
        Dictionary<char, char> hash = new Dictionary<char, char> 
        {
            {'(',')'},
            {'{','}'},
            {'[',']'},
        };
​
        Stack<char> stack = new Stack<char>();
​
        foreach (char item in s)
        {
            if (stack.Count != 0 && hash.ContainsKey(stack.Peek()) && hash[stack.Peek()] == item)
                stack.Pop();
            else
                stack.Push(item);
        }
  
        return stack.Count == 0? true:false;
​
    }
}
  
    
