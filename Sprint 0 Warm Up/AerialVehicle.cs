using System;

namespace Sprint_0_Warm_Up
{
    public abstract class AerialVehicle
    {
        public int CurrentAltitude { get; set; }
        public int MaxAltitude { get; set; }

        public bool isFlying { get; set; }

        internal Engine engine { get; set; } = new Engine();

        public AerialVehicle()
        {

        }

        public string About()
        {
            return ($"this {this.ToString()} has a max altitude of {MaxAltitude} ft\nIt's current altitude is {CurrentAltitude} ft\n{engine.About()}");
        }

        public virtual string TakeOff()
        {
            if (engine.IsStarted)
            {
                isFlying = true;
                return $"{this.ToString()} is flying";
            }
            else
            {
                return $"{this.ToString()} can't fly it's engine is not started.";
            }
        }

        public virtual void StartEngine()
        {
            engine.Start();
        }

        public void FlyDown()
        {
            if (this.CurrentAltitude - 1000 > 0)
            {
                this.CurrentAltitude -= 1000;
                if (CurrentAltitude == 0)
                {
                    isFlying = false;
                }
            }
        }

        public void FlyDown(int howMuch)
        {
            if (CurrentAltitude - howMuch >= 0)
            {
                CurrentAltitude -= howMuch;
                if (CurrentAltitude == 0)
                {
                    isFlying = false;
                }
            }
        }

        internal void FlyUp()
        {
            if (this.CurrentAltitude + 1000 <= MaxAltitude)
            {
                this.CurrentAltitude += 1000;
            }
        }

        internal void FlyUp(int HowMuch)
        {
            if (CurrentAltitude + HowMuch <= MaxAltitude)
            {
                this.CurrentAltitude += HowMuch;
            }
        }

        string getEngineStartedString()
        {
            return "";
        }
    }
}