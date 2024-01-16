using System;

public class Solution {
    public long solution(long n) {
        long answer = 0;
        char[] tmp1 = n.ToString().ToCharArray();
        Array.Sort(tmp1);
        Array.Reverse(tmp1);
        //answer = Convert.ToInt64(new string(tmp1));
        
        answer = long.Parse(tmp1);
        return answer;
    }
}