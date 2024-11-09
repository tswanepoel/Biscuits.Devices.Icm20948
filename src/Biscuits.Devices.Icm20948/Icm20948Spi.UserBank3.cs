namespace Biscuits.Devices.Icm20948
{
    using System;
    using System.Diagnostics;
    using System.Threading;
    using Microsoft.Extensions.Logging;
    using UserBank0;
    using UserBank3;

    public partial class Icm20948Spi
    {
        private static readonly object _syncI2cSlv4 = new();

        public Icm20948I2cMstOdrConfig ReadI2cMstOdrConfig()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(Icm20948Spi));
            }

            byte valueRaw = ReadRegisterByte(Icm20948UserBank.UserBank3, 0x00/*I2C_MST_ODR_CONFIG*/);
            var i2cMstOdrConfig = (Icm20948I2cMstOdrConfig)valueRaw;
            
            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Read from User Bank 0x{UserBank:X2} Reg 0x{Address:X2} ({Name}): 0x{Data:X2} ({@Value})",
                    (byte)Icm20948UserBank.UserBank3, 
                    0x00/*I2C_MST_ODR_CONFIG*/, 
                    "I2C_MST_ODR_CONFIG", 
                    valueRaw,
                    i2cMstOdrConfig
                );
            }

            return i2cMstOdrConfig;
        }

        public void WriteI2cMstOdrConfig(Icm20948I2cMstOdrConfig i2cMstOdrConfig)
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(Icm20948Spi));
            }

            var valueRaw = (byte)i2cMstOdrConfig;
            
            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Write to User Bank 0x{UserBank:X2} Reg 0x{Address:X2} ({Name}): 0x{Data:X2} ({@Value})", 
                    (byte)Icm20948UserBank.UserBank3, 
                    0x00/*I2C_MST_ODR_CONFIG*/, 
                    "I2C_MST_ODR_CONFIG", 
                    valueRaw,
                    i2cMstOdrConfig
                );
            }

            WriteRegisterByte(Icm20948UserBank.UserBank3, 0x00/*I2C_MST_ODR_CONFIG*/, valueRaw);
        }

        public Icm20948I2cMstCtrl ReadI2cMstCtrl()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(Icm20948Spi));
            }

            byte valueRaw = ReadRegisterByte(Icm20948UserBank.UserBank3, 0x01/*I2C_MST_CTRL*/);
            var i2cMstCtrl = (Icm20948I2cMstCtrl)valueRaw;
            
            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Read from User Bank 0x{UserBank:X2} Reg 0x{Address:X2} ({Name}): 0x{Data:X2} ({@Value})",
                    (byte)Icm20948UserBank.UserBank3, 
                    0x01/*I2C_MST_CTRL*/, 
                    "I2C_MST_CTRL", 
                    valueRaw,
                    i2cMstCtrl
                );
            }

            return i2cMstCtrl;
        }

        public void WriteI2cMstCtrl(Icm20948I2cMstCtrl i2cMstCtrl)
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(Icm20948Spi));
            }

            var valueRaw = (byte)i2cMstCtrl;
            
            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Write to User Bank 0x{UserBank:X2} Reg 0x{Address:X2} ({Name}): 0x{Data:X2} ({@Value})", 
                    (byte)Icm20948UserBank.UserBank3, 
                    0x01/*I2C_MST_CTRL*/, 
                    "I2C_MST_CTRL", 
                    valueRaw,
                    i2cMstCtrl
                );
            }

            WriteRegisterByte(Icm20948UserBank.UserBank3, 0x01/*I2C_MST_CTRL*/, valueRaw);
        }

        public Icm20948I2cSlvAddr ReadI2cSlv0Addr()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(Icm20948Spi));
            }

            byte valueRaw = ReadRegisterByte(Icm20948UserBank.UserBank3, 0x03/*I2C_SLV0_ADDR*/);
            var i2cSlv0Addr = (Icm20948I2cSlvAddr)valueRaw;
            
            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Read from User Bank 0x{UserBank:X2} Reg 0x{Address:X2} ({Name}): 0x{Data:X2} ({@Value})",
                    (byte)Icm20948UserBank.UserBank3, 
                    0x03/*I2C_SLV0_ADDR*/, 
                    "I2C_SLV0_ADDR", 
                    valueRaw,
                    i2cSlv0Addr
                );
            }

            return i2cSlv0Addr;
        }

        public void WriteI2cSlv0Addr(Icm20948I2cSlvAddr i2cSlv0Addr)
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(Icm20948Spi));
            }

            var valueRaw = (byte)i2cSlv0Addr;
            
            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Write to User Bank 0x{UserBank:X2} Reg 0x{Address:X2} ({Name}): 0x{Data:X2} ({@Value})", 
                    (byte)Icm20948UserBank.UserBank3, 
                    0x03/*I2C_SLV0_ADDR*/, 
                    "I2C_SLV0_ADDR", 
                    valueRaw,
                    i2cSlv0Addr
                );
            }

            WriteRegisterByte(Icm20948UserBank.UserBank3, 0x03/*I2C_SLV0_ADDR*/, valueRaw);
        }

        public Icm20948I2cSlvReg ReadI2cSlv0Reg()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(Icm20948Spi));
            }

            byte valueRaw = ReadRegisterByte(Icm20948UserBank.UserBank3, 0x04/*I2C_SLV0_REG*/);
            var i2cSlv0Reg = (Icm20948I2cSlvReg)valueRaw;
            
            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Read from User Bank 0x{UserBank:X2} Reg 0x{Address:X2} ({Name}): 0x{Data:X2} ({@Value})",
                    (byte)Icm20948UserBank.UserBank3, 
                    0x04/*I2C_SLV0_REG*/, 
                    "I2C_SLV0_REG", 
                    valueRaw,
                    i2cSlv0Reg
                );
            }

            return i2cSlv0Reg;
        }

        public void WriteI2cSlv0Reg(Icm20948I2cSlvReg i2cSlv0Reg)
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(Icm20948Spi));
            }

            var valueRaw = (byte)i2cSlv0Reg;
            
            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Write to User Bank 0x{UserBank:X2} Reg 0x{Address:X2} ({Name}): 0x{Data:X2} ({@Value})", 
                    (byte)Icm20948UserBank.UserBank3, 
                    0x04/*I2C_SLV0_REG*/, 
                    "I2C_SLV0_REG", 
                    valueRaw,
                    i2cSlv0Reg
                );
            }

            WriteRegisterByte(Icm20948UserBank.UserBank3, 0x04/*I2C_SLV0_REG*/, valueRaw);
        }

        public Icm20948I2cSlvCtrl ReadI2cSlv0Ctrl()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(Icm20948Spi));
            }

            byte valueRaw = ReadRegisterByte(Icm20948UserBank.UserBank3, 0x05/*I2C_SLV0_CTRL*/);
            var i2cSlv0Ctrl = (Icm20948I2cSlvCtrl)valueRaw;
            
            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Read from User Bank 0x{UserBank:X2} Reg 0x{Address:X2} ({Name}): 0x{Data:X2} ({@Value})",
                    (byte)Icm20948UserBank.UserBank3, 
                    0x05/*I2C_SLV0_CTRL*/, 
                    "I2C_SLV0_CTRL", 
                    valueRaw,
                    i2cSlv0Ctrl
                );
            }

            return i2cSlv0Ctrl;
        }

        public void WriteI2cSlv0Ctrl(Icm20948I2cSlvCtrl i2cSlv0Ctrl)
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(Icm20948Spi));
            }

            var valueRaw = (byte)i2cSlv0Ctrl;
            
            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Write to User Bank 0x{UserBank:X2} Reg 0x{Address:X2} ({Name}): 0x{Data:X2} ({@Value})", 
                    (byte)Icm20948UserBank.UserBank3, 
                    0x05/*I2C_SLV0_CTRL*/, 
                    "I2C_SLV0_CTRL", 
                    valueRaw,
                    i2cSlv0Ctrl
                );
            }

            WriteRegisterByte(Icm20948UserBank.UserBank3, 0x05/*I2C_SLV0_CTRL*/, valueRaw);
        }

        public byte ReadI2cSlv0DO()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(Icm20948Spi));
            }
            
            byte value = ReadRegisterByte(Icm20948UserBank.UserBank3, 0x06/*I2C_SLV0_DO*/);

            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Read from User Bank 0x{UserBank:X2} Reg 0x{Address:X2} ({Name}): 0x{Data}", 
                    (byte)Icm20948UserBank.UserBank3, 
                    0x06/*I2C_SLV0_DO*/, 
                    "I2C_SLV0_DO", 
                    value
                );
            }

            return value;
        }

        public void WriteI2cSlv0DO(byte value)
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(Icm20948Spi));
            }

            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Write to User Bank 0x{UserBank:X2} Reg 0x{Address:X2} ({Name}): 0x{Data:X2}", 
                    (byte)Icm20948UserBank.UserBank3, 
                    0x06/*I2C_SLV0_DO*/, 
                    "I2C_SLV0_DO", 
                    value
                );
            }

            WriteRegisterByte(Icm20948UserBank.UserBank3, 0x06/*I2C_SLV0_DO*/, value);
        }

        public Icm20948I2cSlvAddr ReadI2cSlv1Addr()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(Icm20948Spi));
            }

            byte valueRaw = ReadRegisterByte(Icm20948UserBank.UserBank3, 0x07/*I2C_SLV1_ADDR*/);
            var i2cSlv1Addr = (Icm20948I2cSlvAddr)valueRaw;
            
            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Read from User Bank 0x{UserBank:X2} Reg 0x{Address:X2} ({Name}): 0x{Data:X2} ({@Value})",
                    (byte)Icm20948UserBank.UserBank3, 
                    0x07/*I2C_SLV1_ADDR*/, 
                    "I2C_SLV1_ADDR", 
                    valueRaw,
                    i2cSlv1Addr
                );
            }

            return i2cSlv1Addr;
        }

        public void WriteI2cSlv1Addr(Icm20948I2cSlvAddr i2cSlv1Addr)
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(Icm20948Spi));
            }

            var valueRaw = (byte)i2cSlv1Addr;
            
            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Write to User Bank 0x{UserBank:X2} Reg 0x{Address:X2} ({Name}): 0x{Data:X2} ({@Value})", 
                    (byte)Icm20948UserBank.UserBank3, 
                    0x07/*I2C_SLV1_ADDR*/, 
                    "I2C_SLV1_ADDR", 
                    valueRaw,
                    i2cSlv1Addr
                );
            }

            WriteRegisterByte(Icm20948UserBank.UserBank3, 0x07/*I2C_SLV1_ADDR*/, valueRaw);
        }

        public Icm20948I2cSlvReg ReadI2cSlv1Reg()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(Icm20948Spi));
            }

            byte valueRaw = ReadRegisterByte(Icm20948UserBank.UserBank3, 0x08/*I2C_SLV1_REG*/);
            var i2cSlv1Reg = (Icm20948I2cSlvReg)valueRaw;
            
            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Read from User Bank 0x{UserBank:X2} Reg 0x{Address:X2} ({Name}): 0x{Data:X2} ({@Value})",
                    (byte)Icm20948UserBank.UserBank3, 
                    0x08/*I2C_SLV1_REG*/, 
                    "I2C_SLV1_REG", 
                    valueRaw,
                    i2cSlv1Reg
                );
            }

            return i2cSlv1Reg;
        }

        public void WriteI2cSlv1Reg(Icm20948I2cSlvReg i2cSlv1Reg)
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(Icm20948Spi));
            }

            var valueRaw = (byte)i2cSlv1Reg;
            
            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Write to User Bank 0x{UserBank:X2} Reg 0x{Address:X2} ({Name}): 0x{Data:X2} ({@Value})", 
                    (byte)Icm20948UserBank.UserBank3, 
                    0x08/*I2C_SLV1_REG*/, 
                    "I2C_SLV1_REG", 
                    valueRaw,
                    i2cSlv1Reg
                );
            }

            WriteRegisterByte(Icm20948UserBank.UserBank3, 0x08/*I2C_SLV1_REG*/, valueRaw);
        }

        public Icm20948I2cSlvCtrl ReadI2cSlv1Ctrl()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(Icm20948Spi));
            }

            byte valueRaw = ReadRegisterByte(Icm20948UserBank.UserBank3, 0x09/*I2C_SLV1_CTRL*/);
            var i2cSlv1Ctrl = (Icm20948I2cSlvCtrl)valueRaw;
            
            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Read from User Bank 0x{UserBank:X2} Reg 0x{Address:X2} ({Name}): 0x{Data:X2} ({@Value})",
                    (byte)Icm20948UserBank.UserBank3, 
                    0x09/*I2C_SLV1_CTRL*/, 
                    "I2C_SLV1_CTRL", 
                    valueRaw,
                    i2cSlv1Ctrl
                );
            }

            return i2cSlv1Ctrl;
        }

        public void WriteI2cSlv1Ctrl(Icm20948I2cSlvCtrl i2cSlv1Ctrl)
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(Icm20948Spi));
            }

            var valueRaw = (byte)i2cSlv1Ctrl;
            
            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Write to User Bank 0x{UserBank:X2} Reg 0x{Address:X2} ({Name}): 0x{Data:X2} ({@Value})", 
                    (byte)Icm20948UserBank.UserBank3, 
                    0x09/*I2C_SLV1_CTRL*/, 
                    "I2C_SLV1_CTRL", 
                    valueRaw,
                    i2cSlv1Ctrl
                );
            }

            WriteRegisterByte(Icm20948UserBank.UserBank3, 0x09/*I2C_SLV1_CTRL*/, valueRaw);
        }

        public byte ReadI2cSlv1DO()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(Icm20948Spi));
            }
            
            byte value = ReadRegisterByte(Icm20948UserBank.UserBank3, 0x0A/*I2C_SLV1_DO*/);

            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Read from User Bank 0x{UserBank:X2} Reg 0x{Address:X2} ({Name}): 0x{Data}", 
                    (byte)Icm20948UserBank.UserBank3, 
                    0x0A/*I2C_SLV1_DO*/, 
                    "I2C_SLV1_DO", 
                    value
                );
            }

            return value;
        }

        public void WriteI2cSlv1DO(byte value)
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(Icm20948Spi));
            }

            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Write to User Bank 0x{UserBank:X2} Reg 0x{Address:X2} ({Name}): 0x{Data:X2}", 
                    (byte)Icm20948UserBank.UserBank3, 
                    0x0A/*I2C_SLV1_DO*/, 
                    "I2C_SLV1_DO", 
                    value
                );
            }

            WriteRegisterByte(Icm20948UserBank.UserBank3, 0x0A/*I2C_SLV1_DO*/, value);
        }

        public byte I2cSlv4ReadByte(byte i2cId, byte reg, TimeSpan? timeout = null)
        {
            var i2cSlv4Addr = new Icm20948I2cSlvAddr
            {
                I2cSlvRnw = Icm20948I2cSlvRnw.Read,
                I2cId = i2cId
            };

            var i2cSlv4Reg = new Icm20948I2cSlvReg { I2cSlvReg = reg };

            var i2cSlv4Ctrl = new Icm20948I2cSlv4Ctrl
            {
                I2cSlv4En = true,
                I2cSlv4IntEn = false,
                I2cSlv4RegDis = false,
                I2cSlv4Dly = 0
            };

            lock (_syncI2cSlv4)
            {
                WriteI2cSlv4AddrUnsafe(i2cSlv4Addr);
                WriteI2cSlv4RegUnsafe(i2cSlv4Reg);
                WriteI2cSlv4CtrlUnsafe(i2cSlv4Ctrl);
                
                Icm20948I2cMstStatus i2cMstStatus;
                var sw = Stopwatch.StartNew();

                while (true)
                {
                    i2cMstStatus = ReadI2cMstStatus();

                    if (i2cMstStatus.I2cSlv4Done)
                    {
                        break;
                    }

                    if (timeout != null && 
                        timeout != Timeout.InfiniteTimeSpan && 
                        sw.Elapsed >= timeout)
                    {
                        throw new TimeoutException();
                    }
                }

                if (i2cMstStatus.I2cSlv4Nack)
                {
                    throw new InvalidOperationException();
                }

                return ReadI2cSlv4DIUnsafe();
            }
        }

        public void I2cSlv4WriteByte(byte i2cId, byte reg, byte value, TimeSpan? timeout = null)
        {
            var i2cSlv4Addr = new Icm20948I2cSlvAddr
            {
                I2cSlvRnw = Icm20948I2cSlvRnw.Write,
                I2cId = i2cId
            };

            var i2cSlv4Reg = new Icm20948I2cSlvReg { I2cSlvReg = reg };

            var i2cSlv4Ctrl = new Icm20948I2cSlv4Ctrl
            {
                I2cSlv4En = true,
                I2cSlv4IntEn = false,
                I2cSlv4RegDis = false,
                I2cSlv4Dly = 0
            };

            lock (_syncI2cSlv4)
            {
                WriteI2cSlv4AddrUnsafe(i2cSlv4Addr);
                WriteI2cSlv4RegUnsafe(i2cSlv4Reg);
                WriteI2cSlv4DOUnsafe(value);
                WriteI2cSlv4CtrlUnsafe(i2cSlv4Ctrl);
                
                Icm20948I2cMstStatus i2cMstStatus;
                var sw = Stopwatch.StartNew();

                while (true)
                {
                    i2cMstStatus = ReadI2cMstStatus();

                    if (i2cMstStatus.I2cSlv4Done)
                    {
                        break;
                    }

                    if (timeout != null && 
                        timeout != Timeout.InfiniteTimeSpan && 
                        sw.Elapsed >= timeout)
                    {
                        throw new TimeoutException();
                    }
                }

                if (i2cMstStatus.I2cSlv4Nack)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        private Icm20948I2cSlvAddr ReadI2cSlv4AddrUnsafe()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(Icm20948Spi));
            }

            byte valueRaw = ReadRegisterByte(Icm20948UserBank.UserBank3, 0x13/*I2C_SLV4_ADDR*/);
            var i2cSlv4Addr = (Icm20948I2cSlvAddr)valueRaw;
            
            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Read from User Bank 0x{UserBank:X2} Reg 0x{Address:X2} ({Name}): 0x{Data:X2} ({@Value})",
                    (byte)Icm20948UserBank.UserBank3, 
                    0x13/*I2C_SLV4_ADDR*/, 
                    "I2C_SLV4_ADDR", 
                    valueRaw,
                    i2cSlv4Addr
                );
            }

            return i2cSlv4Addr;
        }

        private void WriteI2cSlv4AddrUnsafe(Icm20948I2cSlvAddr i2cSlv4Addr)
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(Icm20948Spi));
            }

            var valueRaw = (byte)i2cSlv4Addr;
            
            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Write to User Bank 0x{UserBank:X2} Reg 0x{Address:X2} ({Name}): 0x{Data:X2} ({@Value})", 
                    (byte)Icm20948UserBank.UserBank3, 
                    0x13/*I2C_SLV4_ADDR*/, 
                    "I2C_SLV4_ADDR", 
                    valueRaw,
                    i2cSlv4Addr
                );
            }

            WriteRegisterByte(Icm20948UserBank.UserBank3, 0x13/*I2C_SLV4_ADDR*/, valueRaw);
        }

        private Icm20948I2cSlvReg ReadI2cSlv4RegUnsafe()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(Icm20948Spi));
            }

            byte valueRaw = ReadRegisterByte(Icm20948UserBank.UserBank3, 0x14/*I2C_SLV4_REG*/);
            var i2cSlv4Reg = (Icm20948I2cSlvReg)valueRaw;
            
            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Read from User Bank 0x{UserBank:X2} Reg 0x{Address:X2} ({Name}): 0x{Data:X2} ({@Value})",
                    (byte)Icm20948UserBank.UserBank3, 
                    0x14/*I2C_SLV4_REG*/, 
                    "I2C_SLV4_REG", 
                    valueRaw,
                    i2cSlv4Reg
                );
            }

            return i2cSlv4Reg;
        }

        private void WriteI2cSlv4RegUnsafe(Icm20948I2cSlvReg i2cSlv4Reg)
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(Icm20948Spi));
            }

            var valueRaw = (byte)i2cSlv4Reg;
            
            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Write to User Bank 0x{UserBank:X2} Reg 0x{Address:X2} ({Name}): 0x{Data:X2} ({@Value})", 
                    (byte)Icm20948UserBank.UserBank3, 
                    0x14/*I2C_SLV4_REG*/, 
                    "I2C_SLV4_REG", 
                    valueRaw,
                    i2cSlv4Reg
                );
            }

            WriteRegisterByte(Icm20948UserBank.UserBank3, 0x14/*I2C_SLV4_REG*/, valueRaw);
        }

        private Icm20948I2cSlv4Ctrl ReadI2cSlv4CtrlUnsafe()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(Icm20948Spi));
            }

            byte valueRaw = ReadRegisterByte(Icm20948UserBank.UserBank3, 0x15/*I2C_SLV4_CTRL*/);
            var i2cSlv4Ctrl = (Icm20948I2cSlv4Ctrl)valueRaw;
            
            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Read from User Bank 0x{UserBank:X2} Reg 0x{Address:X2} ({Name}): 0x{Data:X2} ({@Value})",
                    (byte)Icm20948UserBank.UserBank3, 
                    0x15/*I2C_SLV4_CTRL*/, 
                    "I2C_SLV4_CTRL", 
                    valueRaw,
                    i2cSlv4Ctrl
                );
            }

            return i2cSlv4Ctrl;
        }

        private void WriteI2cSlv4CtrlUnsafe(Icm20948I2cSlv4Ctrl i2cSlv4Ctrl)
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(Icm20948Spi));
            }

            var valueRaw = (byte)i2cSlv4Ctrl;
            
            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Write to User Bank 0x{UserBank:X2} Reg 0x{Address:X2} ({Name}): 0x{Data:X2} ({@Value})", 
                    (byte)Icm20948UserBank.UserBank3, 
                    0x15/*I2C_SLV4_CTRL*/, 
                    "I2C_SLV4_CTRL", 
                    valueRaw,
                    i2cSlv4Ctrl
                );
            }

            WriteRegisterByte(Icm20948UserBank.UserBank3, 0x15/*I2C_SLV4_CTRL*/, valueRaw);
        }

        private byte ReadI2cSlv4DOUnsafe()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(Icm20948Spi));
            }
            
            byte value = ReadRegisterByte(Icm20948UserBank.UserBank3, 0x16/*I2C_SLV4_DO*/);

            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Read from User Bank 0x{UserBank:X2} Reg 0x{Address:X2} ({Name}): 0x{Data:X2}", 
                    (byte)Icm20948UserBank.UserBank3, 
                    0x16/*I2C_SLV4_DO*/, 
                    "I2C_SLV4_DO", 
                    value
                );
            }

            return value;
        }

        private void WriteI2cSlv4DOUnsafe(byte value)
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(Icm20948Spi));
            }

            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Write to User Bank 0x{UserBank:X2} Reg 0x{Address:X2} ({Name}): 0x{Data:X2}", 
                    (byte)Icm20948UserBank.UserBank3, 
                    0x16/*I2C_SLV4_DO*/, 
                    "I2C_SLV4_DO", 
                    value
                );
            }

            WriteRegisterByte(Icm20948UserBank.UserBank3, 0x16/*I2C_SLV4_DO*/, value);
        }

        private byte ReadI2cSlv4DIUnsafe()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(Icm20948Spi));
            }
            
            byte value = ReadRegisterByte(Icm20948UserBank.UserBank3, 0x17/*I2C_SLV4_DI*/);

            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Read from User Bank 0x{UserBank:X2} Reg 0x{Address:X2} ({Name}): 0x{Data:X2}", 
                    (byte)Icm20948UserBank.UserBank3, 
                    0x17/*I2C_SLV4_DI*/, 
                    "I2C_SLV4_DI", 
                    value
                );
            }

            return value;
        }
    }
}