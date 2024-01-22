using System;

public class Solution {
    public int[] solution(int[] arr) {
        int[] answer = new int[arr.Length];
        int[] tmp1 = arr;
        int tmp2;
        if (arr.Length < 2)
        {
            answer[0] = -1;
            return answer;
        }
        //4 3 2 1 -> 4 3 2
        //4 1 3 2 -> 4 3 2 
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
        Array.Sort(tmp1);
        tmp2 = tmp1[0];
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
        for (int i = 0; i < arr.Length; i++)
        {
            // if (arr[i] == tmp2)
            //     i++;
            answer[i] = arr[i];
        }
        
        return answer;
    }
}