namespace Biscuits.Devices.Icm20948.UserBank0
{
    public struct Icm20948IntPinCfg
    {
        private const int Int1ActlLoc = 7;
        private const byte Int1ActlMask = 0b1;

        private const int Int1OpenLoc = 6;
        private const byte Int1OpenMask = 0b1;

        private const int Int1LatchEnLoc = 5;
        private const byte Int1LatchEnMask = 0b1;

        private const int IntAnyRd2ClearEnLoc = 4;
        private const byte IntAnyRd2ClearEnMask = 0b1;

        private const int ActlFSyncLoc = 3;
        private const byte ActlFSyncMask = 0b1;

        private const int FSyncIntModeEnLoc = 2;
        private const byte FSyncIntModeEnMask = 0b1;

        private const int BypassEnLoc = 1;
        private const byte BypassEnMask = 0b1;

        private byte _value;

        public bool Int1Actl
        {
            get => ((_value >> Int1ActlLoc) & Int1ActlMask) != 0;
            set
            {
                byte valueRaw = (byte)(value ? 0b1 : 0b0);
                _value = (byte)((_value & ~(Int1ActlMask << Int1ActlLoc)) | ((valueRaw & Int1ActlMask) << Int1ActlLoc));
            }
        }

        public bool Int1Open
        {
            get => ((_value >> Int1OpenLoc) & Int1OpenMask) != 0;
            set
            {
                byte valueRaw = (byte)(value ? 0b1 : 0b0);
                _value = (byte)((_value & ~(Int1OpenMask << Int1OpenLoc)) | ((valueRaw & Int1OpenMask) << Int1OpenLoc));
            }
        }

        public bool Int1LatchEn
        {
            get => ((_value >> Int1LatchEnLoc) & Int1LatchEnMask) != 0;
            set
            {
                byte valueRaw = (byte)(value ? 0b1 : 0b0);
                _value = (byte)((_value & ~(Int1LatchEnMask << Int1LatchEnLoc)) | ((valueRaw & Int1LatchEnMask) << Int1LatchEnLoc));
            }
        }

        public bool IntAnyRd2ClearEn
        {
            get => ((_value >> IntAnyRd2ClearEnLoc) & IntAnyRd2ClearEnMask) != 0;
            set
            {
                byte valueRaw = (byte)(value ? 0b1 : 0b0);
                _value = (byte)((_value & ~(IntAnyRd2ClearEnMask << IntAnyRd2ClearEnLoc)) | ((valueRaw & IntAnyRd2ClearEnMask) << IntAnyRd2ClearEnLoc));
            }
        }

        public bool ActlFSync
        {
            get => ((_value >> ActlFSyncLoc) & ActlFSyncMask) != 0;
            set
            {
                byte valueRaw = (byte)(value ? 0b1 : 0b0);
                _value = (byte)((_value & ~(ActlFSyncMask << ActlFSyncLoc)) | ((valueRaw & ActlFSyncMask) << ActlFSyncLoc));
            }
        }

        public bool FSyncIntModeEn
        {
            get => ((_value >> FSyncIntModeEnLoc) & FSyncIntModeEnMask) != 0;
            set
            {
                byte valueRaw = (byte)(value ? 0b1 : 0b0);
                _value = (byte)((_value & ~(FSyncIntModeEnMask << FSyncIntModeEnLoc)) | ((valueRaw & FSyncIntModeEnMask) << FSyncIntModeEnLoc));
            }
        }

        public bool BypassEn
        {
            get => ((_value >> BypassEnLoc) & BypassEnMask) != 0;
            set
            {
                byte valueRaw = (byte)(value ? 0b1 : 0b0);
                _value = (byte)((_value & ~(BypassEnMask << BypassEnLoc)) | ((valueRaw & BypassEnMask) << BypassEnLoc));
            }
        }

        private Icm20948IntPinCfg(byte value)
        {
            _value = value;
        }

        public static explicit operator Icm20948IntPinCfg(byte value)
        {
            return new Icm20948IntPinCfg(value);
        }

        public static implicit operator byte(Icm20948IntPinCfg lpConfig)
        {
            return lpConfig._value;
        }
    }
}
