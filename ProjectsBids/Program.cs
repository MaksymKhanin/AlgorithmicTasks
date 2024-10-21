using System;
using System.Collections.Generic;

namespace ProjectsBids;

internal class Program
{
    static void Main(string[] args)
    {
        int numProjects = 4;
        List<int> projectIds = new List<int>() { 1, 0, 2, 2 };
        List<int> bids = new List<int> { 8, 7, 6, 9 };

        var sum = Result.minCost(numProjects, projectIds, bids);

        Console.WriteLine(sum);
    }
}
