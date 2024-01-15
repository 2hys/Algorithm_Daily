public class Solution {
    public long solution(long n) {
        long answer = 0;
        long i = 1;
        while(true)
        {
            if (n == i * i)
                break;
            if (i > n)
                return -1;
            i++;
        }
        answer = (i+1) * (i+1);
        return answer;
    }
}