public class Solution {
    public double solution(int[] arr) {
        double answer = 0;
        int len = arr.Length;
        for (int i = 0; i < len; i++)
        {
            answer += arr[i];
        }
        
        return (answer / len);
    }
}