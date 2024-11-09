namespace Biscuits.Devices.Icm20948.UserBank0
{
    public struct Icm20948FifoEn2
    {
        private const int AccelFifoEnLoc = 4;
        private const byte AccelFifoEnMask = 0b1;

        private const int GyroZFifoEnLoc = 3;
        private const byte GyroZFifoEnMask = 0b1;

        private const int GyroYFifoEnLoc = 2;
        private const byte GyroYFifoEnMask = 0b1;

        private const int GyroXFifoEnLoc = 1;
        private const byte GyroXFifoEnMask = 0b1;

        private const int TempFifoEnLoc = 0;
        private const byte TempFifoEnMask = 0b1;

        private byte _value;

        public bool AccelFifoEn
        {
            get => ((_value >> AccelFifoEnLoc) & AccelFifoEnMask) != 0;
            set
            {
                byte valueRaw = (byte)(value ? 0b1 : 0b0);
                _value = (byte)((_value & ~(AccelFifoEnMask << AccelFifoEnLoc)) | ((valueRaw & AccelFifoEnMask) << AccelFifoEnLoc));
            }
        }
        
        public bool GyroZFifoEn
        {
            get => ((_value >> GyroZFifoEnLoc) & GyroZFifoEnMask) != 0;
            set
            {
                byte valueRaw = (byte)(value ? 0b1 : 0b0);
                _value = (byte)((_value & ~(GyroZFifoEnMask << GyroZFifoEnLoc)) | ((valueRaw & GyroZFifoEnMask) << GyroZFifoEnLoc));
            }
        }

        public bool GyroYFifoEn
        {
            get => ((_value >> GyroYFifoEnLoc) & GyroYFifoEnMask) != 0;
            set
            {
                byte valueRaw = (byte)(value ? 0b1 : 0b0);
                _value = (byte)((_value & ~(GyroYFifoEnMask << GyroYFifoEnLoc)) | ((valueRaw & GyroYFifoEnMask) << GyroYFifoEnLoc));
            }
        }

        public bool GyroXFifoEn
        {
            get => ((_value >> GyroXFifoEnLoc) & GyroXFifoEnMask) != 0;
            set
            {
                byte valueRaw = (byte)(value ? 0b1 : 0b0);
                _value = (byte)((_value & ~(GyroXFifoEnMask << GyroXFifoEnLoc)) | ((valueRaw & GyroXFifoEnMask) << GyroXFifoEnLoc));
            }
        }

        public bool TempFifoEn
        {
            get => ((_value >> TempFifoEnLoc) & TempFifoEnMask) != 0;
            set
            {
                byte valueRaw = (byte)(value ? 0b1 : 0b0);
                _value = (byte)((_value & ~(TempFifoEnMask << TempFifoEnLoc)) | ((valueRaw & TempFifoEnMask) << TempFifoEnLoc));
            }
        }

        private Icm20948FifoEn2(byte value)
        {
            _value = value;
        }

        public static explicit operator Icm20948FifoEn2(byte value)
        {
            return new Icm20948FifoEn2(value);
        }

        public static implicit operator byte(Icm20948FifoEn2 fifoEn2)
        {
            return fifoEn2._value;
        }
    }
}
