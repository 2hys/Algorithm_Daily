using System;

public class Solution {
    public int solution(string t, string p) {
        int answer = 0;
        string tmp = "";
        // if (t.Length <= p.Length)
        //     return 0;
        for (int i = 0; i < t.Length - (p.Length - 1); i++)
        {
            for (int j = 0; j < p.Length; j++)
            {
                tmp += t[i + j];
            }
            if (long.Parse(tmp) <= long.Parse(p))
            {
                answer++;
            } 
            tmp = "";
        }
        return answer;
    }
}