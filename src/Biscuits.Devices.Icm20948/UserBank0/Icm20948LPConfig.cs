namespace Biscuits.Devices.Icm20948.UserBank0
{
    public struct Icm20948LPConfig
    {
        private const int I2cMstCycleLoc = 6;
        private const byte I2cMstCycleMask = 0b1;

        private const int AccelCycleLoc = 5;
        private const byte AccelCycleMask = 0b1;

        private const int GyroCycleLoc = 4;
        private const byte GyroCycleMask = 0b1;

        private byte _value;

        public Icm20948LPCycle I2cMstCycle
        {
            get => (Icm20948LPCycle)((_value >> I2cMstCycleLoc) & I2cMstCycleMask);
            set
            {
                byte valueRaw = (byte)value;
                _value = (byte)((_value & ~(I2cMstCycleMask << I2cMstCycleLoc)) | ((valueRaw & I2cMstCycleMask) << I2cMstCycleLoc));
            }
        }

        public Icm20948LPCycle AccelCycle
        {
            get => (Icm20948LPCycle)((_value >> AccelCycleLoc) & AccelCycleMask);
            set
            {
                byte valueRaw = (byte)value;
                _value = (byte)((_value & ~(AccelCycleMask << AccelCycleLoc)) | ((valueRaw & AccelCycleMask) << AccelCycleLoc));
            }
        }

        public Icm20948LPCycle GyroCycle
        {
            get => (Icm20948LPCycle)((_value >> GyroCycleLoc) & GyroCycleMask);
            set
            {
                byte valueRaw = (byte)value;
                _value = (byte)((_value & ~(GyroCycleMask << GyroCycleLoc)) | ((valueRaw & GyroCycleMask) << GyroCycleLoc));
            }
        }

        private Icm20948LPConfig(byte value)
        {
            _value = value;
        }

        public static explicit operator Icm20948LPConfig(byte value)
        {
            return new Icm20948LPConfig(value);
        }

        public static implicit operator byte(Icm20948LPConfig lpConfig)
        {
            return lpConfig._value;
        }
    }
}
