using System.Linq;

namespace _30DaysChallenge
{
    class OddNumbersUnpairedInArray
    {
        public static int Solution(int[] A)
        {
            var group = A.GroupBy(x => x);
            foreach (var item in group)
            {
                if (item.Count() == 1)
                    return item.Key;
            }

            return 0;
        }
    }
}
