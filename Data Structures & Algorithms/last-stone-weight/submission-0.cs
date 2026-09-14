public class Solution
{
    public int LastStoneWeight(int[] stones)
    {
        var pq = new PriorityQueue<int, int>(
            Comparer<int>.Create((x, y) => y.CompareTo(x))
        );

        foreach (int stone in stones)
        {
            pq.Enqueue(stone, stone);
        }

        while (pq.Count > 1)
        {
            int x = pq.Dequeue();
            int y = pq.Dequeue();

            if (x != y)
            {
                pq.Enqueue(x - y, x - y);
            }
        }

        return pq.Count == 0 ? 0 : pq.Peek();
    }
}