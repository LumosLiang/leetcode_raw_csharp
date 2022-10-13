public class Solution {
    public int LadderLength(string beginWord, string endWord, IList<string> wordList) {
    
        if(beginWord == endWord || !wordList.Contains(endWord) || beginWord.Length != endWord.Length) return 0;
​
        HashSet<string> wordListSet = new HashSet<string>(wordList), visited = new HashSet<string>();
        
        var q = new Queue<string>();
        q.Enqueue(beginWord);
        visited.Add(beginWord);
        
        var res = 1;
        var alphabets = "abcdefghijklmnopqrstuvwxyz";
        
        while(q.Count != 0)
        {
            var temp = new Queue<string>();
            while(q.Count != 0)
            {
                string currWord = q.Dequeue();
​
                for(int i = 0; i < currWord.Length; i++)
                {
                    var currWordSb = new StringBuilder(currWord);
                    for(int j = 0; j < alphabets.Length; j++)
                    {
                        currWordSb[i] = alphabets[j];
                        var tempString = currWordSb.ToString();
                        // Console.WriteLine(tempString);
                        if(tempString == endWord) 
                            return res + 1;
                        if(wordListSet.Contains(tempString) && !visited.Contains(tempString))
                        {
                            temp.Enqueue(tempString);
                            visited.Add(tempString);
                        }
                    }
                }
            }
            
            q = temp;
            res++;
        }
        
        return 0;
    }
}
