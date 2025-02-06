public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 0)
            return "";

        string pref = strs[0];
        int prefLength = pref.Length;

        for (int i = 1; i < strs.Length; i++)
        {
            while (prefLength > strs[i].Length || !strs[i].StartsWith(pref))
            {
                prefLength--;

                if (prefLength == 0)
                    return "";

                pref = pref.Substring(0, prefLength);
            }
        }

        return pref;
    }
}