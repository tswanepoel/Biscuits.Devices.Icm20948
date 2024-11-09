namespace Biscuits.Devices.Icm20948.UserBank0
{
    public struct Icm20948FifoCfgSel
    {
        private const int FifoCfgLoc = 0;
        private const byte FifoCfgnMask = 0b1;

        private byte _value;

        public Icm20948FifoCfg FifoCfgSel
        {
            get => (Icm20948FifoCfg)((_value >> FifoCfgLoc) & FifoCfgnMask);
            set
            {
                byte valueRaw = (byte)value;
                _value = (byte)((_value & ~(FifoCfgnMask << FifoCfgLoc)) | ((valueRaw & FifoCfgnMask) << FifoCfgLoc));
            }
        }

        private Icm20948FifoCfgSel(byte value)
        {
            _value = value;
        }

        public static explicit operator Icm20948FifoCfgSel(byte value)
        {
            return new Icm20948FifoCfgSel(value);
        }

        public static implicit operator byte(Icm20948FifoCfgSel fifoCfg)
        {
            return fifoCfg._value;
        }
    }
}
