using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] arr, int divisor) {
        int[] answer = new int[arr.Length];
        int j = 0;
        for(int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % divisor == 0)
            {
                answer[j++] = arr[i];
            }
        }
        int[] a = new int[1];
        a[0] = -1;
        if (answer[0] == 0)
            return a;
        int[] newArray = answer.Except(new int[] { 0 }).ToArray();
        Array.Sort(newArray);
        return newArray;
    }
}