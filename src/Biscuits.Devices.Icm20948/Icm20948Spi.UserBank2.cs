namespace Biscuits.Devices.Icm20948
{
    using System;
    using Microsoft.Extensions.Logging;
    using UserBank2;

    public partial class Icm20948Spi
    {
        public Icm20948GyroSmplRtDiv ReadGyroSmplRtDiv()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(Icm20948Spi));
            }

            byte valueRaw = ReadRegisterByte(Icm20948UserBank.UserBank2, 0x00/*GYRO_SMPLRT_DIV*/);
            var gyroSmlpRtDiv = (Icm20948GyroSmplRtDiv)valueRaw;
            
            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Read from User Bank 0x{UserBank:X2} Reg 0x{Address:X2} ({Name}): 0x{Data:X2} ({@Value})", 
                    (byte)Icm20948UserBank.UserBank2, 
                    0x00/*GYRO_SMPLRT_DIV*/, 
                    "GYRO_SMPLRT_DIV", 
                    valueRaw,
                    gyroSmlpRtDiv
                );
            }

            return gyroSmlpRtDiv;
        }

        public void WriteGyroSmplRtDiv(Icm20948GyroSmplRtDiv gyroSmplRtDiv)
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(Icm20948Spi));
            }

            var valueRaw = (byte)gyroSmplRtDiv;

            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Write to User Bank 0x{UserBank:X2} Reg 0x{Address:X2} ({Name}): 0x{Data:X2} ({@Value})", 
                    (byte)Icm20948UserBank.UserBank2, 
                    0x00/*GYRO_SMPLRT_DIV*/, 
                    "GYRO_SMPLRT_DIV", 
                    valueRaw,
                    gyroSmplRtDiv
                );
            }

            WriteRegisterByte(Icm20948UserBank.UserBank2, 0x00/*GYRO_SMPLRT_DIV*/, valueRaw);
        }

        public Icm20948GyroConfig1 ReadGyroConfig1()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(Icm20948Spi));
            }

            byte valueRaw = ReadRegisterByte(Icm20948UserBank.UserBank2, 0x01/*GYRO_CONFIG_1*/);
            var gyroConfig1 = (Icm20948GyroConfig1)valueRaw;
            
            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Read from User Bank 0x{UserBank:X2} Reg 0x{Address:X2} ({Name}): 0x{Data:X2} ({@Value})", 
                    (byte)Icm20948UserBank.UserBank2, 
                    0x01/*GYRO_CONFIG_1*/, 
                    "GYRO_CONFIG_1", 
                    valueRaw,
                    gyroConfig1
                );
            }

            return gyroConfig1;
        }

        public void WriteGyroConfig1(Icm20948GyroConfig1 gyroConfig1)
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(Icm20948Spi));
            }

            var valueRaw = (byte)gyroConfig1;

            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Write to User Bank 0x{UserBank:X2} Reg 0x{Address:X2} ({Name}): 0x{Data:X2} ({@Value})", 
                    (byte)Icm20948UserBank.UserBank2, 
                    0x01/*GYRO_CONFIG_1*/, 
                    "GYRO_CONFIG_1", 
                    valueRaw,
                    gyroConfig1
                );
            }

            WriteRegisterByte(Icm20948UserBank.UserBank2, 0x01/*GYRO_CONFIG_1*/, valueRaw);
        }

        public Icm20948GyroConfig2 ReadGyroConfig2()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(Icm20948Spi));
            }

            byte valueRaw = ReadRegisterByte(Icm20948UserBank.UserBank2, 0x02/*GYRO_CONFIG_2*/);
            var gyroConfig2 = (Icm20948GyroConfig2)valueRaw;
            
            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Read from User Bank 0x{UserBank:X2} Reg 0x{Address:X2} ({Name}): 0x{Data:X2} ({@Value})", 
                    (byte)Icm20948UserBank.UserBank2, 
                    0x02/*GYRO_CONFIG_2*/, 
                    "GYRO_CONFIG_2", 
                    valueRaw,
                    gyroConfig2
                );
            }

            return gyroConfig2;
        }

        public void WriteGyroConfig2(Icm20948GyroConfig2 gyroConfig2)
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(Icm20948Spi));
            }

            var valueRaw = (byte)gyroConfig2;

            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Write to User Bank 0x{UserBank:X2} Reg 0x{Address:X2} ({Name}): 0x{Data:X2} ({@Value})", 
                    (byte)Icm20948UserBank.UserBank2, 
                    0x02/*GYRO_CONFIG_2*/, 
                    "GYRO_CONFIG_2", 
                    valueRaw,
                    gyroConfig2
                );
            }

            WriteRegisterByte(Icm20948UserBank.UserBank2, 0x02/*GYRO_CONFIG_2*/, valueRaw);
        }

        public Icm20948AccelSmplRtDiv ReadAccelSmplRtDiv()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(Icm20948Spi));
            }

            ushort valueRaw = ReadRegisterUInt16(Icm20948UserBank.UserBank2, 0x10/*ACCEL_SMPLRT_DIV_1*/);
            var accelSmplRtDiv = (Icm20948AccelSmplRtDiv)valueRaw;
            
            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Read from User Bank 0x{UserBank:X2} Reg 0x{Address:X2} ({Name}): 0x{Data:X4} ({@Value})", 
                    (byte)Icm20948UserBank.UserBank2, 
                    0x10/*ACCEL_SMPLRT_DIV_1*/, 
                    "ACCEL_SMPLRT_DIV_1", 
                    valueRaw,
                    accelSmplRtDiv
                );
            }

            return accelSmplRtDiv;
        }

        public void WriteAccelSmplRtDiv(Icm20948AccelSmplRtDiv accelSmplRtDiv)
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(Icm20948Spi));
            }

            var valueRaw = (ushort)accelSmplRtDiv;

            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Write to User Bank 0x{UserBank:X2} Reg 0x{Address:X2} ({Name}): 0x{Data:X4} ({@Value})", 
                    (byte)Icm20948UserBank.UserBank2, 
                    0x10/*ACCEL_SMPLRT_DIV_1*/, 
                    "ACCEL_SMPLRT_DIV_1", 
                    valueRaw,
                    accelSmplRtDiv
                );
            }

            WriteRegisterUInt16(Icm20948UserBank.UserBank2, 0x10/*ACCEL_SMPLRT_DIV_1*/, valueRaw);
        }
        
        public Icm20948AccelConfig ReadAccelConfig()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(Icm20948Spi));
            }

            byte valueRaw = ReadRegisterByte(Icm20948UserBank.UserBank2, 0x14/*ACCEL_CONFIG*/);
            var accelConfig = (Icm20948AccelConfig)valueRaw;
            
            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Read from User Bank 0x{UserBank:X2} Reg 0x{Address:X2} ({Name}): 0x{Data:X2} ({@Value})", 
                    (byte)Icm20948UserBank.UserBank2, 
                    0x14/*ACCEL_CONFIG*/, 
                    "ACCEL_CONFIG", 
                    valueRaw,
                    accelConfig
                );
            }

            return accelConfig;
        }

        public void WriteAccelConfig(Icm20948AccelConfig accelConfig)
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(Icm20948Spi));
            }

            var valueRaw = (byte)accelConfig;

            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Write to User Bank 0x{UserBank:X2} Reg 0x{Address:X2} ({Name}): 0x{Data:X2} ({@Value})", 
                    (byte)Icm20948UserBank.UserBank2, 
                    0x14/*ACCEL_CONFIG*/, 
                    "ACCEL_CONFIG", 
                    valueRaw,
                    accelConfig
                );
            }

            WriteRegisterByte(Icm20948UserBank.UserBank2, 0x14/*ACCEL_CONFIG*/, valueRaw);
        }

        public Icm20948AccelConfig2 ReadAccelConfig2()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(Icm20948Spi));
            }

            byte valueRaw = ReadRegisterByte(Icm20948UserBank.UserBank2, 0x15/*ACCEL_CONFIG_2*/);
            var accelConfig2 = (Icm20948AccelConfig2)valueRaw;
            
            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Read from User Bank 0x{UserBank:X2} Reg 0x{Address:X2} ({Name}): 0x{Data:X2} ({@Value})", 
                    (byte)Icm20948UserBank.UserBank2, 
                    0x15/*ACCEL_CONFIG_2*/, 
                    "ACCEL_CONFIG_2", 
                    valueRaw,
                    accelConfig2
                );
            }

            return accelConfig2;
        }

        public void WriteAccelConfig2(Icm20948AccelConfig2 accelConfig2)
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(Icm20948Spi));
            }

            var valueRaw = (byte)accelConfig2;

            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Write to User Bank 0x{UserBank:X2} Reg 0x{Address:X2} ({Name}): 0x{Data:X2} ({@Value})", 
                    (byte)Icm20948UserBank.UserBank2, 
                    0x15/*ACCEL_CONFIG_2*/, 
                    "ACCEL_CONFIG_2", 
                    valueRaw,
                    accelConfig2
                );
            }

            WriteRegisterByte(Icm20948UserBank.UserBank2, 0x15/*ACCEL_CONFIG_2*/, valueRaw);
        }

        public void WritePrgmStartAddrH(ushort value)
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(Icm20948Spi));
            }

            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Write to User Bank 0x{UserBank:X2} Reg 0x{Address:X2} ({Name}): 0x{Data:X4}", 
                    (byte)Icm20948UserBank.UserBank2, 
                    0x50/*PRGM_START_ADDRH*/, 
                    "PRGM_START_ADDRH", 
                    value
                );
            }

            WriteRegisterUInt16(Icm20948UserBank.UserBank2, 0x50/*PRGM_START_ADDRH*/, value);
        }
    }
}
