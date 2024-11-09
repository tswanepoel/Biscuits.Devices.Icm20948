namespace Biscuits.Devices.Icm20948.UserBank3
{
    using System;
    
    public struct Icm20948I2cSlvCtrl
    {
        private const int I2cSlvEnLoc = 7;
        private const byte I2cSlvEnMask = 0b1;

        private const int I2cSlvByteSwLoc = 6;
        private const byte I2cSlvByteSwMask = 0b1;

        private const int I2cSlvRegDisLoc = 5;
        private const byte I2cSlvRegDisMask = 0b1;

        private const int I2cSlvGrpLoc = 4;
        private const byte I2cSlvGrpMask = 0b1;

        private const int I2cSlvLengLoc = 0;
        private const byte I2cSlvLengMask = 0xF;

        private byte _value;

        public bool I2cSlvEn
        {
            get => ((_value >> I2cSlvEnLoc) & I2cSlvEnMask) != 0;
            set
            {
                byte valueRaw = (byte)(value ? 0b1 : 0b0);
                _value = (byte)((_value & ~(I2cSlvEnMask << I2cSlvEnLoc)) | ((valueRaw & I2cSlvEnMask) << I2cSlvEnLoc));
            }
        }

        public bool I2cSlvByteSw
        {
            get => ((_value >> I2cSlvByteSwLoc) & I2cSlvByteSwMask) != 0;
            set
            {
                byte valueRaw = (byte)(value ? 0b1 : 0b0);
                _value = (byte)((_value & ~(I2cSlvByteSwMask << I2cSlvByteSwLoc)) | ((valueRaw & I2cSlvByteSwMask) << I2cSlvByteSwLoc));
            }
        }

        public bool I2cSlvRegDis
        {
            get => ((_value >> I2cSlvRegDisLoc) & I2cSlvRegDisMask) != 0;
            set
            {
                byte valueRaw = (byte)(value ? 0b1 : 0b0);
                _value = (byte)((_value & ~(I2cSlvRegDisMask << I2cSlvRegDisLoc)) | ((valueRaw & I2cSlvRegDisMask) << I2cSlvRegDisLoc));
            }
        }

        public bool I2cSlvGrp
        {
            get => ((_value >> I2cSlvGrpLoc) & I2cSlvGrpMask) != 0;
            set
            {
                byte valueRaw = (byte)(value ? 0b1 : 0b0);
                _value = (byte)((_value & ~(I2cSlvGrpMask << I2cSlvGrpLoc)) | ((valueRaw & I2cSlvGrpMask) << I2cSlvGrpLoc));
            }
        }

        public byte I2cSlvLeng
        {
            get => (byte)((_value >> I2cSlvLengLoc) & I2cSlvLengMask);
            set
            {
                if (value > 0xF)
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }

                _value = (byte)((_value & ~(I2cSlvLengMask << I2cSlvLengLoc)) | ((value & I2cSlvLengMask) << I2cSlvLengLoc));
            }
        }

        private Icm20948I2cSlvCtrl(byte value)
        {
            _value = value;
        }

        public static explicit operator Icm20948I2cSlvCtrl(byte value)
        {
            return new Icm20948I2cSlvCtrl(value);
        }

        public static implicit operator byte(Icm20948I2cSlvCtrl i2cSlvCtrl)
        {
            return i2cSlvCtrl._value;
        }
    }
}
