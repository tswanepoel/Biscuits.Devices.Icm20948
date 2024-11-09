namespace Biscuits.Devices.Icm20948.UserBank3
{
    using System;
    
    public struct Icm20948I2cSlv4Ctrl
    {
        private const int I2cSlv4EnLoc = 7;
        private const byte I2cSlv4EnMask = 0b1;

        private const int I2cSlv4IntEnLoc = 6;
        private const byte I2cSlv4IntEnMask = 0b1;

        private const int I2cSlv4RegDisLoc = 5;
        private const byte I2cSlv4RegDisMask = 0b1;

        private const int I2cSlv4DlyLoc = 0;
        private const byte I2cSlv4DlyMask = 0x1F;

        private byte _value;

        public bool I2cSlv4En
        {
            get => ((_value >> I2cSlv4EnLoc) & I2cSlv4EnMask) != 0;
            set
            {
                byte valueRaw = (byte)(value ? 0b1 : 0b0);
                _value = (byte)((_value & ~(I2cSlv4EnMask << I2cSlv4EnLoc)) | ((valueRaw & I2cSlv4EnMask) << I2cSlv4EnLoc));
            }
        }

        public bool I2cSlv4IntEn
        {
            get => ((_value >> I2cSlv4IntEnLoc) & I2cSlv4IntEnMask) != 0;
            set
            {
                byte valueRaw = (byte)(value ? 0b1 : 0b0);
                _value = (byte)((_value & ~(I2cSlv4IntEnMask << I2cSlv4IntEnLoc)) | ((valueRaw & I2cSlv4IntEnMask) << I2cSlv4IntEnLoc));
            }
        }

        public bool I2cSlv4RegDis
        {
            get => ((_value >> I2cSlv4RegDisLoc) & I2cSlv4RegDisMask) != 0;
            set
            {
                byte valueRaw = (byte)(value ? 0b1 : 0b0);
                _value = (byte)((_value & ~(I2cSlv4RegDisMask << I2cSlv4RegDisLoc)) | ((valueRaw & I2cSlv4RegDisMask) << I2cSlv4RegDisLoc));
            }
        }

        public byte I2cSlv4Dly
        {
            get => (byte)((_value >> I2cSlv4DlyLoc) & I2cSlv4DlyMask);
            set
            {
                if (value > 0x1F)
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }

                _value = (byte)((_value & ~(I2cSlv4DlyMask << I2cSlv4DlyLoc)) | ((value & I2cSlv4DlyMask) << I2cSlv4DlyLoc));
            }
        }

        private Icm20948I2cSlv4Ctrl(byte value)
        {
            _value = value;
        }

        public static explicit operator Icm20948I2cSlv4Ctrl(byte value)
        {
            return new Icm20948I2cSlv4Ctrl(value);
        }

        public static implicit operator byte(Icm20948I2cSlv4Ctrl i2cSlv4Ctrl)
        {
            return i2cSlv4Ctrl._value;
        }
    }
}
