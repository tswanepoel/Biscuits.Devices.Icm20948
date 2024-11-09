namespace Biscuits.Devices.Icm20948.UserBank2
{
    using System;

    public struct Icm20948AccelSmplRtDiv
    {
        private const int AccelSmplRtDivLoc = 0;
        private const ushort AccelSmplRtDivMask = 0xFFF;

        private ushort _value;

        public ushort AccelSmplRtDiv
        {
            get => (ushort)((_value >> AccelSmplRtDivLoc) & AccelSmplRtDivMask);
            set
            {
                if (value > 0xFFF)
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }

                _value = (ushort)((_value & ~(AccelSmplRtDivMask << AccelSmplRtDivLoc)) | ((value & AccelSmplRtDivMask) << AccelSmplRtDivLoc));
            }
        }

        private Icm20948AccelSmplRtDiv(ushort value)
        {
            _value = value;
        }

        public static explicit operator Icm20948AccelSmplRtDiv(ushort value)
        {
            return new Icm20948AccelSmplRtDiv(value);
        }

        public static implicit operator ushort(Icm20948AccelSmplRtDiv accelSmplRateDiv)
        {
            return accelSmplRateDiv._value;
        }
    }
}
