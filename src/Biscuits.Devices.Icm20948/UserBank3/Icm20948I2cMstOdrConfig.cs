namespace Biscuits.Devices.Icm20948.UserBank3
{
    using System;
    
    public struct Icm20948I2cMstOdrConfig
    {
        private const int I2cMstOdrConfigLoc = 0;
        private const byte I2cMstOdrConfigMask = 0xF;

        private byte _value;

        public byte I2cMstOdrConfig
        {
            get => (byte)((_value >> I2cMstOdrConfigLoc) & I2cMstOdrConfigMask);
            set
            {
                if (value > 0xF)
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }

                _value = (byte)((_value & ~(I2cMstOdrConfigMask << I2cMstOdrConfigLoc)) | ((value & I2cMstOdrConfigMask) << I2cMstOdrConfigLoc));
            }
        }

        private Icm20948I2cMstOdrConfig(byte value)
        {
            _value = value;
        }

        public static explicit operator Icm20948I2cMstOdrConfig(byte value)
        {
            return new Icm20948I2cMstOdrConfig(value);
        }

        public static implicit operator byte(Icm20948I2cMstOdrConfig i2cMstOdrConfig)
        {
            return i2cMstOdrConfig._value;
        }
    }
}
