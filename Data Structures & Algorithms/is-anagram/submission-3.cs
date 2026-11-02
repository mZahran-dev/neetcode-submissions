public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if(s.Length != t.Length)
            return false;

        string sortedS = String.Concat(s.OrderBy(c => c));
        string sortedT = String.Concat(t.OrderBy(c => c));
        for (int i = 0; i < s.Length; i++)
        {
            if (sortedS[i] == sortedT[i])
                continue;
            else
                return false;
        }
        return true;
    }
}
