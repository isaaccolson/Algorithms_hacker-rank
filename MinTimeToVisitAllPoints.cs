public class Solution {
    public int MinTimeToVisitAllPoints(int[][] points) {

        var shortestDistance = 0;

        for(var i = 0; i < points.Length - 1; i++){
            var xDistance = Math.Abs((points[i+1][0]) - (points[i][0]));
            var yDistance = Math.Abs((points[i+1][1]) - (points[i][1]));
            shortestDistance += (xDistance >= yDistance) ? xDistance : yDistance;
        }
        return shortestDistance;
    }
}//22 min
