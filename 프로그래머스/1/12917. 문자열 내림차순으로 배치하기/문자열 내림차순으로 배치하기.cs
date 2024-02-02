using System;
using System.Linq;

public class Solution {
    public string solution(string s) {
        string answer = "";
        
        answer = String.Concat(s.OrderBy(ch => ch));
        answer = new string(answer.Reverse().ToArray());
        return answer;
    }
}