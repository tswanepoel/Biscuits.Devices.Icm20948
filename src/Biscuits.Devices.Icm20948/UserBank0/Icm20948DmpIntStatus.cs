namespace Biscuits.Devices.Icm20948.UserBank0
{
    public readonly struct Icm20948DmpIntStatus
    {
        private const int BringToSeeIntLoc = 5;
        private const byte BringToSeeIntMask = 0b1;

        private const int PedometerIntLoc = 2;
        private const byte PedometerIntMask = 0b1;

        private const int SmdIntLoc = 1;
        private const byte SmdIntMask = 0b1;

        private readonly byte _value;

        public bool BringToSeeInt
        {
            get => ((_value >> BringToSeeIntLoc) & BringToSeeIntMask) != 0;
        }

        public bool PedometerInt
        {
            get => ((_value >> PedometerIntLoc) & PedometerIntMask) != 0;
        }

        public bool SmdInt
        {
            get => ((_value >> SmdIntLoc) & SmdIntMask) != 0;
        }

        private Icm20948DmpIntStatus(byte value)
        {
            _value = value;
        }

        public static explicit operator Icm20948DmpIntStatus(byte value)
        {
            return new Icm20948DmpIntStatus(value);
        }

        public static implicit operator byte(Icm20948DmpIntStatus dmpIntStatus)
        {
            return dmpIntStatus._value;
        }
    }
}
