using System.Numerics;

namespace Biscuits.Devices.Icm20948
{
    public class Icm20948FifoPacket
    {
        // Accelerometer
        public short? AccelX { get; set; }
        public short? AccelY { get; set; }
        public short? AccelZ { get; set; }

        // Gyroscope
        public short? GyroX { get; set; }
        public short? GyroY { get; set; }
        public short? GyroZ { get; set; }

        // Magnetometer (Compass)
        public short? MagX { get; set; }
        public short? MagY { get; set; }
        public short? MagZ { get; set; }

        // Quaternion (6-axis)
        public Quaternion? Quat6 { get; set; }
    }
}
