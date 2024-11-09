namespace Biscuits.Devices.Icm20948.UserBank2
{
    public struct Icm20948GyroConfig1
    {
        private const int GyroDlpfCfgLoc = 3;
        private const byte GyroDlpfCfgMask = 0b111;

        private const int GyroFSSelLoc = 1;
        private const byte GyroFSSelMask = 0b11;

        private const int GyroFChoiceLoc = 0;
        private const byte GyroFChoiceMask = 0b1;

        private byte _value;

        public Icm20948GyroDlpfCfg GyroDlpfCfg
        {
            get => (Icm20948GyroDlpfCfg)((_value >> GyroDlpfCfgLoc) & GyroDlpfCfgMask);
            set
            {
                byte valueRaw = (byte)value;
                _value = (byte)((_value & ~(GyroDlpfCfgMask << GyroDlpfCfgLoc)) | ((valueRaw & GyroDlpfCfgMask) << GyroDlpfCfgLoc));
            }
        }

        public Icm20948GyroFS GyroFS
        {
            get => (Icm20948GyroFS)((_value >> GyroFSSelLoc) & GyroFSSelMask);
            set
            {
                byte valueRaw = (byte)value;
                _value = (byte)((_value & ~(GyroFSSelMask << GyroFSSelLoc)) | ((valueRaw & GyroFSSelMask) << GyroFSSelLoc));
            }
        }

        public Icm20948GyroFChoice GyroFChoice
        {
            get => (Icm20948GyroFChoice)((_value >> GyroFChoiceLoc) & GyroFChoiceMask);
            set
            {
                byte valueRaw = (byte)value;
                _value = (byte)((_value & ~(GyroFChoiceMask << GyroFChoiceLoc)) | ((valueRaw & GyroFChoiceMask) << GyroFChoiceLoc));
            }
        }

        private Icm20948GyroConfig1(byte value)
        {
            _value = value;
        }

        public static explicit operator Icm20948GyroConfig1(byte value)
        {
            return new Icm20948GyroConfig1(value);
        }

        public static implicit operator byte(Icm20948GyroConfig1 gyroConfig1)
        {
            return gyroConfig1._value;
        }
    }
}
