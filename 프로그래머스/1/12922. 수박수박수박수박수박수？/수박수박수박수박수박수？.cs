using System.Collections.Generic;

public class Solution {
    public string solution(int n) {
        List<string> answer = new List<string>(){""};
        for (int i = 0; i < n; i++)
        {
            if (i % 2 == 0)
                answer.Add("수");
            else if (i % 2 == 1)
                answer.Add("박");
        }
        string line = string.Join("", answer.ToArray());
        return line;
    }
}