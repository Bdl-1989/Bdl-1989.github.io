public class UnionFind{
    private int count;
    private int[] parent;
    public UnionFind(int n){
        this.parent = new int[n];
        for(int i = 0; i < parent.Length; ++i){
            parent[i] = i;
        }
    }
    public int Find(int p){
        if(parent[p] == p) return p;
        parent[p] = Find(parent[p]);
        return parent[p];
    }
    public void Union(int p, int q){
        int rootP = Find(p);
        int rootQ = Find(q);
        if(rootP == rootQ) return;
        parent[rootP] = rootQ;
        count--;
    }
    public bool IsConnected(int p, int q){
        return Find(p) == Find(q);
    }
}