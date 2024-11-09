namespace Biscuits.Devices.Icm20948.UserBank2
{
    public struct Icm20948GyroSmplRtDiv
    {
        private const int GyroSmplRtDivLoc = 0;
        private const byte GyroSmplRtDivMask = 0xFF;

        private byte _value;

        public byte GyroSmplRtDiv
        {
            get => (byte)((_value >> GyroSmplRtDivLoc) & GyroSmplRtDivMask);
            set
            {
                _value = (byte)((_value & ~(GyroSmplRtDivMask << GyroSmplRtDivLoc)) | ((value & GyroSmplRtDivMask) << GyroSmplRtDivLoc));
            }
        }

        private Icm20948GyroSmplRtDiv(byte value)
        {
            _value = value;
        }

        public static explicit operator Icm20948GyroSmplRtDiv(byte value)
        {
            return new Icm20948GyroSmplRtDiv(value);
        }

        public static implicit operator byte(Icm20948GyroSmplRtDiv gyroSmplRateDiv)
        {
            return gyroSmplRateDiv._value;
        }
    }
}
