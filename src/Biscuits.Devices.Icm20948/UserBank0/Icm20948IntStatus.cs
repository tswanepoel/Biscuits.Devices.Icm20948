namespace Biscuits.Devices.Icm20948.UserBank0
{
    public readonly struct Icm20948IntStatus
    {
        private const int WomIntLoc = 3;
        private const byte WomIntMask = 0b1;

        private const int PllRdyIntLoc = 2;
        private const byte PllRdyIntMask = 0b1;

        private const int DmpIntLoc = 1;
        private const byte DmpIntMask = 0b1;

        private const int I2cMstIntLoc = 0;
        private const byte I2cMstIntMask = 0b1;

        private readonly byte _value;

        public bool WomInt
        {
            get => ((_value >> WomIntLoc) & WomIntMask) != 0;
        }

        public bool PllRdyInt
        {
            get => ((_value >> PllRdyIntLoc) & PllRdyIntMask) != 0;
        }

        public bool DmpInt
        {
            get => ((_value >> DmpIntLoc) & DmpIntMask) != 0;
        }

        public bool I2cMstInt
        {
            get => ((_value >> I2cMstIntLoc) & I2cMstIntMask) != 0;
        }

        private Icm20948IntStatus(byte value)
        {
            _value = value;
        }

        public static explicit operator Icm20948IntStatus(byte value)
        {
            return new Icm20948IntStatus(value);
        }

        public static implicit operator byte(Icm20948IntStatus intStatus)
        {
            return intStatus._value;
        }
    }
}
