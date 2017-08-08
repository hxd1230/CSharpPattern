using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;


namespace Xiao.Application.PracticalPattern.Concept.Delegating
{
    public class AsyncInvoker
    {
        private IList<string> output = new List<string>();
        public AsyncInvoker()
        {
            Timer slowTimer = new Timer(new TimerCallback(OnTimerInterval), "slow", 2500, 2500);
            Timer fastTimer = new Timer(new TimerCallback(OnTimerInterval), "fast", 2000, 2000);
            output.Add("method");
        }
        public void OnTimerInterval(object state)
        {
            output.Add(state as string);
        }
        public IList<string> Output { get { return output; } }
    }
}