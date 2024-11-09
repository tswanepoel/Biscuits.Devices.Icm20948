namespace Biscuits.Devices.Icm20948.UserBank0
{
    public struct Icm20948IntEnable
    {
        private const int RegWofEnLoc = 7;
        private const byte RegWofEnMask = 0b1;

        private const int WomIntEnLoc = 3;
        private const byte WomIntEnMask = 0b1;

        private const int PllRdyEnLoc = 2;
        private const byte PllRdyEnMask = 0b1;

        private const int DmpInt1EnLoc = 1;
        private const byte DmpInt1Mask = 0b1;

        private const int I2cMstIntEnLoc = 0;
        private const byte I2cMstIntEnMask = 0b1;

        private byte _value;

        public bool RegWofEn
        {
            get => ((_value >> RegWofEnLoc) & RegWofEnMask) != 0;
            set
            {
                byte valueRaw = (byte)(value ? 0b1 : 0b0);
                _value = (byte)((_value & ~(RegWofEnMask << RegWofEnLoc)) | ((valueRaw & RegWofEnMask) << RegWofEnLoc));
            }
        }

        public bool WomIntEn
        {
            get => ((_value >> WomIntEnLoc) & WomIntEnMask) != 0;
            set
            {
                byte valueRaw = (byte)(value ? 0b1 : 0b0);
                _value = (byte)((_value & ~(WomIntEnMask << WomIntEnLoc)) | ((valueRaw & WomIntEnMask) << WomIntEnLoc));
            }
        }

        public bool PllRdyEn
        {
            get => ((_value >> PllRdyEnLoc) & PllRdyEnMask) != 0;
            set
            {
                byte valueRaw = (byte)(value ? 0b1 : 0b0);
                _value = (byte)((_value & ~(PllRdyEnMask << PllRdyEnLoc)) | ((valueRaw & PllRdyEnMask) << PllRdyEnLoc));
            }
        }

        public bool DmpInt1En
        {
            get => ((_value >> DmpInt1EnLoc) & DmpInt1Mask) != 0;
            set
            {
                byte valueRaw = (byte)(value ? 0b1 : 0b0);
                _value = (byte)((_value & ~(DmpInt1Mask << DmpInt1EnLoc)) | ((valueRaw & DmpInt1Mask) << DmpInt1EnLoc));
            }
        }

        public bool I2cMstIntEn
        {
            get => ((_value >> I2cMstIntEnLoc) & I2cMstIntEnMask) != 0;
            set
            {
                byte valueRaw = (byte)(value ? 0b1 : 0b0);
                _value = (byte)((_value & ~(I2cMstIntEnMask << I2cMstIntEnLoc)) | ((valueRaw & I2cMstIntEnMask) << I2cMstIntEnLoc));
            }
        }

        private Icm20948IntEnable(byte value)
        {
            _value = value;
        }

        public static explicit operator Icm20948IntEnable(byte value)
        {
            return new Icm20948IntEnable(value);
        }

        public static implicit operator byte(Icm20948IntEnable intEnable)
        {
            return intEnable._value;
        }
    }
}
