public class Solution
{
    public int ClimbStairs(int n)
    {
        if (n <= 3)
            return n;

        int case1 = 2;
        int case2 = 3;
        int caseN = 0;

        for (int i = 3; i < n; i++)
        {
            caseN = case1 + case2;
            case1 = case2;
            case2 = caseN;
        }

        return caseN;
    }
}