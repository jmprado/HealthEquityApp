using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthEquityApp.Dal
{
    public static class GuessOperation
    {
        public static bool ValueIsInRange(int testValue, int min, int max)
        {
            return (testValue >= Math.Min(min, max) && testValue <= Math.Max(min, max));
        }
    }
}
