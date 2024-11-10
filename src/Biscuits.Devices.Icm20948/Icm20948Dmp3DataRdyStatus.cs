namespace Biscuits.Devices.Icm20948
{
    public struct Icm20948Dmp3DataRdyStatus
    {
        private const int SecondaySamplesAvailableLoc = 3;
        private const ushort SecondaySamplesAvailableMask = 0b1;

        private const int AccelSamplesAvailableLoc = 1;
        private const ushort AccelSamplesAvailableMask = 0b1;

        private const int GyroSamplesAvailableLoc = 0;
        private const ushort GyroSamplesAvailableMask = 0b1;

        private ushort _value;

        public bool SecondaySamplesAvailable
        {
            get => ((_value >> SecondaySamplesAvailableLoc) & SecondaySamplesAvailableMask) != 0;
            set
            {
                ushort valueRaw = (ushort)(value ? 0b1 : 0b0);
                _value = (ushort)((_value & ~(SecondaySamplesAvailableMask << SecondaySamplesAvailableLoc)) | ((valueRaw & SecondaySamplesAvailableMask) << SecondaySamplesAvailableLoc));
            }
        }

        public bool AccelSamplesAvailable
        {
            get => ((_value >> AccelSamplesAvailableLoc) & AccelSamplesAvailableMask) != 0;
            set
            {
                ushort valueRaw = (ushort)(value ? 0b1 : 0b0);
                _value = (ushort)((_value & ~(AccelSamplesAvailableMask << AccelSamplesAvailableLoc)) | ((valueRaw & AccelSamplesAvailableMask) << AccelSamplesAvailableLoc));
            }
        }

        public bool GyroSamplesAvailable
        {
            get => ((_value >> GyroSamplesAvailableLoc) & GyroSamplesAvailableMask) != 0;
            set
            {
                ushort valueRaw = (ushort)(value ? 0b1 : 0b0);
                _value = (ushort)((_value & ~(GyroSamplesAvailableMask << GyroSamplesAvailableLoc)) | ((valueRaw & GyroSamplesAvailableMask) << GyroSamplesAvailableLoc));
            }
        }

        private Icm20948Dmp3DataRdyStatus(ushort value)
        {
            _value = value;
        }

        public static explicit operator Icm20948Dmp3DataRdyStatus(ushort value)
        {
            return new Icm20948Dmp3DataRdyStatus(value);
        }

        public static implicit operator ushort(Icm20948Dmp3DataRdyStatus dataRdyStatus)
        {
            return dataRdyStatus._value;
        }
    }
}
