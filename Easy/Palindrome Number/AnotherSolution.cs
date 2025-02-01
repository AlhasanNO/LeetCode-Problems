public class Solution
{
    public bool IsPalindrome(int x)
    {
        if (x >= 0 && x < 10)
            return true;

        else if (x < 0)
            return false;

        string number = x.ToString();
        string reversedNumber = "";

        while (x != 0)
        {
            reversedNumber += (x % 10).ToString();
            x /= 10;
        }

        return number == reversedNumber;
    }
}