using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace LeetCodeHackerRankProbs
{
    public class MovingAverage
    {
        private Queue<int> _queue;
        int size;
        double sum;
        public MovingAverage(int size)
        {
            _queue = new Queue<int>(size);
            this.size = size;
            sum = 0;
        }
        public double Next(int val)
        {
            _queue.Enqueue(val);
            sum += val;
            while (_queue.Count > size)
            {
                sum -= _queue.Dequeue();
            }

            return sum / _queue.Count;
        }
    }
}
