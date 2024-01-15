using System;
using System.Collections;

public class Solution {
    public int[] solution(long n) {
        string str = n.ToString();
        int[] answer = new int[str.Length];
        for(int i = 0; i < str.Length;i++)
        {
            answer[i] = int.Parse(str[i].ToString());
            //char를 int로 바꾸면 ASCII코드에 해당되는 숫자로 반환되는 문제 등이 있어서 
            //그냥 string변환과 int변환을 같이쓰자.
        }
        Array.Reverse(answer);
        return answer;
    }
}