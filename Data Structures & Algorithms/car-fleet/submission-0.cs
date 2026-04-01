public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        int n = position.Length;
        var cars = new (int pos, double time) [n];

        for (int i= 0; i < n ; i++)
        {
            double time = (double) (target - position[i]) / speed[i];
            cars[i] = (position[i], time);
        }

        Array.Sort(cars, (a,b) => b.pos.CompareTo(a.pos));

        Stack<double> stack = new Stack<double>();
        foreach (var car in cars)
        {
            if (stack.Count == 0 || car.time > stack.Peek())
            {
                stack.Push(car.time);
            }
        }
        return stack.Count;
    }
}
