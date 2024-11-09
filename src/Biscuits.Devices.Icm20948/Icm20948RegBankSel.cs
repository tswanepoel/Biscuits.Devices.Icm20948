namespace Biscuits.Devices.Icm20948
{
    public struct Icm20948RegBankSel
    {
        private const int UserBankLoc = 4;
        private const byte UserBankMask = 0b11;

        private byte _value;

        public Icm20948UserBank UserBank
        {
            get => (Icm20948UserBank)(_value >> UserBankLoc & UserBankMask);
            set
            {
                byte valueRaw = (byte)value;
                _value = (byte)((_value & ~(UserBankMask << UserBankLoc)) | ((valueRaw & UserBankMask) << UserBankLoc));
            }
        }

        private Icm20948RegBankSel(byte value)
        {
            _value = value;
        }

        public static explicit operator Icm20948RegBankSel(byte value)
        {
            return new Icm20948RegBankSel(value);
        }

        public static implicit operator byte(Icm20948RegBankSel regBankSel)
        {
            return regBankSel._value;
        }
    }
}
