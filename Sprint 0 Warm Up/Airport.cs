using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint_0_Warm_Up
{
    class Airport
    {
        int MaxVehicles;
        List<AerialVehicle> Vehicles;

        string AirportCode { get; set; }

        public Airport(string Code)
        {

        }

        public Airport(string Code, int MaxVehicles)
        {

        }

        string AllTakeOff()
        {
            return "";
        }

        string Land(AerialVehicle a)
        {
            // Makes sure Airport is not full
            if (this.MaxVehicles < Vehicles.Count)
            {
                // Landing should fly Aerial Vehicle to the ground
                a.FlyDown(0);
                a.isFlying = false;

                // Add to Airport's Vehicles
                Vehicles.Add(a);

                return "Aerial Vehicle has been put inside Airport";
            }
            else
            {
                return "this airport is full";
            }
        }

        string Land(List<AerialVehicle> landing)
        {
            return "";
        }

        string TakeOff(AerialVehicle a)
        {
            return "";
        }
    }
}
