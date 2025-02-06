public class Solution
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        Dictionary<char, int> myDictionary = new();

        for (int i = 0; i < magazine.Length; i++)
        {
            if (myDictionary.ContainsKey(magazine[i]))
            {
                myDictionary[magazine[i]]++;
            }

            else
            {
                myDictionary[magazine[i]] = 1;
            }
        }

        for (int i = 0; i < ransomNote.Length; i++)
        {
            if (!myDictionary.ContainsKey(ransomNote[i]) || myDictionary[ransomNote[i]] <= 0)
                return false;

            myDictionary[ransomNote[i]]--;
        }

        return true;
    }
}