public class Solution
{
    public bool CanFinish(int numCourses, int[][] prerequisites)
    {
        // Adjacency list
        List<int>[] graph = new List<int>[numCourses];

        for (int i = 0; i < numCourses; i++)
        {
            graph[i] = new List<int>();
        }

        // indegree[i] = number of prerequisites for course i
        int[] indegree = new int[numCourses];

        foreach (int[] prerequisite in prerequisites)
        {
            int course = prerequisite[0];
            int prereq = prerequisite[1];

            // prereq -> course
            graph[prereq].Add(course);
            indegree[course]++;
        }

        // Courses with no prerequisites
        Queue<int> queue = new Queue<int>();

        for (int i = 0; i < numCourses; i++)
        {
            if (indegree[i] == 0)
            {
                queue.Enqueue(i);
            }
        }

        int completedCourses = 0;

        while (queue.Count > 0)
        {
            int current = queue.Dequeue();
            completedCourses++;

            foreach (int nextCourse in graph[current])
            {
                indegree[nextCourse]--;

                if (indegree[nextCourse] == 0)
                {
                    queue.Enqueue(nextCourse);
                }
            }
        }

        // If all courses were processed, there is no cycle
        return completedCourses == numCourses;
    }
}