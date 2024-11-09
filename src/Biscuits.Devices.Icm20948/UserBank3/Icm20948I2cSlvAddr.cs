namespace Biscuits.Devices.Icm20948.UserBank3
{
    using System;

    public struct Icm20948I2cSlvAddr
    {
        private const int I2cSlvRnwLoc = 7;
        private const byte I2cSlvRnwMask = 0b1;

        private const int I2cIdLoc = 0;
        private const byte I2cIdMask = 0x7F;

        private byte _value;

        public Icm20948I2cSlvRnw I2cSlvRnw
        {
            get => (Icm20948I2cSlvRnw)((_value >> I2cSlvRnwLoc) & I2cSlvRnwMask);
            set
            {
                byte valueRaw = (byte)value;
                _value = (byte)((_value & ~(I2cSlvRnwMask << I2cSlvRnwLoc)) | ((valueRaw & I2cSlvRnwMask) << I2cSlvRnwLoc));
            }
        }

        public byte I2cId
        {
            get => (byte)((_value >> I2cIdLoc) & I2cIdMask);
            set
            {
                if (value > 0x7F)
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }

                _value = (byte)((_value & ~(I2cIdMask << I2cIdLoc)) | ((value & I2cIdMask) << I2cIdLoc));
            }
        }

        private Icm20948I2cSlvAddr(byte value)
        {
            _value = value;
        }

        public static explicit operator Icm20948I2cSlvAddr(byte value)
        {
            return new Icm20948I2cSlvAddr(value);
        }

        public static implicit operator byte(Icm20948I2cSlvAddr i2cSlvAddr)
        {
            return i2cSlvAddr._value;
        }
    }
}
