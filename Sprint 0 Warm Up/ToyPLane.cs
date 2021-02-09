using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint_0_Warm_Up
{
    class ToyPlane : Airplane
    {
        bool isWoundUp;

        string About()
        {
            return "";
        }

        string getWindUpString()
        {
            return "";
        }

        void StartEngine()
        {
            if (isWoundUp)
            {
                engine.Start();
            }
        }

        string TakeOff()
        {
            return "";
        }

        public ToyPlane()
        {
            MaxAltitude = 50;
        }

        void UnWind()
        {
            isWoundUp = false;
        }

        void WindUp()
        {
            isWoundUp = true;
        }
    }
}
