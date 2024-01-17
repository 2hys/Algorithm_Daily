public class Solution {
    public long solution(int a, int b) {
        long answer = 0;
        int tmp1;
        if (a > b)
        {
            tmp1 = a;
            a = b;
            b = tmp1;
        }
        while(a <= b)
        {
            answer += a;
            a++;
        }
            
        return answer;
    }
}