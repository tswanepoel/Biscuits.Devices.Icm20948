namespace Biscuits.Devices.Icm20948
{
    public readonly struct Icm20948Dmp3FifoHeader2
    {
        private const int AccelAccuracySetLoc = 14;
        private const ushort AccelAccuracySetMask = 0b1;

        private const int GyroAccuracySetLoc = 13;
        private const ushort GyroAccuracySetMask = 0b1;

        private const int CPassAccuracySetLoc = 12;
        private const ushort CPassAccuracySetMask = 0b1;

        private const int FSyncSetLoc = 11;
        private const ushort FSyncSetMask = 0b1;

        private const int FlipPickupSetLoc = 10;
        private const ushort FlipPickupSetMask = 0b1;

        private const int ActRecogSetLoc = 7;
        private const ushort ActRecogSetMask = 0b1;

        private const int SecondaryOnOffSetLoc = 6;
        private const ushort SecondaryOnOffSetMask = 0b1;

        private readonly ushort _value;

        public bool AccelAccuracySet
        {
            get => ((_value >> AccelAccuracySetLoc) & AccelAccuracySetMask) != 0;
        }

        public bool GyroAccuracySet
        {
            get => ((_value >> GyroAccuracySetLoc) & GyroAccuracySetMask) != 0;
        }

        public bool CPassAccuracySet
        {
            get => ((_value >> CPassAccuracySetLoc) & CPassAccuracySetMask) != 0;
        }

        public bool FSyncSet
        {
            get => ((_value >> FSyncSetLoc) & FSyncSetMask) != 0;
        }

        public bool FlipPickupSet
        {
            get => ((_value >> FlipPickupSetLoc) & FlipPickupSetMask) != 0;
        }

        public bool ActRecogSet
        {
            get => ((_value >> ActRecogSetLoc) & ActRecogSetMask) != 0;
        }

        public bool SecondaryOnOffSet
        {
            get => ((_value >> SecondaryOnOffSetLoc) & SecondaryOnOffSetMask) != 0;
        }

        private Icm20948Dmp3FifoHeader2(ushort value)
        {
            _value = value;
        }

        public static explicit operator Icm20948Dmp3FifoHeader2(ushort value)
        {
            return new Icm20948Dmp3FifoHeader2(value);
        }

        public static implicit operator ushort(Icm20948Dmp3FifoHeader2 fifoHeader2)
        {
            return fifoHeader2._value;
        }
    }
}
