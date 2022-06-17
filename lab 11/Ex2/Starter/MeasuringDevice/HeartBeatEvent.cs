using System;


namespace MeasuringDevice
{

    // Delegate defining the HeartBeat event signature.
    public delegate void HeartBeatEventHandler
     (object sender, HeartBeatEventArgs args);


    public class HeartBeatEventArgs : EventArgs
    {
        public DateTime TimeStamp { get; private set; }

        public HeartBeatEventArgs()
            : base()
        {
            this.TimeStamp = DateTime.Now;
        }
    }
}