public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        PriorityQueue<int[], int> pq = new PriorityQueue<int[],int>();

        foreach (var point in points)
        {
            int distance = point[0] * point[0] + point[1] * point[1];

            pq.Enqueue(point, distance);
        }

        int[][] res = new int[k][];

        for (int i = 0; i < k; i++)
        {
            res[i] = pq.Dequeue();
        }

        return res;
    }
}
