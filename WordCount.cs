/// <summary>
/// Provides a method for counting how often each word appears in a string.
/// </summary>
public static class WordCount
{
    /// <summary>
    /// Counts the occurrences of each word in the provided text.
    /// </summary>
    /// <param name="text">The text containing the words to count.</param>
    /// <returns>A dictionary containing each word and its occurrence count.</returns>
    public static Dictionary<string, int> Count(string text)
    {
        Dictionary<string, int> counts = new Dictionary<string, int>();

        string[] words = text.ToLower().Split(
            new char[] { ' ', ',', '.', '!', '?', ';', ':' },
            StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in words)
        {
            if (counts.ContainsKey(word))
            {
                counts[word]++;
            }
            else
            {
                counts[word] = 1;
            }
        }

        return counts;
    }
}
