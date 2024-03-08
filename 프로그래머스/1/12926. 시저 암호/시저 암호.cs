using System;

public class Solution {
    public string solution(string s, int n) {
        string answer = "";
        
        for (int i = 0; i < s.Length; i++)
        {
            answer += ChangeSpell(s[i], n);
        }
        //answer = c;
        return answer;
    }
    public char ChangeSpell(char c, int n)
        {
            for(int i = 0; i < n; i++)
            {
                if (c == ' ')
                    return c;
                if (c == 'z')
                {
                    c = 'a'; 
                    n--;
                }
                if (c == 'Z')
                {
                    c = 'A'; 
                    n--;
                }
                if (i < n)
                    c++;
            }
            
            return c;
        }
}