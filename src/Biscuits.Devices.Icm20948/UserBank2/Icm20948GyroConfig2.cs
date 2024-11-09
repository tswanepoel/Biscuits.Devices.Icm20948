namespace Biscuits.Devices.Icm20948.UserBank2
{
    public struct Icm20948GyroConfig2
    {
        private const int XGyroStEnLoc = 5;
        private const byte XGyroStEnMask = 0b1;

        private const int YGyroStEnLoc = 4;
        private const byte YGyroStEnMask = 0b11;

        private const int ZGyroStEnLoc = 3;
        private const byte ZGyroStEnMask = 0b1;

        private const int GyroAvgCfgLoc = 0;
        private const byte GyroAvgCfgMask = 0b111;

        private byte _value;

        public bool XGyroStEn
        {
            get => ((_value >> XGyroStEnLoc) & XGyroStEnMask) != 0;
            set
            {
                byte valueRaw = (byte)(value ? 0b1 : 0b0);
                _value = (byte)((_value & ~(XGyroStEnMask << XGyroStEnLoc)) | ((valueRaw & XGyroStEnMask) << XGyroStEnLoc));
            }
        }

        public bool YGyroStEn
        {
            get => ((_value >> YGyroStEnLoc) & YGyroStEnMask) != 0;
            set
            {
                byte valueRaw = (byte)(value ? 0b1 : 0b0);
                _value = (byte)((_value & ~(YGyroStEnMask << YGyroStEnLoc)) | ((valueRaw & YGyroStEnMask) << YGyroStEnLoc));
            }
        }

        public bool ZGyroStEn
        {
            get => ((_value >> ZGyroStEnLoc) & ZGyroStEnMask) != 0;
            set
            {
                byte valueRaw = (byte)(value ? 0b1 : 0b0);
                _value = (byte)((_value & ~(ZGyroStEnMask << ZGyroStEnLoc)) | ((valueRaw & ZGyroStEnMask) << ZGyroStEnLoc));
            }
        }

        public Icm20948GyroAvgCfg GyroAvgCfg
        {
            get => (Icm20948GyroAvgCfg)((_value >> GyroAvgCfgLoc) & GyroAvgCfgMask);
            set
            {
                byte valueRaw = (byte)value;
                _value = (byte)((_value & ~(GyroAvgCfgMask << GyroAvgCfgLoc)) | ((valueRaw & GyroAvgCfgMask) << GyroAvgCfgLoc));
            }
        }

        private Icm20948GyroConfig2(byte value)
        {
            _value = value;
        }

        public static explicit operator Icm20948GyroConfig2(byte value)
        {
            return new Icm20948GyroConfig2(value);
        }

        public static implicit operator byte(Icm20948GyroConfig2 gyroConfig2)
        {
            return gyroConfig2._value;
        }
    }
}
