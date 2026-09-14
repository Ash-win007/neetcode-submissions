public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        // Build adjacency list: course -> its prerequisites
        List<int>[] graph = new List<int>[numCourses];
        for (int i = 0; i < numCourses; i++) {
            graph[i] = new List<int>();
        }
        foreach (var pre in prerequisites) {
            graph[pre[0]].Add(pre[1]); // to take pre[0], need pre[1] first
        }

        int[] state = new int[numCourses]; // 0 = unvisited, 1 = visiting, 2 = visited

        for (int i = 0; i < numCourses; i++) {
            if (state[i] == 0 && HasCycle(i, graph, state)) {
                return false;
            }
        }
        return true;
    }

    private bool HasCycle(int course, List<int>[] graph, int[] state) {
        if (state[course] == 1) return true;  // cycle detected
        if (state[course] == 2) return false; // already processed

        state[course] = 1; // mark as visiting
        foreach (int prereq in graph[course]) {
            if (HasCycle(prereq, graph, state)) {
                return true;
            }
        }
        state[course] = 2; // mark as visited
        return false;
    }
}