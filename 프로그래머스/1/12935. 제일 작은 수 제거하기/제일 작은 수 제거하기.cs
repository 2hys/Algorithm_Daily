using System.Collections.Generic;
using System.Linq;
using System;

public class Solution {
    public int[] solution(int[] arr) {
        List<int> arr_list = new List<int>(arr);
        int min = arr.Min();
        if (arr_list.Count == 1)
        {
            arr_list.RemoveAll(num => num == min);
            arr_list.Add(-1);
            return arr_list.ToArray();
        }
        arr_list.RemoveAll(num => num == min);
        return arr_list.ToArray();
    }
}