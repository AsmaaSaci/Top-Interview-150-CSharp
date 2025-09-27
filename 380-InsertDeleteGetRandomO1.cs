using System;
using System.Collections.Generic;

public class RandomizedSet {
    private Dictionary<int, int> dict;
    private List<int> list;
    private Random rand;

    public RandomizedSet() {
        dict = new Dictionary<int, int>();
        list = new List<int>();
        rand = new Random();
    }

    public bool Insert(int val) {
        if (dict.ContainsKey(val)) return false;
        dict[val] = list.Count;
        list.Add(val);
        return true;
    }

    public bool Remove(int val) {
        if (!dict.ContainsKey(val)) return false;
        int idx = dict[val];
        int last = list[list.Count - 1];
        list[idx] = last;
        dict[last] = idx;
        list.RemoveAt(list.Count - 1);
        dict.Remove(val);
        return true;
    }

    public int GetRandom() {
        return list[rand.Next(list.Count)];
    }
}
