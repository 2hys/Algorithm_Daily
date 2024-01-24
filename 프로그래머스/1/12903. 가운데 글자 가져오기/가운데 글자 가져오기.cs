using System;

public class Solution {
    public string solution(string s) {
        var answer = "";
        
        if (s.Length % 2 == 1)
        {
            answer = s[(s.Length / 2)].ToString();
        }
        
        else if (s.Length % 2 == 0)
        {
            answer = s[(s.Length / 2) - 1].ToString() + s[(s.Length / 2)].ToString();
            //answer = answer + s[(s.Length / 2)].ToString();
        }
        
        return answer;
    }
}