namespace Biscuits.Devices.Icm20948
{
    public struct Icm20948Dmp3DataOutCtl2
    {
        private const int AccelAccuracySetLoc = 14;
        private const ushort AccelAccuracySetMask = 0b1;

        private const int GyroAccuracySetLoc = 13;
        private const ushort GyroAccuracySetMask = 0b1;

        private const int CPassAccuracySetLoc = 12;
        private const ushort CPassAccuracySetMask = 0b1;

        private const int BatchModeLoc = 8;
        private const ushort BatchModeMask = 0b1;

        private ushort _value;

        public bool AccelAccuracySet
        {
            get => ((_value >> AccelAccuracySetLoc) & AccelAccuracySetMask) != 0;
            set
            {
                ushort valueRaw = (ushort)(value ? 0b1 : 0b0);
                _value = (ushort)((_value & ~(AccelAccuracySetMask << AccelAccuracySetLoc)) | ((valueRaw & AccelAccuracySetMask) << AccelAccuracySetLoc));
            }
        }

        public bool GyroAccuracySet
        {
            get => ((_value >> GyroAccuracySetLoc) & GyroAccuracySetMask) != 0;
            set
            {
                ushort valueRaw = (ushort)(value ? 0b1 : 0b0);
                _value = (ushort)((_value & ~(GyroAccuracySetMask << GyroAccuracySetLoc)) | ((valueRaw & GyroAccuracySetMask) << GyroAccuracySetLoc));
            }
        }

        public bool CPassAccuracySet
        {
            get => ((_value >> CPassAccuracySetLoc) & CPassAccuracySetMask) != 0;
            set
            {
                ushort valueRaw = (ushort)(value ? 0b1 : 0b0);
                _value = (ushort)((_value & ~(CPassAccuracySetMask << CPassAccuracySetLoc)) | ((valueRaw & CPassAccuracySetMask) << CPassAccuracySetLoc));
            }
        }

        public bool BatchMode
        {
            get => ((_value >> BatchModeLoc) & BatchModeMask) != 0;
            set
            {
                ushort valueRaw = (ushort)(value ? 0b1 : 0b0);
                _value = (ushort)((_value & ~(BatchModeMask << BatchModeLoc)) | ((valueRaw & BatchModeMask) << BatchModeLoc));
            }
        }

        private Icm20948Dmp3DataOutCtl2(ushort value)
        {
            _value = value;
        }

        public static explicit operator Icm20948Dmp3DataOutCtl2(ushort value)
        {
            return new Icm20948Dmp3DataOutCtl2(value);
        }

        public static implicit operator ushort(Icm20948Dmp3DataOutCtl2 dataOutCtl2)
        {
            return dataOutCtl2._value;
        }
    }
}
