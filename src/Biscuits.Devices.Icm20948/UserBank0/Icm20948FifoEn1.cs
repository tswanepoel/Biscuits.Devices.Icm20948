namespace Biscuits.Devices.Icm20948.UserBank0
{
    public struct Icm20948FifoEn1
    {
        private const int Slv3FifoEnLoc = 3;
        private const byte Slv3FifoEnMask = 0b1;

        private const int Slv2FifoEnLoc = 2;
        private const byte Slv2FifoEnMask = 0b1;

        private const int Slv1FifoEnLoc = 1;
        private const byte Slv1FifoEnMask = 0b1;

        private const int Slv0FifoEnLoc = 0;
        private const byte Slv0FifoEnMask = 0b1;

        private byte _value;

        public bool Slv3FifoEn
        {
            get => ((_value >> Slv3FifoEnLoc) & Slv3FifoEnMask) != 0;
            set
            {
                byte valueRaw = (byte)(value ? 0b1 : 0b0);
                _value = (byte)((_value & ~(Slv3FifoEnMask << Slv3FifoEnLoc)) | ((valueRaw & Slv3FifoEnMask) << Slv3FifoEnLoc));
            }
        }
        
        public bool Slv2FifoEn
        {
            get => ((_value >> Slv2FifoEnLoc) & Slv2FifoEnMask) != 0;
            set
            {
                byte valueRaw = (byte)(value ? 0b1 : 0b0);
                _value = (byte)((_value & ~(Slv2FifoEnMask << Slv2FifoEnLoc)) | ((valueRaw & Slv2FifoEnMask) << Slv2FifoEnLoc));
            }
        }

        public bool Slv1FifoEn
        {
            get => ((_value >> Slv1FifoEnLoc) & Slv1FifoEnMask) != 0;
            set
            {
                byte valueRaw = (byte)(value ? 0b1 : 0b0);
                _value = (byte)((_value & ~(Slv1FifoEnMask << Slv1FifoEnLoc)) | ((valueRaw & Slv1FifoEnMask) << Slv1FifoEnLoc));
            }
        }

        public bool Slv0FifoEn
        {
            get => ((_value >> Slv0FifoEnLoc) & Slv0FifoEnMask) != 0;
            set
            {
                byte valueRaw = (byte)(value ? 0b1 : 0b0);
                _value = (byte)((_value & ~(Slv0FifoEnMask << Slv0FifoEnLoc)) | ((valueRaw & Slv0FifoEnMask) << Slv0FifoEnLoc));
            }
        }

        private Icm20948FifoEn1(byte value)
        {
            _value = value;
        }

        public static explicit operator Icm20948FifoEn1(byte value)
        {
            return new Icm20948FifoEn1(value);
        }

        public static implicit operator byte(Icm20948FifoEn1 fifoEn1)
        {
            return fifoEn1._value;
        }
    }
}
