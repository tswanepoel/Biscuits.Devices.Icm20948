namespace Biscuits.Devices.Icm20948.UserBank3
{
    public struct Icm20948I2cSlvReg
    {
        private const int I2cSlvRegLoc = 0;
        private const byte I2cSlvRegMask = 0xFF;

        private byte _value;

        public byte I2cSlvReg
        {
            get => (byte)((_value >> I2cSlvRegLoc) & I2cSlvRegMask);
            set
            {
                _value = (byte)((_value & ~(I2cSlvRegMask << I2cSlvRegLoc)) | ((value & I2cSlvRegMask) << I2cSlvRegLoc));
            }
        }

        private Icm20948I2cSlvReg(byte value)
        {
            _value = value;
        }

        public static explicit operator Icm20948I2cSlvReg(byte value)
        {
            return new Icm20948I2cSlvReg(value);
        }

        public static implicit operator byte(Icm20948I2cSlvReg i2cSlvReg)
        {
            return i2cSlvReg._value;
        }
    }
}