public class TimeMap {

    private Dictionary<string, List<(int time, string val)>> store;
    public TimeMap() {
        store = new Dictionary<string, List<(int, string)>>();
    }
    
    public void Set(string key, string value, int timestamp) {
        if (!store.ContainsKey(key))
        {
            store[key] = new List<(int, string)>();
        }
        store[key].Add((timestamp, value));
    }
    
    public string Get(string key, int timestamp) {
        if (!store.ContainsKey(key)) return "";
        
        var list = store[key];

        int left = 0;
        int right = list.Count - 1;

        string res = "";

        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (list[mid].time <= timestamp)
            {
                res = list[mid].val;
                left = mid + 1;
            } else 
            {
                right = mid - 1;
            }
        }
        return res;
    }
}
