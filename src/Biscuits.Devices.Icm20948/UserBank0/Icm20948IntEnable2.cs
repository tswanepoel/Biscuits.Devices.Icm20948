namespace Biscuits.Devices.Icm20948.UserBank0
{
    public struct Icm20948IntEnable2
    {
        private const int FifoOverflowEnLoc = 0;
        private const byte FifoOverflowEnMask = 0xF;

        private byte _value;

        public bool FifoOverflowEn
        {
            get => ((_value >> FifoOverflowEnLoc) & FifoOverflowEnMask) != 0;
            set
            {
                byte valueRaw = (byte)(value ? 0b1 : 0b0);
                _value = (byte)((_value & ~(FifoOverflowEnMask << FifoOverflowEnLoc)) | ((valueRaw & FifoOverflowEnMask) << FifoOverflowEnLoc));
            }
        }

        private Icm20948IntEnable2(byte value)
        {
            _value = value;
        }

        public static explicit operator Icm20948IntEnable2(byte value)
        {
            return new Icm20948IntEnable2(value);
        }

        public static implicit operator byte(Icm20948IntEnable2 intEnable2)
        {
            return intEnable2._value;
        }
    }
}
