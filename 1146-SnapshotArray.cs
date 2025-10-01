public class SnapshotArray {
    private List<(int snapId, int val)>[] arr;
    private int snapId;

    public SnapshotArray(int length) {
        arr = new List<(int, int)>[length];
        for (int i = 0; i < length; i++) {
            arr[i] = new List<(int, int)>();
            arr[i].Add((0, 0));
        }
        snapId = 0;
    }
    
    public void Set(int index, int val) {
        var list = arr[index];
        if (list[list.Count - 1].snapId == snapId) {
            list[list.Count - 1] = (snapId, val);
        } else {
            list.Add((snapId, val));
        }
    }
    
    public int Snap() {
        return snapId++;
    }
    
    public int Get(int index, int snap_id) {
        var list = arr[index];
        int left = 0, right = list.Count - 1, res = 0;
        while (left <= right) {
            int mid = left + (right - left) / 2;
            if (list[mid].snapId <= snap_id) {
                res = list[mid].val;
                left = mid + 1;
            } else {
                right = mid - 1;
            }
        }
        return res;
    }
}
