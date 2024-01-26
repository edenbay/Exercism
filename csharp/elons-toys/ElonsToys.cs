using System;

class RemoteControlCar
    {
        public int Meters;

        public int Percentage = 100;

        public static RemoteControlCar Buy() => new RemoteControlCar();
        public string DistanceDisplay() => $"Driven {Meters} meters";
            public string BatteryDisplay()
        {
            string? battery = (Percentage !> 1 ? $"Battery at {Percentage}%" : $"Battery empty");
            return battery;
        }
        public void Drive() 
        {
            if ( Percentage > 0 ) { Meters += 20; Percentage--; } 
            else {  Meters += 0;};
        }
    }
