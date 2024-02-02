using System;

public class Solution {
    public int solution(int left, int right) {
        int answer = 0;
        int count = 0;
        int i = 1;
        while (left <= right)
        {
            Console.WriteLine(answer);
            while(i <= left)
            {
                if (left % i == 0)
                    count++;
                i++;
                //Console.WriteLine(count);
            }
            if (count % 2 == 0)//짝수이면
                answer += left;
            else if (count % 2 == 1)
                answer -= left;
            count = 0;
            i = 1;
            left++;
            Console.WriteLine("left = " + left);
        }
        return answer;
    }
}