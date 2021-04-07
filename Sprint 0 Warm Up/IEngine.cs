using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint_0_Warm_Up
{
    public interface IEngine : IAboutable
    {
        bool IsStarted { get; set; }

        void Start();
        void Stop();
    }
}
