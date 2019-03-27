using System;
using System.Collections.Generic;
using System.Text;

namespace _30DaysChallenge
{
    class FrogJump
    {
        public static int Solution(int X, int Y, int D)
        {
            var result = (Y - X) / D;
            if ((Y - X) % D != 0)
                result++;

            return result;
        }
    }
}
