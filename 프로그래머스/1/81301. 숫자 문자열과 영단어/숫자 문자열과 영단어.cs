using System;

public class Solution 
{
    public string str;
    public string tmp;
    public long solution(string s) 
    {
        long answer = 0;
        
        for (int i = 0;i < s.Length; i++)
        {
            if (IsDigit(s[i]))
            {
                str += s[i];
            }
            else
            {
                tmp += s[i];
                Switching();
            }
        }
        
        answer = long.Parse(str);
        Console.WriteLine(answer);
        return answer;
    }
    
    public bool IsDigit(char c)
    {
        if (c >= '0' && c <= '9')
            return true;
        return false;
    }
    public void Switching()
    {
        if (tmp == "zero")
        {
            str += '0';
            tmp = "";
        }
        if (tmp == "one")
        {
            str += '1';
            tmp = "";
        }
        if (tmp == "two")
        {
            str += '2';
            tmp = "";
        }
        if (tmp == "three")
        {
            str += '3';
            tmp = "";
        }
        if (tmp == "four")
        {
            str += '4';
            tmp = "";
        }
        if (tmp == "five")
        {
            str += '5';
            tmp = "";
        }
        if (tmp == "six")
        {
            str += '6';
            tmp = "";
        }
        if (tmp == "seven")
        {
            str += '7';
            tmp = "";
        }
        if (tmp == "eight")
        {
            str += '8';
            tmp = "";
        }
        if (tmp == "nine")
        {
            str += '9';
            tmp = "";
        }
        
    }
}