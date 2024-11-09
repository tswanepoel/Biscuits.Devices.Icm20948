namespace Biscuits.Devices.Icm20948.UserBank0
{
    public readonly struct Icm20948I2cMstStatus
    {
        private const int PassThroughLoc = 7;
        private const byte PassThroughMask = 0b1;

        private const int I2cSlv4DoneLoc = 6;
        private const byte I2cSlv4DoneMask = 0b1;

        private const int I2cLostArbLoc = 5;
        private const byte I2cLostArbMask = 0b1;

        private const int I2cSlv4NackLoc = 4;
        private const byte I2cSlv4NackMask = 0b1;

        private const int I2cSlv3NackLoc = 3;
        private const byte I2cSlv3NackMask = 0b1;

        private const int I2cSlv2NackLoc = 2;
        private const byte I2cSlv2NackMask = 0b1;

        private const int I2cSlv1NackLoc = 1;
        private const byte I2cSlv1NackMask = 0b1;

        private const int I2cSlv0NackLoc = 0;
        private const byte I2cSlv0NackMask = 0b1;

        private readonly byte _value;

        public bool PassThrough
        {
            get => ((_value >> PassThroughLoc) & PassThroughMask) != 0;
        }

        public bool I2cSlv4Done
        {
            get => ((_value >> I2cSlv4DoneLoc) & I2cSlv4DoneMask) != 0;
        }

        public bool I2cLostArb
        {
            get => ((_value >> I2cLostArbLoc) & I2cLostArbMask) != 0;
        }

        public bool I2cSlv4Nack
        {
            get => ((_value >> I2cSlv4NackLoc) & I2cSlv4NackMask) != 0;
        }

        public bool I2cSlv3Nack
        {
            get => ((_value >> I2cSlv3NackLoc) & I2cSlv3NackMask) != 0;
        }

        public bool I2cSlv2Nack
        {
            get => ((_value >> I2cSlv2NackLoc) & I2cSlv2NackMask) != 0;
        }

        public bool I2cSlv1Nack
        {
            get => ((_value >> I2cSlv1NackLoc) & I2cSlv1NackMask) != 0;
        }

        public bool I2cSlv0Nack
        {
            get => ((_value >> I2cSlv0NackLoc) & I2cSlv0NackMask) != 0;
        }

        private Icm20948I2cMstStatus(byte value)
        {
            _value = value;
        }

        public static explicit operator Icm20948I2cMstStatus(byte value)
        {
            return new Icm20948I2cMstStatus(value);
        }

        public static implicit operator byte(Icm20948I2cMstStatus i2cMstStatus)
        {
            return i2cMstStatus._value;
        }
    }
}
