public class Solution {
    public bool IsPalindrome(int x) {
        if (x < 0) 
        {
            return false;
        }
        string str = Convert.ToString(x);
        for (int i = 0; i < str.Length / 2; i++) {
            if (str[i] != str[str.Length - 1 - i]) {
                return false;
            }
        }
        return true;
    }  
}
