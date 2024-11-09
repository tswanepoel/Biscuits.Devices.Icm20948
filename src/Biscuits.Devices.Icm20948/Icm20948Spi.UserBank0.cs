namespace Biscuits.Devices.Icm20948
{
    using System;
    using Microsoft.Extensions.Logging;
    using UserBank0;

    public partial class Icm20948Spi
    {
        private readonly object _syncMems = new();

        public byte ReadWhoAmI()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(Icm20948Spi));
            }

            byte value = ReadRegisterByte(Icm20948UserBank.UserBank0, 0x00/*WHO_AM_I*/);

            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Read from User Bank 0x{UserBank:X2} Reg 0x{Address:X2} ({Name}): 0x{Data:X2}", 
                    (byte)Icm20948UserBank.UserBank0,
                    0x00/*WHO_AM_I*/, 
                    "WHO_AM_I", 
                    value
                );
            }

            return value;
        }

        public Icm20948UserCtrl ReadUserCtrl()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(Icm20948Spi));
            }

            byte valueRaw = ReadRegisterByte((byte)Icm20948UserBank.UserBank0, 0x03/*USER_CTRL*/);
            var userCtrl = (Icm20948UserCtrl)valueRaw;
            
            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Read from User Bank 0x{UserBank:X2} Reg 0x{Address:X2} ({Name}): 0x{Data:X2} ({@Value})",
                    (byte)Icm20948UserBank.UserBank0, 
                    0x03/*USER_CTRL*/, 
                    "USER_CTRL", 
                    valueRaw,
                    userCtrl
                );
            }

            return userCtrl;
        }

        public void WriteUserCtrl(Icm20948UserCtrl userCtrl)
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(Icm20948Spi));
            }

            var valueRaw = (byte)userCtrl;
            
            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Write to User Bank 0x{UserBank:X2} Reg 0x{Address:X2} ({Name}): 0x{Data:X2} ({@Value})", 
                    (byte)Icm20948UserBank.UserBank0, 
                    0x03/*USER_CTRL*/, 
                    "USER_CTRL", 
                    valueRaw,
                    userCtrl
                );
            }

            WriteRegisterByte(Icm20948UserBank.UserBank0, 0x03/*USER_CTRL*/, valueRaw);
        }

        public Icm20948LPConfig ReadLPConfig()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(Icm20948Spi));
            }

            byte valueRaw = ReadRegisterByte(Icm20948UserBank.UserBank0, 0x05/*LP_CONFIG*/);
            var value = (Icm20948LPConfig)valueRaw;
           
            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Read from User Bank 0x{UserBank:X2} Reg 0x{Address:X2} ({Name}): 0x{Data:X2} ({@Value})", 
                    (byte)Icm20948UserBank.UserBank0, 
                    0x05/*LP_CONFIG*/, 
                    "LP_CONFIG", 
                    valueRaw,
                    value
                );
            }

            return value;
        }

        public void WriteLPConfig(Icm20948LPConfig lpConfig)
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(Icm20948Spi));
            }

            var valueRaw = (byte)lpConfig;
            
            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Write to User Bank 0x{UserBank:X2} Reg 0x{Address:X2} ({Name}): 0x{Data:X2} ({@Value})", 
                    (byte)Icm20948UserBank.UserBank0, 
                    0x05/*LP_CONFIG*/, 
                    "LP_CONFIG", 
                    valueRaw,
                    lpConfig
                );
            }

            WriteRegisterByte(Icm20948UserBank.UserBank0, 0x05/*LP_CONFIG*/, valueRaw);
        }

        public Icm20948PwrMgmt1 ReadPwrMgmt1()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(Icm20948Spi));
            }

            byte valueRaw = ReadRegisterByte(Icm20948UserBank.UserBank0, 0x06/*PWR_MGMT_1*/);
            var pwrMgmt1 = (Icm20948PwrMgmt1)valueRaw;
            
            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Read from User Bank 0x{UserBank:X2} Reg 0x{Address:X2} ({Name}): 0x{Data:X2} ({@Value})", 
                    (byte)Icm20948UserBank.UserBank0, 
                    0x06/*PWR_MGMT_1*/, 
                    "PWR_MGMT_1", 
                    valueRaw,
                    pwrMgmt1
                );
            }

            return pwrMgmt1;
        }

        public void WritePwrMgmt1(Icm20948PwrMgmt1 pwrMgmt1)
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(Icm20948Spi));
            }

            var value = (byte)pwrMgmt1;
            
            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Write to User Bank 0x{UserBank:X2} Reg 0x{Address:X2} ({Name}): 0x{Data:X2} ({@Value})", 
                    (byte)Icm20948UserBank.UserBank0, 
                    0x06/*PWR_MGMT_1*/, 
                    "PWR_MGMT_1", 
                    value,
                    pwrMgmt1
                );
            }

            WriteRegisterByte(Icm20948UserBank.UserBank0, 0x06/*PWR_MGMT_1*/, value);
        }

        public Icm20948PwrMgmt2 ReadPwrMgmt2()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(Icm20948Spi));
            }

            byte valueRaw = ReadRegisterByte(Icm20948UserBank.UserBank0, 0x07/*PWR_MGMT_2*/);
            var pwrMgmt2 = (Icm20948PwrMgmt2)valueRaw;
            
            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Read from User Bank 0x{UserBank:X2} Reg 0x{Address:X2} ({Name}): 0x{Data:X2} ({@Value})", 
                    (byte)Icm20948UserBank.UserBank0, 
                    0x07/*PWR_MGMT_2*/, 
                    "PWR_MGMT_2", 
                    valueRaw,
                    pwrMgmt2
                );
            }

            return pwrMgmt2;
        }

        public void WritePwrMgmt2(Icm20948PwrMgmt2 pwrMgmt2)
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(Icm20948Spi));
            }

            var valueRaw = (byte)pwrMgmt2;
            
            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Write to User Bank 0x{UserBank:X2} Reg 0x{Address:X2} ({Name}): 0x{Data:X2} ({@Value})", 
                    (byte)Icm20948UserBank.UserBank0, 
                    0x07/*PWR_MGMT_2*/, 
                    "PWR_MGMT_2", 
                    valueRaw,
                    pwrMgmt2
                );
            }

            WriteRegisterByte(Icm20948UserBank.UserBank0, 0x07/*PWR_MGMT_2*/, valueRaw);
        }

        public Icm20948IntPinCfg ReadIntPinCfg()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(Icm20948Spi));
            }

            byte valueRaw = ReadRegisterByte(Icm20948UserBank.UserBank0, 0x0F/*INT_PIN_CFG*/);
            var intPinCfg = (Icm20948IntPinCfg)valueRaw;
            
            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Read from User Bank 0x{UserBank:X2} Reg 0x{Address:X2} ({Name}): 0x{Data:X2} ({@Value})", 
                    (byte)Icm20948UserBank.UserBank0, 
                    0x0F/*INT_PIN_CFG*/, 
                    "INT_PIN_CFG", 
                    valueRaw,
                    intPinCfg
                );
            }

            return intPinCfg;
        }

        public void WriteIntPinCfg(Icm20948IntPinCfg intPinCfg)
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(Icm20948Spi));
            }

            var valueRaw = (byte)intPinCfg;
            
            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Write to User Bank 0x{UserBank:X2} Reg 0x{Address:X2} ({Name}): 0x{Data:X2} ({@Value})", 
                    (byte)Icm20948UserBank.UserBank0, 
                    0x0F/*INT_PIN_CFG*/, 
                    "INT_PIN_CFG", 
                    valueRaw,
                    intPinCfg
                );
            }

            WriteRegisterByte(Icm20948UserBank.UserBank0, 0x0F/*INT_PIN_CFG*/, valueRaw);
        }

        public Icm20948IntEnable ReadIntEnable()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(Icm20948Spi));
            }

            byte valueRaw = ReadRegisterByte(Icm20948UserBank.UserBank0, 0x10/*INT_ENABLE*/);
            var intEnable = (Icm20948IntEnable)valueRaw;

            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Read from User Bank 0x{UserBank:X2} Reg 0x{Address:X2} ({Name}): 0x{Data:X2} ({@Value})", 
                    (byte)Icm20948UserBank.UserBank0, 
                    0x10/*INT_ENABLE*/, 
                    "INT_ENABLE", 
                    valueRaw,
                    intEnable
                );
            }

            return intEnable;
        }

        public void WriteIntEnable(Icm20948IntEnable intEnable)
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(Icm20948Spi));
            }

            var valueRaw = (byte)intEnable;
            
            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Write to User Bank 0x{UserBank:X2} Reg 0x{Address:X2} ({Name}): 0x{Data:X2} ({@Value})", 
                    (byte)Icm20948UserBank.UserBank0, 
                    0x10/*INT_ENABLE*/, 
                    "INT_ENABLE", 
                    valueRaw,
                    intEnable
                );
            }

            WriteRegisterByte(Icm20948UserBank.UserBank0, 0x10/*INT_ENABLE*/, valueRaw);
        }

        public Icm20948IntEnable1 ReadIntEnable1()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(Icm20948Spi));
            }

            byte valueRaw = ReadRegisterByte(Icm20948UserBank.UserBank0, 0x11/*INT_ENABLE_1*/);
            var intEnable1 = (Icm20948IntEnable1)valueRaw;
            
            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Read from User Bank 0x{UserBank:X2} Reg 0x{Address:X2} ({Name}): 0x{Data:X2} ({@Value})", 
                    (byte)Icm20948UserBank.UserBank0, 
                    0x11/*INT_ENABLE_1*/, 
                    "INT_ENABLE_1", 
                    valueRaw,
                    intEnable1
                );
            }

            return intEnable1;
        }

        public void WriteIntEnable1(Icm20948IntEnable1 intEnable1)
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(Icm20948Spi));
            }

            var valueRaw = (byte)intEnable1;

            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Write to User Bank 0x{UserBank:X2} Reg 0x{Address:X2} ({Name}): 0x{Data:X2} ({@Value})", 
                    (byte)Icm20948UserBank.UserBank0, 
                    0x11/*INT_ENABLE_1*/, 
                    "INT_ENABLE_1", 
                    valueRaw,
                    intEnable1
                );
            }

            WriteRegisterByte(Icm20948UserBank.UserBank0, 0x11/*INT_ENABLE_1*/, valueRaw);
        }

        public Icm20948IntEnable2 ReadIntEnable2()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(Icm20948Spi));
            }

            byte value = ReadRegisterByte(Icm20948UserBank.UserBank0, 0x12/*INT_ENABLE_2*/);
            
            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Read from User Bank 0x{UserBank:X2} Reg 0x{Address:X2} ({Name}): 0x{Data:X2}", 
                    (byte)Icm20948UserBank.UserBank0, 
                    0x12/*INT_ENABLE_2*/, 
                    "INT_ENABLE_2", 
                    value
                );
            }

            return (Icm20948IntEnable2)value;
        }

        public void WriteIntEnable2(Icm20948IntEnable2 intEnable2)
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(Icm20948Spi));
            }

            var valueRaw = (byte)intEnable2;

            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Write to User Bank 0x{UserBank:X2} Reg 0x{Address:X2} ({Name}): 0x{Data:X2} ({@Value})", 
                    (byte)Icm20948UserBank.UserBank0, 
                    0x12/*INT_ENABLE_2*/, 
                    "INT_ENABLE_2", 
                    valueRaw,
                    intEnable2
                );
            }

            WriteRegisterByte(Icm20948UserBank.UserBank0, 0x12/*INT_ENABLE_2*/, valueRaw);
        }

        public Icm20948I2cMstStatus ReadI2cMstStatus()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(Icm20948Spi));
            }

            byte valueRaw = ReadRegisterByte(Icm20948UserBank.UserBank0, 0x17/*I2C_MST_STATUS*/);
            var i2cMstStatus = (Icm20948I2cMstStatus)valueRaw;
            
            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Read from User Bank 0x{UserBank:X2} Reg 0x{Address:X2} ({Name}): 0x{Data:X2} ({@Value})",
                    (byte)Icm20948UserBank.UserBank0, 
                    0x17/*I2C_MST_STATUS*/, 
                    "I2C_MST_STATUS", 
                    valueRaw,
                    i2cMstStatus
                );
            }

            return i2cMstStatus;
        }

        public Icm20948DmpIntStatus ReadDmpIntStatus()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(Icm20948Spi));
            }

            byte valueRaw = ReadRegisterByte(Icm20948UserBank.UserBank0, 0x18/*DMP_INT_STATUS*/);
            var dmpIntStatus = (Icm20948DmpIntStatus)valueRaw;

            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Read from User Bank 0x{UserBank:X2} Reg 0x{Address:X2} ({Name}): 0x{Data:X2} ({@Value})", 
                    (byte)Icm20948UserBank.UserBank0, 
                    0x18/*DMP_INT_STATUS*/, 
                    "DMP_INT_STATUS", 
                    valueRaw,
                    dmpIntStatus
                );
            }

            return dmpIntStatus;
        }

        public Icm20948IntStatus ReadIntStatus()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(Icm20948Spi));
            }

            byte valueRaw = ReadRegisterByte(Icm20948UserBank.UserBank0, 0x19/*INT_STATUS*/);
            var intStatus = (Icm20948IntStatus)valueRaw;
            
            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Read from User Bank 0x{UserBank:X2} Reg 0x{Address:X2} ({Name}): 0x{Data:X2} ({@Value})", 
                    (byte)Icm20948UserBank.UserBank0, 
                    0x19/*INT_STATUS*/, 
                    "INT_STATUS", 
                    valueRaw,
                    intStatus
                );
            }

            return intStatus;
        }

        public Icm20948FifoEn1 ReadFifoEn1()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(Icm20948Spi));
            }

            byte valueRaw = ReadRegisterByte(Icm20948UserBank.UserBank0, 0x66/*FIFO_EN_1*/);
            var fifoEn1 = (Icm20948FifoEn1)valueRaw;
            
            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Read from User Bank 0x{UserBank:X2} Reg 0x{Address:X2} ({Name}): 0x{Data:X2} ({@Value})", 
                    (byte)Icm20948UserBank.UserBank0, 
                    0x66/*FIFO_EN_1*/, 
                    "FIFO_EN_1", 
                    valueRaw,
                    fifoEn1
                );
            }

            return fifoEn1;
        }

        public void WriteFifoEn1(Icm20948FifoEn1 fifoEn1)
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(Icm20948Spi));
            }

            var valueRaw = (byte)fifoEn1;

            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Write to User Bank 0x{UserBank:X2} Reg 0x{Address:X2} ({Name}): 0x{Data:X2} ({@Value})", 
                    (byte)Icm20948UserBank.UserBank0, 
                    0x66/*FIFO_EN_1*/, 
                    "FIFO_EN_1", 
                    valueRaw,
                    fifoEn1
                );
            }

            WriteRegisterByte(Icm20948UserBank.UserBank0, 0x66/*FIFO_EN_1*/, valueRaw);
        }

        public Icm20948FifoEn2 ReadFifoEn2()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(Icm20948Spi));
            }

            byte valueRaw = ReadRegisterByte(Icm20948UserBank.UserBank0, 0x67/*FIFO_EN_2*/);
            var fifoEn2 = (Icm20948FifoEn2)valueRaw;
            
            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Read from User Bank 0x{UserBank:X2} Reg 0x{Address:X2} ({Name}): 0x{Data:X2} ({@Value})", 
                    (byte)Icm20948UserBank.UserBank0, 
                    0x67/*FIFO_EN_2*/, 
                    "FIFO_EN_2", 
                    valueRaw,
                    fifoEn2
                );
            }

            return fifoEn2;
        }

        public void WriteFifoEn2(Icm20948FifoEn2 fifoEn2)
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(Icm20948Spi));
            }

            var valueRaw = (byte)fifoEn2;

            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Write to User Bank 0x{UserBank:X2} Reg 0x{Address:X2} ({Name}): 0x{Data:X2} ({@Value})", 
                    (byte)Icm20948UserBank.UserBank0, 
                    0x67/*FIFO_EN_2*/, 
                    "FIFO_EN_2", 
                    valueRaw,
                    fifoEn2
                );
            }

            WriteRegisterByte(Icm20948UserBank.UserBank0, 0x67/*FIFO_EN_2*/, valueRaw);
        }

        public Icm20948FifoRst ReadFifoRst()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(Icm20948Spi));
            }

            byte valueRaw = ReadRegisterByte(Icm20948UserBank.UserBank0, 0x68/*FIFO_RST*/);
            var fifoRst = (Icm20948FifoRst)valueRaw;
            
            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Read from User Bank 0x{UserBank:X2} Reg 0x{Address:X2} ({Name}): 0x{Data:X2} ({@Value})", 
                    (byte)Icm20948UserBank.UserBank0, 
                    0x68/*FIFO_RST*/, 
                    "FIFO_RST", 
                    valueRaw,
                    fifoRst
                );
            }

            return fifoRst;
        }

        public void WriteFifoRst(Icm20948FifoRst fifoRst)
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(Icm20948Spi));
            }

            var valueRaw = (byte)fifoRst;

            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Write to User Bank 0x{UserBank:X2} Reg 0x{Address:X2} ({Name}): 0x{Data:X2} ({@Value})", 
                    (byte)Icm20948UserBank.UserBank0, 
                    0x68/*FIFO_RST*/, 
                    "FIFO_RST", 
                    valueRaw,
                    fifoRst
                );
            }

            WriteRegisterByte(Icm20948UserBank.UserBank0, 0x68/*FIFO_RST*/, valueRaw);
        }

        public Icm20948FifoModeSel ReadFifoMode()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(Icm20948Spi));
            }

            byte valueRaw = ReadRegisterByte(Icm20948UserBank.UserBank0, 0x69/*FIFO_MODE*/);
            var fifoMode = (Icm20948FifoModeSel)valueRaw;
            
            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Read from User Bank 0x{UserBank:X2} Reg 0x{Address:X2} ({Name}): 0x{Data:X2} ({@Value})", 
                    (byte)Icm20948UserBank.UserBank0, 
                    0x69/*FIFO_MODE*/, 
                    "FIFO_MODE", 
                    valueRaw,
                    fifoMode
                );
            }

            return fifoMode;
        }

        public void WriteFifoMode(Icm20948FifoModeSel fifoMode)
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(Icm20948Spi));
            }

            var valueRaw = (byte)fifoMode;

            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Write to User Bank 0x{UserBank:X2} Reg 0x{Address:X2} ({Name}): 0x{Data:X2} ({@Value})", 
                    (byte)Icm20948UserBank.UserBank0, 
                    0x69/*FIFO_MODE*/, 
                    "FIFO_MODE", 
                    valueRaw,
                    fifoMode
                );
            }

            WriteRegisterByte(Icm20948UserBank.UserBank0, 0x69/*FIFO_MODE*/, valueRaw);
        }

        public ushort ReadFifoCnt()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(Icm20948Spi));
            }

            ushort value = ReadRegisterUInt16(Icm20948UserBank.UserBank0, 0x70/*FIFO_COUNTH*/);
            
            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Read from User Bank 0x{UserBank:X2} Reg 0x{Address:X2} ({Name}): {Value}", 
                    (byte)Icm20948UserBank.UserBank0, 
                    0x70/*FIFO_COUNTH*/, 
                    "FIFO_COUNTH", 
                    value
                );
            }

            return (ushort)(value & 0x1FFF);
        }

        public void ReadFifoRW(Span<byte> buffer)
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(Icm20948Spi));
            }

            ReadRegister(Icm20948UserBank.UserBank0, 0x72/*FIFO_R_W*/, buffer);

            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Read from User Bank 0x{UserBank:X2} Reg 0x{Address:X2} ({Name}): 0x{Data}", 
                    (byte)Icm20948UserBank.UserBank0, 
                    0x72/*FIFO_R_W*/, 
                    "FIFO_R_W", 
                    buffer.ToArray()
                );
            }
        }

        public Icm20948FifoCfgSel ReadFifoCfg()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(Icm20948Spi));
            }

            byte valueRaw = ReadRegisterByte(Icm20948UserBank.UserBank0, 0x76/*FIFO_CFG*/);
            var fifoCfg = (Icm20948FifoCfgSel)valueRaw;
            
            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Read from User Bank 0x{UserBank:X2} Reg 0x{Address:X2} ({Name}): 0x{Data:X2} ({@Value})", 
                    (byte)Icm20948UserBank.UserBank0, 
                    0x76/*FIFO_CFG*/, 
                    "FIFO_CFG", 
                    valueRaw,
                    fifoCfg
                );
            }

            return fifoCfg;
        }

        public void WriteFifoCfg(Icm20948FifoCfgSel fifoCfg)
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(Icm20948Spi));
            }

            var valueRaw = (byte)fifoCfg;

            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Write to User Bank 0x{UserBank:X2} Reg 0x{Address:X2} ({Name}): 0x{Data:X2} ({@Value})", 
                    (byte)Icm20948UserBank.UserBank0, 
                    0x76/*FIFO_CFG*/, 
                    "FIFO_CFG", 
                    valueRaw,
                    fifoCfg
                );
            }

            WriteRegisterByte(Icm20948UserBank.UserBank0, 0x76/*FIFO_CFG*/, valueRaw);
        }

        public void GetMems(byte memBank, byte memStartAddr, Span<byte> buffer)
        {
            lock (_syncMems)
            {
                WriteMemBankSel(memBank);
                WriteMemStartAddr(memStartAddr);
                ReadMemRW(buffer);
            }
        }

        public void SetMemsInt32(byte memBank, byte memStartAddr, int value)
        {
            byte[] buffer = BitConverter.GetBytes(value);

            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(buffer);
            }

            SetMems(memBank, memStartAddr, buffer);
        }

        public void SetMemsUInt16(byte memBank, byte memStartAddr, ushort value)
        {
            Span<byte> buffer = [(byte)((value >> 8) & 0xFF), (byte)(value & 0xFF)];
            SetMems(memBank, memStartAddr, buffer);
        }

        public void SetMemsUInt32(byte memBank, byte memStartAddr, uint value)
        {
            Span<byte> buffer = [
                (byte)((value >> 24) & 0xFF),
                (byte)((value >> 16) & 0xFF),
                (byte)((value >> 8) & 0xFF),
                (byte)(value & 0xFF)
            ];
            
            SetMems(memBank, memStartAddr, buffer);
        }

        public void SetMems(byte memBank, byte memStartAddr, ReadOnlySpan<byte> buffer)
        {
            lock (_syncMems)
            {
                WriteMemBankSel(memBank);
                WriteMemStartAddr(memStartAddr);
                WriteMemRW(buffer);
            }
        }

        public void WriteMemBankSel(byte value)
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(Icm20948Spi));
            }

            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Write to User Bank 0x{UserBank:X2} Reg 0x{Address:X2} ({Name}): 0x{Data:X2}", 
                    (byte)Icm20948UserBank.UserBank0, 
                    0x7E/*MEM_BANK_SEL*/, 
                    "MEM_BANK_SEL", 
                    value
                );
            }

            WriteRegisterByte(Icm20948UserBank.UserBank0, 0x7E/*MEM_BANK_SEL*/, value);
        }

        public void WriteMemStartAddr(byte value)
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(Icm20948Spi));
            }

            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Write to User Bank 0x{UserBank:X2} Reg 0x{Address:X2} ({Name}): 0x{Data:X2}", 
                    (byte)Icm20948UserBank.UserBank0, 
                    0x7C/*MEM_START_ADDR*/, 
                    "MEM_START_ADDR", 
                    value
                );
            }

            WriteRegisterByte(Icm20948UserBank.UserBank0, 0x7C/*MEM_START_ADDR*/, value);
        }

        public void ReadMemRW(Span<byte> buffer)
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(Icm20948Spi));
            }
            
            ReadRegister(Icm20948UserBank.UserBank0, 0x7D/*MEM_R_W*/, buffer);

            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Read from User Bank 0x{UserBank:X2} Reg 0x{Address:X2} ({Name}): 0x{Data}", 
                    (byte)Icm20948UserBank.UserBank0, 
                    0x7D/*MEM_R_W*/, 
                    "MEM_R_W", 
                    buffer.ToArray()
                );
            }
        }

        public void WriteMemRW(ReadOnlySpan<byte> buffer)
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(Icm20948Spi));
            }

            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Write to User Bank 0x{UserBank:X2} Reg 0x{Address:X2} ({Name}): 0x{Data}", 
                    (byte)Icm20948UserBank.UserBank0, 
                    0x7D/*MEM_R_W*/, 
                    "MEM_R_W", 
                    buffer.ToArray()
                );
            }
            
            WriteRegister(Icm20948UserBank.UserBank0, 0x7D/*MEM_R_W*/, buffer);
        }
    }
}
