using System;

public class Solution {
    public bool solution(string s) {
        if (s.Length != 4 && s.Length != 6)
        {
            Console.WriteLine("길이가 4또는 6이 아닙니다.");
            return false;
        }
        
        for (int i = 0;i < s.Length; i++)
        {
            if (s[i] > '9' || s[i] < '0')
            {
                Console.WriteLine("숫자가 아닙니다.");
                return false;
            }
        }
        return true;
            
    }
}