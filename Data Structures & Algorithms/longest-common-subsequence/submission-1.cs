public class Solution 
{
    private int[,] memo;

    public int LongestCommonSubsequence(string text1, string text2) 
    {
        // Initialize the memoization table with -1 (unvisited states)
        memo = new int[text1.Length, text2.Length];
        for (int i = 0; i < text1.Length; i++)
        {
            for (int j = 0; j < text2.Length; j++)
            {
                memo[i, j] = -1;
            }
        }

        // Start DFS from the beginning of both strings
        return Dfs(text1, text2, 0, 0);
    }

    private int Dfs(string text1, string text2, int i, int j)
    {
        // Base Case: If we reach the end of either string
        if (i == text1.Length || j == text2.Length)
        {
            return 0;
        }

        // If this state has already been calculated, return the cached result
        if (memo[i, j] != -1)
        {
            return memo[i, j];
        }

        // Case 1: The characters match
        if (text1[i] == text2[j])
        {
            memo[i, j] = 1 + Dfs(text1, text2, i + 1, j + 1);
        }
        // Case 2: The characters do not match
        else
        {
            memo[i, j] = Math.Max(
                Dfs(text1, text2, i + 1, j),   // Skip character in text1
                Dfs(text1, text2, i, j + 1)    // Skip character in text2
            );
        }

        return memo[i, j];
    }
}