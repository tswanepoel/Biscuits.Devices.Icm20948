namespace Biscuits.Devices.Icm20948.UserBank0
{
    public struct Icm20948FifoRst
    {
        private const int Unknown1Loc = 4;
        private const byte Unknown1Mask = 0b1;

        private const int Unknown2Loc = 3;
        private const byte Unknown2Mask = 0b1;

        private const int Unknown3Loc = 2;
        private const byte Unknown3Mask = 0b1;

        private const int Unknown4Loc = 1;
        private const byte Unknown4Mask = 0b1;

        private const int GyroLoc = 0;
        private const byte GyroMask = 0b1;

        private byte _value;

        public bool Unknown1
        {
            get => ((_value >> Unknown1Loc) & Unknown1Mask) != 0;
            set
            {
                byte valueRaw = (byte)(value ? 0b1 : 0b0);
                _value = (byte)((_value & ~(Unknown1Mask << Unknown1Loc)) | ((valueRaw & Unknown1Mask) << Unknown1Loc));
            }
        }

        public bool Unknown2
        {
            get => ((_value >> Unknown2Loc) & Unknown2Mask) != 0;
            set
            {
                byte valueRaw = (byte)(value ? 0b1 : 0b0);
                _value = (byte)((_value & ~(Unknown2Mask << Unknown2Loc)) | ((valueRaw & Unknown2Mask) << Unknown2Loc));
            }
        }

        public bool Unknown3
        {
            get => ((_value >> Unknown3Loc) & Unknown3Mask) != 0;
            set
            {
                byte valueRaw = (byte)(value ? 0b1 : 0b0);
                _value = (byte)((_value & ~(Unknown3Mask << Unknown3Loc)) | ((valueRaw & Unknown3Mask) << Unknown3Loc));
            }
        }

        public bool Unknown4
        {
            get => ((_value >> Unknown4Loc) & Unknown4Mask) != 0;
            set
            {
                byte valueRaw = (byte)(value ? 0b1 : 0b0);
                _value = (byte)((_value & ~(Unknown4Mask << Unknown4Loc)) | ((valueRaw & Unknown4Mask) << Unknown4Loc));
            }
        }

        public bool Gyro
        {
            get => ((_value >> GyroLoc) & GyroMask) != 0;
            set
            {
                byte valueRaw = (byte)(value ? 0b1 : 0b0);
                _value = (byte)((_value & ~(GyroMask << GyroLoc)) | ((valueRaw & GyroMask) << GyroLoc));
            }
        }

        private Icm20948FifoRst(byte value)
        {
            _value = value;
        }

        public static explicit operator Icm20948FifoRst(byte value)
        {
            return new Icm20948FifoRst(value);
        }

        public static implicit operator byte(Icm20948FifoRst fifoRst)
        {
            return fifoRst._value;
        }
    }
}
