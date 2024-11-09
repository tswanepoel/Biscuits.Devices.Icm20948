namespace Biscuits.Devices.Icm20948.UserBank0
{
    public struct Icm20948IntEnable1
    {
        private const int RawData0RdyEnLoc = 0;
        private const byte RawData0RdyEnMask = 0b1;

        private byte _value;

        public bool RawData0RdyEn
        {
            get => ((_value >> RawData0RdyEnLoc) & RawData0RdyEnMask) != 0;
            set
            {
                byte valueRaw = (byte)(value ? 0b1 : 0b0);
                _value = (byte)((_value & ~(RawData0RdyEnMask << RawData0RdyEnLoc)) | ((valueRaw & RawData0RdyEnMask) << RawData0RdyEnLoc));
            }
        }

        private Icm20948IntEnable1(byte value)
        {
            _value = value;
        }

        public static explicit operator Icm20948IntEnable1(byte value)
        {
            return new Icm20948IntEnable1(value);
        }

        public static implicit operator byte(Icm20948IntEnable1 intEnable1)
        {
            return intEnable1._value;
        }
    }
}
