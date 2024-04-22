using System;

public class Solution {
    
    static string tmp = "";
    static string answer = "";
    public int solution(string s) 
    {
        for (int i = 0; i < s.Length; i++)
        {
            if (Digit(s[i]))
            {
                answer += s[i];
            }
            else
            {
                tmp += s[i];
                Switching();
            }
        }
        return int.Parse(answer);
    }
    
    public bool Digit(char s)
    {
        if (s <= '9' && s >= '0')
            return true;
        return false;
    }
    
    public void Switching()
    {
        if (tmp == "zero")
        {
            answer += "0";
            tmp = "";
        }
        if (tmp == "one")
        {
            answer += "1";
            tmp = "";
        }
        if (tmp == "two")
        {
            answer += "2";
            tmp = "";
        }
        if (tmp == "three")
        {
            answer += "3";
            tmp = "";
        }
        if (tmp == "four")
        {
            answer += "4";
            tmp = "";
        }
        if (tmp == "five")
        {
            answer += "5";
            tmp = "";
        }
        if (tmp == "six")
        {
            answer += "6";
            tmp = "";
        }
        if (tmp == "seven")
        {
            answer += "7";
            tmp = "";
        }
        if (tmp == "eight")
        {
            answer += "8";
            tmp = "";
        }
        if (tmp == "nine")
        {
            answer += "9";
            tmp = "";
        }
    }
}