public class Trie{
    private bool isEnd;
    private Trie[] next;
    public Trie(){
        this.isEnd = true;
        this.next = new Trie[26];
    }
    public void Insert(string word){
        if(word == null || word.Length == 0) return;
        Trie cur = this;
        for(int i = 0; i < word.Length; ++i){
            int tmp = word[i] - 'a';
            if(cur.next[tmp] == null) cur.next[tmp] = new Trie();
            cur = cur.next[tmp];
        }
        cur.isEnd = true;
    }
    public bool Search(string word){
        Trie node = searchPrefix(word);
        return node != null && node.isEnd = true;
    }
    public bool StartWith(string prefix){
        Trie node = searchPrefix(word);
        return node != null
    }
    private Trie searchPrefix(string prefix){
        Trie node = this;
        for(int i = 0; i < prefix.Length; ++i){
            node = node.next[prefix[i] - 'a'];
            if(node == null) return null;
        }
        return node;
    }
}