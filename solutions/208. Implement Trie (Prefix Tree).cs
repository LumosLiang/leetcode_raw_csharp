public class TrieNode
{
    public TrieNode[] table;
    public bool isEnd;
    public TrieNode()
    {
        table = new TrieNode[26];
        isEnd = false;
    }
}
​
public class Trie {
​
    public TrieNode head;
​
    public Trie() {
        head = new TrieNode();
    }
    
    public void Insert(string word) {
        var curr = head;
        foreach(var c in word)
        {
            var idx = c - 'a';
            if(curr.table[idx] == null) 
                curr.table[idx] = new TrieNode();
            curr = curr.table[idx];
        }
        curr.isEnd = true;
    }
    
    public bool Search(string word) {
        var curr = head;
        foreach(var c in word)
        {
            var idx = c - 'a';
            if(curr.table[idx] == null) 
                return false;
            curr = curr.table[idx];
        }
        return curr.isEnd;
    }
    
    public bool StartsWith(string prefix) {
        var curr = head;
        foreach(var c in prefix)
        {
            var idx = c - 'a';
            if(curr.table[idx] == null) 
                return false;
            curr = curr.table[idx];
        }
        return true;
    }
}
​
/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */
