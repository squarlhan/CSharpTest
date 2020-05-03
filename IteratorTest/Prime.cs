using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorTest
{
    class Prime : IEnumerable
    {
        public long min { get; set; }
        public long max { get; set; }
        public List<long> resList { get; set; }

        public Prime(long min, long max)
        {
            if (min < 2)
            {
                this.min = 2;
            }
            else
            {
                this.min = min;
            }
            this.max = max;
            resList = new List<long>();
            
        }

        public IEnumerator GetEnumerator()
        {
            for (long cur = min; cur <= max; cur++)
            {
                bool isprime = true;
                for (long divisor = 2; divisor <= Math.Sqrt(cur); divisor++)
                {
                    if (cur % divisor == 0)
                    {
                        isprime = false;
                        break;
                    }
                }
                if (isprime)
                {
                    resList.Add(cur);
                    yield return cur;
                }
            }
        }
    }
}
