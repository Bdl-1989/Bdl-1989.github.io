public class FenwickTree{
    private int len;
    private int[] tree;
    public FenwickTree(int n){
        this.len = n;
        this.tree = new int(n + 1);
    }
    public FenwickTree(int[] nums){
        this.len = nums.Length;
        this.tree = new int[len + 1];
        for(int i = 1; i < tree.Length; ++i){
            update(i, num[i]);
        }
    }
    public void Update(int i, int delta){
        while(i <= this.len){
            tree[i] += delta;
            i += lowBit(i);
        }
    }
    public int Query(int i){
        int sum = 0;
        while(i > 0){
            sum += tree[i];
            i -= lowBit(i);
        }
    }
    private int lowBit(int x) => x & (-x);
}