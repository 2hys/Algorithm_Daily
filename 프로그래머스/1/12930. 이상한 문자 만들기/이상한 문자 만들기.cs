using System;

public class Solution {
    public string solution(string s) {
        int num = 0;
        string answer = "";
        for(int i = 0; i < s.Length; i++)
        {
            //짝수면 대문자로, 홀수면 소문자로.
            answer += (num % 2 == 0) ? char.ToUpper(s[i]) : char.ToLower(s[i]);
            // space에서는 num번째 자릿수에서 한칸 띄어넘음
            num = s[i] == ' ' ? 0 : num += 1;
        }
        return answer;
        
    }
}