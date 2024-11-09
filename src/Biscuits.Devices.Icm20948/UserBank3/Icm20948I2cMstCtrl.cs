namespace Biscuits.Devices.Icm20948.UserBank3
{
    public struct Icm20948I2cMstCtrl
    {
        private const int MultMstEnLoc = 7;
        private const byte MultMstEnMask = 0b1;

        private const int I2cMstPNsrLoc = 4;
        private const byte I2cMstPNsrMask = 0b1;

        private const int I2cMstClkLoc = 0;
        private const byte I2cMstClkMask = 0xF;

        private byte _value;

        public bool MultMstEn
        {
            get => ((_value >> MultMstEnLoc) & MultMstEnMask) != 0;
            set
            {
                byte valueRaw = (byte)(value ? 0b1 : 0b0);
                _value = (byte)((_value & ~(MultMstEnMask << MultMstEnLoc)) | ((valueRaw & MultMstEnMask) << MultMstEnLoc));
            }
        }

        public Icm20948I2cMstPNsr I2cMstPNsr
        {
            get => (Icm20948I2cMstPNsr)((_value >> I2cMstPNsrLoc) & I2cMstPNsrMask);
            set
            {
                byte valueRaw = (byte)value;
                _value = (byte)((_value & ~(I2cMstPNsrMask << I2cMstPNsrLoc)) | ((valueRaw & I2cMstPNsrMask) << I2cMstPNsrLoc));
            }
        }

        public Icm20948I2cMstClk I2cMstClk
        {
            get => (Icm20948I2cMstClk)((_value >> I2cMstClkLoc) & I2cMstClkMask);
            set
            {
                byte valueRaw = (byte)value;
                _value = (byte)((_value & ~(I2cMstClkMask << I2cMstClkLoc)) | ((valueRaw & I2cMstClkMask) << I2cMstClkLoc));
            }
        }

        private Icm20948I2cMstCtrl(byte value)
        {
            _value = value;
        }

        public static explicit operator Icm20948I2cMstCtrl(byte value)
        {
            return new Icm20948I2cMstCtrl(value);
        }

        public static implicit operator byte(Icm20948I2cMstCtrl i2cMstCtrl)
        {
            return i2cMstCtrl._value;
        }
    }
}
