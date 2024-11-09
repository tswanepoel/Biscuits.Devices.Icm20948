namespace Biscuits.Devices.Icm20948.UserBank2
{
    public struct Icm20948AccelConfig2
    {
        private const int AXStEnLoc = 4;
        private const byte AXStEnMask = 0b1;

        private const int AYStEnLoc = 3;
        private const byte AYStEnMask = 0b11;

        private const int AZStEnLoc = 2;
        private const byte AZStEnMask = 0b1;

        private const int Dec3CfgLoc = 0;
        private const byte Dec3CfgMask = 0b11;

        private byte _value;

        public bool AXStEn
        {
            get => ((_value >> AXStEnLoc) & AXStEnMask) != 0;
            set
            {
                byte valueRaw = (byte)(value ? 0b1 : 0b0);
                _value = (byte)((_value & ~(AXStEnMask << AXStEnLoc)) | ((valueRaw & AXStEnMask) << AXStEnLoc));
            }
        }

        public bool AYStEn
        {
            get => ((_value >> AYStEnLoc) & AYStEnMask) != 0;
            set
            {
                byte valueRaw = (byte)(value ? 0b1 : 0b0);
                _value = (byte)((_value & ~(AYStEnMask << AYStEnLoc)) | ((valueRaw & AYStEnMask) << AYStEnLoc));
            }
        }

        public bool AZStEn
        {
            get => ((_value >> AZStEnLoc) & AZStEnMask) != 0;
            set
            {
                byte valueRaw = (byte)(value ? 0b1 : 0b0);
                _value = (byte)((_value & ~(AZStEnMask << AZStEnLoc)) | ((valueRaw & AZStEnMask) << AZStEnLoc));
            }
        }

        public Icm20948Dec3Cfg Dec3Cfg
        {
            get => (Icm20948Dec3Cfg)((_value >> Dec3CfgLoc) & Dec3CfgMask);
            set
            {
                byte valueRaw = (byte)value;
                _value = (byte)((_value & ~(Dec3CfgMask << Dec3CfgLoc)) | ((valueRaw & Dec3CfgMask) << Dec3CfgLoc));
            }
        }

        private Icm20948AccelConfig2(byte value)
        {
            _value = value;
        }

        public static explicit operator Icm20948AccelConfig2(byte value)
        {
            return new Icm20948AccelConfig2(value);
        }

        public static implicit operator byte(Icm20948AccelConfig2 accelConfig2)
        {
            return accelConfig2._value;
        }
    }
}
