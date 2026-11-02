public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if(s.Length != t.Length)
            return false;

        Dictionary<char, int> sDict = new Dictionary<char, int>();
        Dictionary<char, int> tDict = new Dictionary<char, int>();

        foreach(char c in s)
        {
            if (sDict.ContainsKey(c))
                sDict[c]++;
            else
                sDict[c] = 1;
        }

        foreach (char c in t)
        {
            if (tDict.ContainsKey(c))
                tDict[c]++;
            else
                tDict[c] = 1;
        }
        // Compare the two dictionaries
        foreach (var kvp in sDict)
        {
            if (!tDict.ContainsKey(kvp.Key) || tDict[kvp.Key] != kvp.Value)
                return false;
        }
        return true;
    }
}
