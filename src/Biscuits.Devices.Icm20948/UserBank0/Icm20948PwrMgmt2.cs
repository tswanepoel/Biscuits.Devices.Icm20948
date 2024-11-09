namespace Biscuits.Devices.Icm20948.UserBank0
{
    public struct Icm20948PwrMgmt2
    {
        private const int DisablePressureLoc = 6;
        private const byte DisablePressureMask = 0b1;

        private const int DisableAccelLoc = 3;
        private const byte DisableAccelMask = 0b111;

        private const int DisableGyroLoc = 0;
        private const byte DisableGyroMask = 0b111;

        private byte _value;

        public bool DisablePressure
        {
            get => ((_value >> DisablePressureLoc) & DisablePressureMask) != 0b1;
            set
            {
                byte valueRaw = (byte)(value ? 0b1 : 0b0);
                _value = (byte)((_value & ~(DisablePressureMask << DisablePressureLoc)) | ((valueRaw & DisablePressureMask) << DisablePressureLoc));
            }
        }

        public bool DisableAccel
        {
            get => ((_value >> DisableAccelLoc) & DisableAccelMask) != 0b000;
            set
            {
                byte valueRaw = (byte)(value ? 0b111 : 0b000);
                _value = (byte)((_value & ~(DisableAccelMask << DisableAccelLoc)) | ((valueRaw & DisableAccelMask) << DisableAccelLoc));
            }
        }

        public bool DisableGyro
        {
            get => ((_value >> DisableGyroLoc) & DisableGyroMask) != 0b000;
            set
            {
                byte valueRaw = (byte)(value ? 0b111 : 0b000);
                _value = (byte)((_value & ~(DisableGyroMask << DisableGyroLoc)) | ((valueRaw & DisableGyroMask) << DisableGyroLoc));
            }
        }

        private Icm20948PwrMgmt2(byte value)
        {
            _value = value;
        }

        public static explicit operator Icm20948PwrMgmt2(byte value)
        {
            return new Icm20948PwrMgmt2(value);
        }

        public static implicit operator byte(Icm20948PwrMgmt2 pwrMgmt2)
        {
            return pwrMgmt2._value;
        }
    }
}
