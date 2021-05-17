using System;

namespace TempSensor
{
    public class TempEventArg : EventArgs
    {
        public double temp { set; get; }
    }
    public interface ITempSensor
    {
        event EventHandler<TempEventArg> TempChangedEvent;
        double Read();
        void Update(double temp);
    }
}
