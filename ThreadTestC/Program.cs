using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadTestC
{
    public class Program
    {
        static void Main(string[] args)
        {

            WritingThread wt = new WritingThread();

            Thread t = new Thread(new ThreadStart(wt.displayX));
            t.Start();

            for(int i =0; i<10; i++)
            {
                Thread.Sleep(300);
                wt.x = i;
            }

            Thread.Sleep(1500);
            t.Abort();

        }
    }
}
