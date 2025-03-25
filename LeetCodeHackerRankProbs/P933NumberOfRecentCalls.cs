using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeHackerRankProbs
{
    public class P933NumberOfRecentCalls
    {
        private Queue<int> _queue;
        public P933NumberOfRecentCalls()
        {
            _queue = new Queue<int>();
        }

        public int Ping(int t)
        {
            _queue.Enqueue(t);
            while (_queue.Peek() < t - 3000) 
            { 
                _queue.Dequeue();
            }
            return _queue.Count;
        }
    }
}
