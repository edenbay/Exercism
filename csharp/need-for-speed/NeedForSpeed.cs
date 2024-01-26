using System;

class RemoteControlCar
{
        private int _drivenDistance;
        private int _speed;
        private int _batteryDrain;
        private int _batteryPercentage = 100;

        public RemoteControlCar(int speed, int batteryDrain)
        {
            _speed = speed;
            _batteryDrain = batteryDrain;
        }

        public bool BatteryDrained() => _batteryPercentage <= 0 || _batteryPercentage < _batteryDrain;

        public int DistanceDriven() => _drivenDistance;

        public void Drive() 
        {            
            if (!BatteryDrained())
            {                    
                _drivenDistance += _speed;                
            }
            _batteryPercentage -= _batteryDrain;
        }  

        public static RemoteControlCar Nitro() => new RemoteControlCar(50,4);
}

class RaceTrack
{   
        public int Distance { get; set; }

        public RaceTrack(int distance)
        {
            Distance = distance;
        }

        public bool TryFinishTrack(RemoteControlCar car)
        {
            while (!car.BatteryDrained()) 
            { 
                car.Drive();
                if (car.DistanceDriven() >= Distance) { return true; }                
            }
            return false;
        }
}
