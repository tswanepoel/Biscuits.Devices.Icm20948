namespace Biscuits.Devices.Icm20948.UserBank0
{
    public struct Icm20948FifoModeSel
    {
        private const int FifoModeLoc = 0;
        private const byte FifoModeMask = 0x1F;

        private byte _value;

        public Icm20948FifoMode FifoMode
        {
            get => (Icm20948FifoMode)((_value >> FifoModeLoc) & FifoModeMask);
            set
            {
                byte valueRaw = (byte)value;
                _value = (byte)((_value & ~(FifoModeMask << FifoModeLoc)) | ((valueRaw & FifoModeMask) << FifoModeLoc));
            }
        }

        private Icm20948FifoModeSel(byte value)
        {
            _value = value;
        }

        public static explicit operator Icm20948FifoModeSel(byte value)
        {
            return new Icm20948FifoModeSel(value);
        }

        public static implicit operator byte(Icm20948FifoModeSel fifoMode)
        {
            return fifoMode._value;
        }
    }
}
