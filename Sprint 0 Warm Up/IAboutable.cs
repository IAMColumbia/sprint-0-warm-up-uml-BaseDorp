using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint_0_Warm_Up
{
    public interface IAboutable
    {
        string About()
        {
            return this.ToString();
        }
    }
}
