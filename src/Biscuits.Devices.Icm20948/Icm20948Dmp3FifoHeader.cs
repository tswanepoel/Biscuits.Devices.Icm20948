namespace Biscuits.Devices.Icm20948
{
    public readonly struct Icm20948Dmp3FifoHeader
    {
        private const int AccelSetLoc = 15;
        private const ushort AccelSetMask = 0b1;

        private const int GyroSetLoc = 14;
        private const ushort GyroSetMask = 0b1;

        private const int CPassSetLoc = 13;
        private const ushort CPassSetMask = 0b1;

        private const int AlsSetLoc = 12;
        private const ushort AlsSetMask = 0b1;

        private const int Quat6SetLoc = 11;
        private const ushort Quat6SetMask = 0b1;

        private const int Quat9SetLoc = 10;
        private const ushort Quat9SetMask = 0b1;

        private const int PQuat6SetLoc = 9;
        private const ushort PQuat6SetMask = 0b1;

        private const int GeoMagSetLoc = 8;
        private const ushort GeoMagSetMask = 0b1;

        private const int PressureSetLoc = 7;
        private const ushort PressureSetMask = 0b1;

        private const int GyroCalibrSetLoc = 6;
        private const ushort GyroCalibrSetMask = 0b1;

        private const int CPassCalibrSetLoc = 5;
        private const ushort CPassCalibrSetMask = 0b1;

        private const int PedStepDetSetLoc = 4;
        private const ushort PedStepDetSetMask = 0b1;

        private const int Header2SetLoc = 3;
        private const ushort Header2SetMask = 0b1;

        private readonly ushort _value;

        public bool AccelSet
        {
            get => ((_value >> AccelSetLoc) & AccelSetMask) != 0;
        }

        public bool GyroSet
        {
            get => ((_value >> GyroSetLoc) & GyroSetMask) != 0;
        }

        public bool CPassSet
        {
            get => ((_value >> CPassSetLoc) & CPassSetMask) != 0;
        }

        public bool AlsSet
        {
            get => ((_value >> AlsSetLoc) & AlsSetMask) != 0;
        }

        public bool Quat6Set
        {
            get => ((_value >> Quat6SetLoc) & Quat6SetMask) != 0;
        }

        public bool Quat9Set
        {
            get => ((_value >> Quat9SetLoc) & Quat9SetMask) != 0;
        }

        public bool PQuat6Set
        {
            get => ((_value >> PQuat6SetLoc) & PQuat6SetMask) != 0;
        }

        public bool GeoMagSet
        {
            get => ((_value >> GeoMagSetLoc) & GeoMagSetMask) != 0;
        }

        public bool PressureSet
        {
            get => ((_value >> PressureSetLoc) & PressureSetMask) != 0;
        }

        public bool GyroCalibrSet
        {
            get => ((_value >> GyroCalibrSetLoc) & GyroCalibrSetMask) != 0;
        }

        public bool CPassCalibrSet
        {
            get => ((_value >> CPassCalibrSetLoc) & CPassCalibrSetMask) != 0;
        }

        public bool PedStepDetSet
        {
            get => ((_value >> PedStepDetSetLoc) & PedStepDetSetMask) != 0;
        }

        public bool Header2Set
        {
            get => ((_value >> Header2SetLoc) & Header2SetMask) != 0;
        }

        private Icm20948Dmp3FifoHeader(ushort value)
        {
            _value = value;
        }

        public static explicit operator Icm20948Dmp3FifoHeader(ushort value)
        {
            return new Icm20948Dmp3FifoHeader(value);
        }

        public static implicit operator ushort(Icm20948Dmp3FifoHeader fifoHeader)
        {
            return fifoHeader._value;
        }
    }
}
