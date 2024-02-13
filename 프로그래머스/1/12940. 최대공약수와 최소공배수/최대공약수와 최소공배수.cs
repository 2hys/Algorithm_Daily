using System;
public class Solution {
    public int[] solution(int n, int m) {
        int[] answer = new int[2];

        answer[0] = gcd(n, m);
        answer[1] = (n * m) / gcd(n, m);
        return answer;
        //두 수 n, m 이 있을 때 어느 한 수가 0이 될 때 까지
        //gcd(m, n%m) 의 재귀함수 반복
        
    }
    public int gcd(int n, int m)
        {
            if (m == 0)
                return n;
            else
                return gcd(m, n % m);
        }
}