namespace Biscuits.Devices.Icm20948.UserBank0
{
    public struct Icm20948UserCtrl
    {
        private const int DmpEnLoc = 7;
        private const byte DmpEnMask = 0b1;

        private const int FifoEnLoc = 6;
        private const byte FifoEnMask = 0b1;

        private const int I2cMstEnLoc = 5;
        private const byte I2cMstEnMask = 0b1;

        private const int I2cIFDisLoc = 4;
        private const byte I2cIFDisMask = 0b1;

        private const int DmpRstLoc = 3;
        private const byte DmpRstMask = 0b1;

        private const int SramRstLoc = 2;
        private const byte SramRstMask = 0b1;

        private const int I2cMstRstLoc = 1;
        private const byte I2cMstRstMask = 0b1;

        private byte _value;

        public bool DmpEn
        {
            get => ((_value >> DmpEnLoc) & DmpEnMask) != 0;
            set
            {
                byte valueRaw = (byte)(value ? 0b1 : 0b0);
                _value = (byte)((_value & ~(DmpEnMask << DmpEnLoc)) | ((valueRaw & DmpEnMask) << DmpEnLoc));
            }
        }

        public bool FifoEn
        {
            get => ((_value >> FifoEnLoc) & FifoEnMask) != 0;
            set
            {
                byte valueRaw = (byte)(value ? 0b1 : 0b0);
                _value = (byte)((_value & ~(FifoEnMask << FifoEnLoc)) | ((valueRaw & FifoEnMask) << FifoEnLoc));
            }
        }

        public bool I2cMstEn
        {
            get => ((_value >> I2cMstEnLoc) & I2cMstEnMask) != 0;
            set
            {
                byte valueRaw = (byte)(value ? 0b1 : 0b0);
                _value = (byte)((_value & ~(I2cMstEnMask << I2cMstEnLoc)) | ((valueRaw & I2cMstEnMask) << I2cMstEnLoc));
            }
        }

        public bool I2cIFDis
        {
            get => ((_value >> I2cIFDisLoc) & I2cIFDisMask) != 0;
            set
            {
                byte valueRaw = (byte)(value ? 0b1 : 0b0);
                _value = (byte)((_value & ~(I2cIFDisMask << I2cIFDisLoc)) | ((valueRaw & I2cIFDisMask) << I2cIFDisLoc));
            }
        }

        public bool DmpRst
        {
            get => ((_value >> DmpRstLoc) & DmpRstMask) != 0;
            set
            {
                byte valueRaw = (byte)(value ? 0b1 : 0b0);
                _value = (byte)((_value & ~(DmpRstMask << DmpRstLoc)) | ((valueRaw & DmpRstMask) << DmpRstLoc));
            }
        }

        public bool SramRst
        {
            get => ((_value >> SramRstLoc) & SramRstMask) != 0;
            set
            {
                byte valueRaw = (byte)(value ? 0b1 : 0b0);
                _value = (byte)((_value & ~(SramRstMask << SramRstLoc)) | ((valueRaw & SramRstMask) << SramRstLoc));
            }
        }

        public bool I2cMstRst
        {
            get => ((_value >> I2cMstRstLoc) & I2cMstRstMask) != 0;
            set
            {
                byte valueRaw = (byte)(value ? 0b1 : 0b0);
                _value = (byte)((_value & ~(I2cMstRstMask << I2cMstRstLoc)) | ((valueRaw & I2cMstRstMask) << I2cMstRstLoc));
            }
        }

        private Icm20948UserCtrl(byte value)
        {
            _value = value;
        }

        public static explicit operator Icm20948UserCtrl(byte value)
        {
            return new Icm20948UserCtrl(value);
        }

        public static implicit operator byte(Icm20948UserCtrl userCtrl)
        {
            return userCtrl._value;
        }
    }
}
