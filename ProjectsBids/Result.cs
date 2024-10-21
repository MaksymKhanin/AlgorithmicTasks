using System;
using System.Collections.Generic;

namespace ProjectsBids;

class Result
{
    // Time complexity: O(p + n + m)
    public static long minCost(int numProjects, List<int> projectIds, List<int> bids)
    {
        // use long to handle value overflow

        long[] minBids = new long[numProjects];

        // Fill array. Complexity: O(p), where p - number of projects

        Array.Fill(minBids, long.MaxValue);

        // Iterate through all bids. Complexity: O(n), where n - number of bids

        for (int i = 0; i < projectIds.Count; i++)
        {
            int projectId = projectIds[i];
            int bidAmount = bids[i];

            if (bidAmount < minBids[projectId])
            {
                minBids[projectId] = bidAmount;
            }
        }

        long totalMinCost = 0;

        // Iterate through all minBids. Complexity: O(m), where m - number of projects

        for (int i = 0; i < numProjects; i++)
        {
            if (minBids[i] == long.MaxValue)
            {
                return -1;
            }

            totalMinCost += minBids[i];
        }

        return totalMinCost;
    }
}
