public class Solution {
    public bool solution(int x) {
        bool answer = true;
        int i_tmp = x;
        
        int i = 0;
        while(x > 0)
        {
            i += x % 10;
            x = x / 10;
        }
        
        if (i_tmp % i == 0)
            return true;
        else
            return false;
        
    }
}