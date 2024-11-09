namespace Biscuits.Devices.Icm20948
{
    public struct Icm20948Dmp3MotionEventCtl
    {
        private const int BacWearEnLoc = 15;
        private const ushort BacWearEnMask = 0b1;

        private const int PedometerEnLoc = 14;
        private const ushort PedometerEnMask = 0b1;

        private const int PedometerIntEnLoc = 13;
        private const ushort PedometerIntEnMask = 0b1;

        private const int SmdEnLoc = 11;
        private const ushort SmdEnMask = 0b1;

        private const int AccelCalEnLoc = 9;
        private const ushort AccelCalEnMask = 0b1;

        private const int GyroCalEnLoc = 8;
        private const ushort GyroCalEnMask = 0b1;

        private const int CompassCalEnLoc = 7;
        private const ushort CompassCalEnMask = 0b1;

        private const int NineAxisEnLoc = 6;
        private const ushort NineAxisEnMask = 0b1;

        private const int GeoMagEnLoc = 4;
        private const ushort GeoMagEnMask = 0b1;

        private const int BtsLtsEnLoc = 3;
        private const ushort BtsLtsEnMask = 0b1;

        private const int BacAccelOnlyEnLoc = 2;
        private const ushort BacAccelOnlyEnMask = 0b1;

        private ushort _value;

        public bool BacWearEn
        {
            get => ((_value >> BacWearEnLoc) & BacWearEnMask) != 0;
            set
            {
                ushort valueRaw = (ushort)(value ? 0b1 : 0b0);
                _value = (ushort)((_value & ~(BacWearEnMask << BacWearEnLoc)) | ((valueRaw & BacWearEnMask) << BacWearEnLoc));
            }
        }

        public bool PedometerEn
        {
            get => ((_value >> PedometerEnLoc) & PedometerEnMask) != 0;
            set
            {
                ushort valueRaw = (ushort)(value ? 0b1 : 0b0);
                _value = (ushort)((_value & ~(PedometerEnMask << PedometerEnLoc)) | ((valueRaw & PedometerEnMask) << PedometerEnLoc));
            }
        }

        public bool PedometerIntEn
        {
            get => ((_value >> PedometerIntEnLoc) & PedometerIntEnMask) != 0;
            set
            {
                ushort valueRaw = (ushort)(value ? 0b1 : 0b0);
                _value = (ushort)((_value & ~(PedometerIntEnMask << PedometerIntEnLoc)) | ((valueRaw & PedometerIntEnMask) << PedometerIntEnLoc));
            }
        }

        public bool SmdEn
        {
            get => ((_value >> SmdEnLoc) & SmdEnMask) != 0;
            set
            {
                ushort valueRaw = (ushort)(value ? 0b1 : 0b0);
                _value = (ushort)((_value & ~(SmdEnMask << SmdEnLoc)) | ((valueRaw & SmdEnMask) << SmdEnLoc));
            }
        }

        public bool AccelCalEn
        {
            get => ((_value >> AccelCalEnLoc) & AccelCalEnMask) != 0;
            set
            {
                ushort valueRaw = (ushort)(value ? 0b1 : 0b0);
                _value = (ushort)((_value & ~(AccelCalEnMask << AccelCalEnLoc)) | ((valueRaw & AccelCalEnMask) << AccelCalEnLoc));
            }
        }

        public bool GyroCalEn
        {
            get => ((_value >> GyroCalEnLoc) & GyroCalEnMask) != 0;
            set
            {
                ushort valueRaw = (ushort)(value ? 0b1 : 0b0);
                _value = (ushort)((_value & ~(GyroCalEnMask << GyroCalEnLoc)) | ((valueRaw & GyroCalEnMask) << GyroCalEnLoc));
            }
        }

        public bool CompassCalEn
        {
            get => ((_value >> CompassCalEnLoc) & CompassCalEnMask) != 0;
            set
            {
                ushort valueRaw = (ushort)(value ? 0b1 : 0b0);
                _value = (ushort)((_value & ~(CompassCalEnMask << CompassCalEnLoc)) | ((valueRaw & CompassCalEnMask) << CompassCalEnLoc));
            }
        }

        public bool NineAxisEn
        {
            get => ((_value >> NineAxisEnLoc) & NineAxisEnMask) != 0;
            set
            {
                ushort valueRaw = (ushort)(value ? 0b1 : 0b0);
                _value = (ushort)((_value & ~(NineAxisEnMask << NineAxisEnLoc)) | ((valueRaw & NineAxisEnMask) << NineAxisEnLoc));
            }
        }

        public bool GeoMagEn
        {
            get => ((_value >> GeoMagEnLoc) & GeoMagEnMask) != 0;
            set
            {
                ushort valueRaw = (ushort)(value ? 0b1 : 0b0);
                _value = (ushort)((_value & ~(GeoMagEnMask << GeoMagEnLoc)) | ((valueRaw & GeoMagEnMask) << GeoMagEnLoc));
            }
        }

        public bool BtsLtsEn
        {
            get => ((_value >> BtsLtsEnLoc) & BtsLtsEnMask) != 0;
            set
            {
                ushort valueRaw = (ushort)(value ? 0b1 : 0b0);
                _value = (ushort)((_value & ~(BtsLtsEnMask << BtsLtsEnLoc)) | ((valueRaw & BtsLtsEnMask) << BtsLtsEnLoc));
            }
        }

        public bool BacAccelOnlyEn
        {
            get => ((_value >> BacAccelOnlyEnLoc) & BacAccelOnlyEnMask) != 0;
            set
            {
                ushort valueRaw = (ushort)(value ? 0b1 : 0b0);
                _value = (ushort)((_value & ~(BacAccelOnlyEnMask << BacAccelOnlyEnLoc)) | ((valueRaw & BacAccelOnlyEnMask) << BacAccelOnlyEnLoc));
            }
        }

        private Icm20948Dmp3MotionEventCtl(ushort value)
        {
            _value = value;
        }

        public static explicit operator Icm20948Dmp3MotionEventCtl(ushort value)
        {
            return new Icm20948Dmp3MotionEventCtl(value);
        }

        public static implicit operator ushort(Icm20948Dmp3MotionEventCtl motionEventCtl)
        {
            return motionEventCtl._value;
        }
    }
}
