using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint_0_Warm_Up
{
    public class ToyPlane : Airplane
    {
        public bool isWoundUp;

        public string About()
        {
            if (isWoundUp)
            {
                return $"{this} is wound up";
            }
            else
            {
                return $"{this} is not wound up";
            }
        }

        public string getWindUpString()
        {
            return $"{this} is winding up";
        }

        public override void StartEngine()
        {
            WindUp();
        }

        public override string TakeOff()
        {
            if (CurrentAltitude == 0 && isWoundUp)
            {
                CurrentAltitude = 10;
                return $"{this} has taken off";
            }
            else
            {
                return $"{this} cannot take off";
            }
        }

        public ToyPlane()
        {
            MaxAltitude = 50;
        }

        public void UnWind()
        {
            isWoundUp = false;
            this.engine.Stop();
        }

        public void WindUp()
        {
            isWoundUp = true;
            getWindUpString();
            this.engine.Start();
        }
    }
}
