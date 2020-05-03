using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorTest
{
    class PrimeCollection : IEnumerable
    {
        public long min { get; set; }
        public long max { get; set; }
        public List<long> resList { get; set; }

        public PrimeCollection(long min, long max)
        {
            this.min = min;
            this.max = max;
            resList = new List<long>();
            for(long cur = min; cur<=max; cur++)
            {
                bool isprime = true;
                for(long divisor = 2; divisor <= Math.Sqrt(cur); divisor++)
                {
                    if(cur % divisor == 0)
                    {
                        isprime = false;
                        break;
                    }
                }
                if (isprime) resList.Add(cur);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new PrimeEnum(resList);
        }
    }

    class PrimeEnum : IEnumerator
    {
        private List<long> _primes;
        private int index = -1;

        public PrimeEnum(List<long> _primes)
        {
            this._primes = _primes;
        }

        object IEnumerator.Current
        {
            get
            {
                try
                {
                    return _primes[index];
                }
                catch(IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
                
            }
        }

        bool IEnumerator.MoveNext()
        {
            index++;
            return index < _primes.Count;
        }

        void IEnumerator.Reset() => index = -1;
    }
}
