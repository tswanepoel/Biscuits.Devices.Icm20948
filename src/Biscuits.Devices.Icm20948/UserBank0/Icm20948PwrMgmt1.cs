namespace Biscuits.Devices.Icm20948.UserBank0
{
    public struct Icm20948PwrMgmt1
    {
        private const int DeviceResetLoc = 7;
        private const byte DeviceResetMask = 0b1;

        private const int SleepLoc = 6;
        private const byte SleepMask = 0b1;

        private const int LpEnLoc = 5;
        private const byte LpEnMask = 0b1;

        private const int TempDisLoc = 3;
        private const byte TempDisMask = 0b1;

        private const int ClkSelLoc = 0;
        private const byte ClkSelMask = 0b111;

        private byte _value;

        public bool DeviceReset
        {
            get => ((_value >> DeviceResetLoc) & DeviceResetMask) != 0;
            set
            {
                byte valueRaw = (byte)(value ? 0b1 : 0b0);
                _value = (byte)((_value & ~(DeviceResetMask << DeviceResetLoc)) | ((valueRaw & DeviceResetMask) << DeviceResetLoc));
            }
        }

        public bool Sleep
        {
            get => ((_value >> SleepLoc) & SleepMask) != 0;
            set
            {
                byte valueRaw = (byte)(value ? 0b1 : 0b0);
                _value = (byte)((_value & ~(SleepMask << SleepLoc)) | ((valueRaw & SleepMask) << SleepLoc));
            }
        }

        public bool LpEn
        {
            get => ((_value >> LpEnLoc) & LpEnMask) != 0;
            set
            {
                byte valueRaw = (byte)(value ? 0b1 : 0b0);
                _value = (byte)((_value & ~(LpEnMask << LpEnLoc)) | ((valueRaw & LpEnMask) << LpEnLoc));
            }
        }

        public bool TempDis
        {
            get => ((_value >> TempDisLoc) & TempDisMask) != 0;
            set
            {
                byte valueRaw = (byte)(value ? 0b1 : 0b0);
                _value = (byte)((_value & ~(TempDisMask << TempDisLoc)) | ((valueRaw & TempDisMask) << TempDisLoc));
            }
        }

        public Icm20948ClkSel ClkSel
        {
            get => (Icm20948ClkSel)((_value >> ClkSelLoc) & ClkSelMask);
            set
            {
                byte valueRaw = (byte)value;
                _value = (byte)((_value & ~(ClkSelMask << ClkSelLoc)) | ((valueRaw & ClkSelMask) << ClkSelLoc));
            }
        }

        private Icm20948PwrMgmt1(byte value)
        {
            _value = value;
        }

        public static explicit operator Icm20948PwrMgmt1(byte value)
        {
            return new Icm20948PwrMgmt1(value);
        }

        public static implicit operator byte(Icm20948PwrMgmt1 pwrMgmt1)
        {
            return pwrMgmt1._value;
        }
    }
}
