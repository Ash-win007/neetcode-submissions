public class Solution {
    public int[] TopKFrequent(int[] nums, int k)
    {
        var frequency = new Dictionary<int, int>();

        // Count frequencies
        foreach (int num in nums)
        {
            frequency[num] = frequency.GetValueOrDefault(num) + 1;
        }

        // Min-heap: element = number, priority = frequency
        var pq = new PriorityQueue<int, int>();

        foreach (var pair in frequency)
        {
            pq.Enqueue(pair.Key, pair.Value);

            if (pq.Count > k)
            {
                pq.Dequeue();
            }
        }

        // Extract result
        var result = new int[k];

        for (int i = 0; i < k; i++)
        {
            result[i] = pq.Dequeue();
        }

        return result;
    }
    
}
