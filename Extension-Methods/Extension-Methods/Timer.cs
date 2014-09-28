//// TASK 7
//// Using delegates write a class Timer that has can execute certain method at each t seconds.

//// TASK 8
//// * Read in MSDN about the keyword event in C# and how to publish events.
//// Re-implement the above using .NET events and following the best practices.
//// AUTOR COMENT: Super Shit, I don't know what I'm doing! (puke)

namespace Extension_Methods
{
    using System;
    using System.Threading;
    using Extension_Methods;    

    public class Timer : EventArgs
    {
        ////public event EventHandler DoEvent;

        ////public void Wait(int howMuchTime, int seconds )
        ////{
        ////    for (int i = 0; i < howMuchTime; i++)
        ////    {
        ////        OnDoEvent();
        ////        Thread.Sleep(seconds * 1000);
                
        ////    }
        ////}

        ////protected void OnDoEvent()
        ////{
        ////    EventHandler e = DoEvent;
        ////    if (e != null)
        ////    {
        ////        e(this, null);
        ////    }
        ////}

        public delegate void DisplayNumbersWithTimer(int param);

        public void Sleep(int seconds, DisplayNumbersWithTimer method, int howMuchTime)
        {
            for (int i = 0; i < howMuchTime; i++)
            {
                method(i);
                Thread.Sleep(seconds * 1000);
            }
        }
    }
}
