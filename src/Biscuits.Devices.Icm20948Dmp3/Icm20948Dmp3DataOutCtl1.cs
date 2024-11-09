namespace Biscuits.Devices.Icm20948
{
    public struct Icm20948Dmp3DataOutCtl1
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

        private const int PedStepIndSetLoc = 2;
        private const ushort PedStepIndSetMask = 0b111;

        private ushort _value;

        public bool AccelSet
        {
            get => ((_value >> AccelSetLoc) & AccelSetMask) != 0;
            set
            {
                ushort valueRaw = (ushort)(value ? 0b1 : 0b0);
                _value = (ushort)((_value & ~(AccelSetMask << AccelSetLoc)) | ((valueRaw & AccelSetMask) << AccelSetLoc));
            }
        }

        public bool GyroSet
        {
            get => ((_value >> GyroSetLoc) & GyroSetMask) != 0;
            set
            {
                ushort valueRaw = (ushort)(value ? 0b1 : 0b0);
                _value = (ushort)((_value & ~(GyroSetMask << GyroSetLoc)) | ((valueRaw & GyroSetMask) << GyroSetLoc));
            }
        }

        public bool CPassSet
        {
            get => ((_value >> CPassSetLoc) & CPassSetMask) != 0;
            set
            {
                ushort valueRaw = (ushort)(value ? 0b1 : 0b0);
                _value = (ushort)((_value & ~(CPassSetMask << CPassSetLoc)) | ((valueRaw & CPassSetMask) << CPassSetLoc));
            }
        }

        public bool AlsSet
        {
            get => ((_value >> AlsSetLoc) & AlsSetMask) != 0;
            set
            {
                ushort valueRaw = (ushort)(value ? 0b1 : 0b0);
                _value = (ushort)((_value & ~(AlsSetMask << AlsSetLoc)) | ((valueRaw & AlsSetMask) << AlsSetLoc));
            }
        }

        public bool Quat6Set
        {
            get => ((_value >> Quat6SetLoc) & Quat6SetMask) != 0;
            set
            {
                ushort valueRaw = (ushort)(value ? 0b1 : 0b0);
                _value = (ushort)((_value & ~(Quat6SetMask << Quat6SetLoc)) | ((valueRaw & Quat6SetMask) << Quat6SetLoc));
            }
        }

        public bool Quat9Set
        {
            get => ((_value >> Quat9SetLoc) & Quat9SetMask) != 0;
            set
            {
                ushort valueRaw = (ushort)(value ? 0b1 : 0b0);
                _value = (ushort)((_value & ~(Quat9SetMask << Quat9SetLoc)) | ((valueRaw & Quat9SetMask) << Quat9SetLoc));
            }
        }

        public bool PQuat6Set
        {
            get => ((_value >> PQuat6SetLoc) & PQuat6SetMask) != 0;
            set
            {
                ushort valueRaw = (ushort)(value ? 0b1 : 0b0);
                _value = (ushort)((_value & ~(PQuat6SetMask << PQuat6SetLoc)) | ((valueRaw & PQuat6SetMask) << PQuat6SetLoc));
            }
        }

        public bool GeoMagSet
        {
            get => ((_value >> GeoMagSetLoc) & GeoMagSetMask) != 0;
            set
            {
                ushort valueRaw = (ushort)(value ? 0b1 : 0b0);
                _value = (ushort)((_value & ~(GeoMagSetMask << GeoMagSetLoc)) | ((valueRaw & GeoMagSetMask) << GeoMagSetLoc));
            }
        }

        public bool PressureSet
        {
            get => ((_value >> PressureSetLoc) & PressureSetMask) != 0;
            set
            {
                ushort valueRaw = (ushort)(value ? 0b1 : 0b0);
                _value = (ushort)((_value & ~(PressureSetMask << PressureSetLoc)) | ((valueRaw & PressureSetMask) << PressureSetLoc));
            }
        }

        public bool GyroCalibrSet
        {
            get => ((_value >> GyroCalibrSetLoc) & GyroCalibrSetMask) != 0;
            set
            {
                ushort valueRaw = (ushort)(value ? 0b1 : 0b0);
                _value = (ushort)((_value & ~(GyroCalibrSetMask << GyroCalibrSetLoc)) | ((valueRaw & GyroCalibrSetMask) << GyroCalibrSetLoc));
            }
        }

        public bool CPassCalibrSet
        {
            get => ((_value >> CPassCalibrSetLoc) & CPassCalibrSetMask) != 0;
            set
            {
                ushort valueRaw = (ushort)(value ? 0b1 : 0b0);
                _value = (ushort)((_value & ~(CPassCalibrSetMask << CPassCalibrSetLoc)) | ((valueRaw & CPassCalibrSetMask) << CPassCalibrSetLoc));
            }
        }

        public bool PedStepDetSet
        {
            get => ((_value >> PedStepDetSetLoc) & PedStepDetSetMask) != 0;
            set
            {
                ushort valueRaw = (ushort)(value ? 0b1 : 0b0);
                _value = (ushort)((_value & ~(PedStepDetSetMask << PedStepDetSetLoc)) | ((valueRaw & PedStepDetSetMask) << PedStepDetSetLoc));
            }
        }

        public bool Header2Set
        {
            get => ((_value >> Header2SetLoc) & Header2SetMask) != 0;
            set
            {
                ushort valueRaw = (ushort)(value ? 0b1 : 0b0);
                _value = (ushort)((_value & ~(Header2SetMask << Header2SetLoc)) | ((valueRaw & Header2SetMask) << Header2SetLoc));
            }
        }

        public bool PedStepIndSet
        {
            get => ((_value >> PedStepIndSetLoc) & PedStepIndSetMask) != 0b000;
            set
            {
                ushort valueRaw = (ushort)(value ? 0b111 : 0b000);
                _value = (ushort)((_value & ~(PedStepIndSetMask << PedStepIndSetLoc)) | ((valueRaw & PedStepIndSetMask) << PedStepIndSetLoc));
            }
        }

        private Icm20948Dmp3DataOutCtl1(ushort value)
        {
            _value = value;
        }

        public static explicit operator Icm20948Dmp3DataOutCtl1(ushort value)
        {
            return new Icm20948Dmp3DataOutCtl1(value);
        }

        public static implicit operator ushort(Icm20948Dmp3DataOutCtl1 dataOutCtl1)
        {
            return dataOutCtl1._value;
        }
    }
}
