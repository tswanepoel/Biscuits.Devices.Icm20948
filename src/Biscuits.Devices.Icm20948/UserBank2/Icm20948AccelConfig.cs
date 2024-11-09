namespace Biscuits.Devices.Icm20948.UserBank2
{
    public struct Icm20948AccelConfig
    {
        private const int AccelDlpfCfgLoc = 3;
        private const byte AccelDlpfCfgMask = 0b111;

        private const int AccelFSSelLoc = 1;
        private const byte AccelFSSelMask = 0b11;

        private const int AccelFChoiceLoc = 0;
        private const byte AccelFChoiceMask = 0b1;

        private byte _value;

        public Icm20948AccelDlpfCfg AccelDlpfCfg
        {
            get => (Icm20948AccelDlpfCfg)((_value >> AccelDlpfCfgLoc) & AccelDlpfCfgMask);
            set
            {
                byte valueRaw = (byte)value;
                _value = (byte)((_value & ~(AccelDlpfCfgMask << AccelDlpfCfgLoc)) | ((valueRaw & AccelDlpfCfgMask) << AccelDlpfCfgLoc));
            }
        }

        public Icm20948AccelFS AccelFS
        {
            get => (Icm20948AccelFS)((_value >> AccelFSSelLoc) & AccelFSSelMask);
            set
            {
                byte valueRaw = (byte)value;
                _value = (byte)((_value & ~(AccelFSSelMask << AccelFSSelLoc)) | ((valueRaw & AccelFSSelMask) << AccelFSSelLoc));
            }
        }

        public Icm20948AccelFChoice AccelFChoice
        {
            get => (Icm20948AccelFChoice)((_value >> AccelFChoiceLoc) & AccelFChoiceMask);
            set
            {
                byte valueRaw = (byte)value;
                _value = (byte)((_value & ~(AccelFChoiceMask << AccelFChoiceLoc)) | ((valueRaw & AccelFChoiceMask) << AccelFChoiceLoc));
            }
        }

        private Icm20948AccelConfig(byte value)
        {
            _value = value;
        }

        public static explicit operator Icm20948AccelConfig(byte value)
        {
            return new Icm20948AccelConfig(value);
        }

        public static implicit operator byte(Icm20948AccelConfig accelConfig)
        {
            return accelConfig._value;
        }
    }
}
