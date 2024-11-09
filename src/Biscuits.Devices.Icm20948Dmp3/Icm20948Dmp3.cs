namespace Biscuits.Devices.Icm20948
{
    using System;
    using System.Numerics;
    using Microsoft.Extensions.Logging;
    using Microsoft.Extensions.Logging.Abstractions;
    using UserBank2;

    public class Icm20948Dmp3
    {
        private readonly Icm20948Spi _icm20948;
        private readonly ILogger<Icm20948Dmp3> _logger;

        public Icm20948Dmp3(Icm20948Spi icm20948, ILogger<Icm20948Dmp3>? logger = null)
        {
            _icm20948 = icm20948;
            _logger = logger ?? NullLogger<Icm20948Dmp3>.Instance;
        }

        public void SetDataOutCtl1(Icm20948Dmp3DataOutCtl1 dataOutCtl1)
        {
            var valueRaw = (ushort)dataOutCtl1;

            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Set Mem Bank 0x{MemBank:X2} Mem Start Addr 0x{MemStartAddress:X2} ({Name}): 0x{Data:X4} ({@Value})", 
                    0x00,
                    0x40/*DATA_OUT_CTL1*/,
                    "DATA_OUT_CTL1",
                    valueRaw,
                    dataOutCtl1
                );
            }

            _icm20948.SetMemsUInt16(0x00, 0x40/*DATA_OUT_CTL1*/, valueRaw);
        }

        public void SetDataOutCtl2(Icm20948Dmp3DataOutCtl2 dataOutCtl2)
        {
            var valueRaw = (ushort)dataOutCtl2;

            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Set Mem Bank 0x{MemBank:X2} Mem Start Addr 0x{MemStartAddress:X2} ({Name}): 0x{Data:X4} ({@Value})", 
                    0x00,
                    0x42/*DATA_OUT_CTL2*/,
                    "DATA_OUT_CTL2",
                    valueRaw,
                    dataOutCtl2
                );
            }

            _icm20948.SetMemsUInt16(0x00, 0x42/*DATA_OUT_CTL2*/, valueRaw);
        }

        public void SetDataIntrCtl(Icm20948Dmp3DataIntrCtl dataIntrCtl)
        {
            var valueRaw = (ushort)dataIntrCtl;

            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Set Mem Bank 0x{MemBank:X2} Mem Start Addr 0x{MemStartAddress:X2} ({Name}): 0x{Data:X4} ({@Value})", 
                    0x00,
                    0x4C/*DATA_INTR_CTL*/,
                    "DATA_INTR_CTL",
                    valueRaw,
                    dataIntrCtl
                );
            }

            _icm20948.SetMemsUInt16(0x00, 0x4C/*DATA_INTR_CTL*/, valueRaw);
        }

        public void SetMotionEventCtl(Icm20948Dmp3MotionEventCtl motionEventCtl)
        {
            var valueRaw = (ushort)motionEventCtl;

            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Set Mem Bank 0x{MemBank:X2} Mem Start Addr 0x{MemStartAddress:X2} ({Name}): 0x{Data:X4} ({@Value})", 
                    0x00,
                    0x4E/*MOTION_EVENT_CTL*/,
                    "MOTION_EVENT_CTL",
                    valueRaw,
                    motionEventCtl
                );
            }

            _icm20948.SetMemsUInt16(0x00, 0x4E/*MOTION_EVENT_CTL*/, valueRaw);
        }

        public void SetDataRdyStatus(Icm20948Dmp3DataRdyStatus dataRdyStatus)
        {
            var valueRaw = (ushort)dataRdyStatus;

            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Set Mem Bank 0x{MemBank:X2} Mem Start Addr 0x{MemStartAddress:X2} ({Name}): 0x{Data:X4} ({@Value})", 
                    0x00,
                    0x8A/*DATA_RDY_STATUS*/,
                    "DATA_RDY_STATUS",
                    valueRaw,
                    dataRdyStatus
                );
            }

            _icm20948.SetMemsUInt16(0x00, 0x8A/*DATA_RDY_STATUS*/, valueRaw);
        }

        public void SetOdrQuat9(ushort divider)
        {
            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Set Mem Bank 0x{MemBank:X2} Mem Start Addr 0x{MemStartAddress:X2} ({Name}): {Value}", 
                    0x00,
                    0xA8/*ODR_QUAT9*/,
                    "ODR_QUAT9",
                    divider
                );
            }

            _icm20948.SetMemsUInt16(0x00, 0xA8/*ODR_QUAT9*/, divider);
        }

        public void SetOdrQuat6(ushort divider)
        {
            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Set Mem Bank 0x{MemBank:X2} Mem Start Addr 0x{MemStartAddress:X2} ({Name}): {Value}", 
                    0x00,
                    0xAC/*ODR_QUAT6*/,
                    "ODR_QUAT6",
                    divider
                );
            }

            _icm20948.SetMemsUInt16(0x00, 0xAC/*ODR_QUAT6*/, divider);
        }

        public void SetAccelOnlyGain(ushort hwSmplRtDiv)
        {
            uint value = hwSmplRtDiv switch
            {
                5/*1125Hz / 5 = 225Hz*/ => 15_252_014u,
                10/*1125Hz / 10 = 112Hz*/ => 30_504_029u,
                11/*1125Hz / 11 = 102Hz*/ => 33_554_432u,
                22/*1125Hz / 22 = 51Hz*/ => 67_108_864u,
                _ => 15_252_014u
            };

            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Set Mem Bank 0x{MemBank:X2} Mem Start Addr 0x{MemStartAddress:X2} ({Name}): {Value}", 
                    0x01,
                    0x0C/*ACCEL_ONLY_GAIN*/,
                    "ACCEL_ONLY_GAIN",
                    value
                );
            }

            _icm20948.SetMemsUInt32(0x01, 0x0C/*ACCEL_ONLY_GAIN*/, value);
        }

        public void SetGyroSF(byte gyroSmplRtDiv, float timebaseCorrectionPll)
        {
            const double magicConstant = 264_446_880_937_391f;
            const double magicConstantScale = 100_000f;
            const int gyroLevel = 4;

            double valueDouble = magicConstant / magicConstantScale / 1_270d * (1 << gyroLevel) * (1 + gyroSmplRtDiv) / (1f + timebaseCorrectionPll);
            var value = (uint)Math.Min(valueDouble, int.MaxValue);

            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Set Mem Bank 0x{MemBank:X2} Mem Start Addr 0x{MemStartAddress:X2} ({Name}): {Value}", 
                    0x01,
                    0x30/*GYRO_SF*/,
                    "GYRO_SF",
                    value
                );
            }

            _icm20948.SetMemsUInt32(0x01, 0x30/*GYRO_SF*/, value);
        }

        public void SetCpassMtx(Vector3 row1, Vector3 row2, Vector3 row3)
        {
            const float firmware1uT = 1u << 30;
            const float compass1uT = 32_752f / 4_912f;
            const float multiplier = firmware1uT / compass1uT;
            Vector3 row1Converted = row1 * multiplier;
            Vector3 row2Converted = row2 * multiplier;
            Vector3 row3Converted = row3 * multiplier;

            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Set Mem Bank 0x{MemBank:X2} Mem Start Addr 0x{MemStartAddress:X2} ({Name}): {Value}", 
                    0x01,
                    0x70/*CPASS_MTX_00*/,
                    "CPASS_MTX_00",
                    (int)row1Converted.X
                );
            }

            _icm20948.SetMemsInt32(0x01, 0x70/*CPASS_MTX_00*/, (int)row1Converted.X);

            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Set Mem Bank 0x{MemBank:X2} Mem Start Addr 0x{MemStartAddress:X2} ({Name}): {Value}", 
                    0x01,
                    0x74/*CPASS_MTX_01*/,
                    "CPASS_MTX_01",
                    (int)row1Converted.Y
                );
            }

            _icm20948.SetMemsInt32(0x01, 0x74/*CPASS_MTX_01*/, (int)row1Converted.Y);

            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Set Mem Bank 0x{MemBank:X2} Mem Start Addr 0x{MemStartAddress:X2} ({Name}): {Value}", 
                    0x01,
                    0x78/*CPASS_MTX_02*/,
                    "CPASS_MTX_02",
                    (int)row1Converted.Y
                );
            }

            _icm20948.SetMemsInt32(0x01, 0x78/*CPASS_MTX_02*/, (int)row1Converted.Z);

            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Set Mem Bank 0x{MemBank:X2} Mem Start Addr 0x{MemStartAddress:X2} ({Name}): {Value}", 
                    0x01,
                    0x7C/*CPASS_MTX_10*/,
                    "CPASS_MTX_10",
                    (int)row2Converted.X
                );
            }

            _icm20948.SetMemsInt32(0x01, 0x7C/*CPASS_MTX_10*/, (int)row2Converted.X);

            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Set Mem Bank 0x{MemBank:X2} Mem Start Addr 0x{MemStartAddress:X2} ({Name}): {Value}", 
                    0x01,
                    0x80/*CPASS_MTX_11*/,
                    "CPASS_MTX_11",
                    (int)row2Converted.Y
                );
            }

            _icm20948.SetMemsInt32(0x01, 0x80/*CPASS_MTX_11*/, (int)row2Converted.Y);

            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Set Mem Bank 0x{MemBank:X2} Mem Start Addr 0x{MemStartAddress:X2} ({Name}): {Value}", 
                    0x01,
                    0x84/*CPASS_MTX_12*/,
                    "CPASS_MTX_12",
                    (int)row2Converted.Z
                );
            }

            _icm20948.SetMemsInt32(0x01, 0x84/*CPASS_MTX_12*/, (int)row2Converted.Z);

            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Set Mem Bank 0x{MemBank:X2} Mem Start Addr 0x{MemStartAddress:X2} ({Name}): {Value}", 
                    0x01,
                    0x88/*CPASS_MTX_20*/,
                    "CPASS_MTX_20",
                    (int)row3Converted.X
                );
            }

            _icm20948.SetMemsInt32(0x01, 0x88/*CPASS_MTX_20*/, (int)row3Converted.X);

            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Set Mem Bank 0x{MemBank:X2} Mem Start Addr 0x{MemStartAddress:X2} ({Name}): {Value}", 
                    0x01,
                    0x8C/*CPASS_MTX_21*/,
                    "CPASS_MTX_21",
                    (int)row3Converted.Y
                );
            }

            _icm20948.SetMemsInt32(0x01, 0x8C/*CPASS_MTX_21*/, (int)row3Converted.Y);

            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Set Mem Bank 0x{MemBank:X2} Mem Start Addr 0x{MemStartAddress:X2} ({Name}): {Value}", 
                    0x01,
                    0x90/*CPASS_MTX_22*/,
                    "CPASS_MTX_22",
                    (int)row3Converted.Z
                );
            }

            _icm20948.SetMemsInt32(0x01, 0x90/*CPASS_MTX_22*/, (int)row3Converted.Z);
        }

        public void SetAccScale(Icm20948AccelFS accelFS)
        {
            uint value = accelFS switch
            {
                Icm20948AccelFS.Value2g => 1u << 25,
                Icm20948AccelFS.Value4g => 1u << 26,
                Icm20948AccelFS.Value8g => 1u << 27,
                Icm20948AccelFS.Value16g => 1u << 28,
                _ => throw new NotSupportedException()
            };

            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Set Mem Bank 0x{MemBank:X2} Mem Start Addr 0x{MemStartAddress:X2} ({Name}): {Value}", 
                    0x01,
                    0xE0/*ACC_SCALE*/,
                    "ACC_SCALE",
                    value
                );
            }

            _icm20948.SetMemsUInt32(0x01, 0xE0/*ACC_SCALE*/, value);
        }

        public void SetFifoWatermark(ushort value)
        {
            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Set Mem Bank 0x{MemBank:X2} Mem Start Addr 0x{MemStartAddress:X2} ({Name}): {Value}", 
                    0x01,
                    0xFE/*FIFO_WATERMARK*/,
                    "FIFO_WATERMARK",
                    value
                );
            }

            _icm20948.SetMemsUInt16(0x01, 0xFE/*FIFO_WATERMARK*/, value);
        }

        public void SetB2SRate(Icm20948Dmp3AlgoFreq b2sRate)
        {
            var valueRaw = (ushort)b2sRate;

            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Set Mem Bank 0x{MemBank:X2} Mem Start Addr 0x{MemStartAddress:X2} ({Name}): 0x{Data:X4} ({Value})", 
                    0x03,
                    0x08/*B2S_RATE*/,
                    "B2S_RATE",
                    valueRaw,
                    b2sRate
                );
            }

            _icm20948.SetMemsUInt16(0x03, 0x08/*B2S_RATE*/, valueRaw);
        }

        public void SetBacRate(Icm20948Dmp3AlgoFreq bacRate)
        {
            var valueRaw = (ushort)bacRate;

            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Set Mem Bank 0x{MemBank:X2} Mem Start Addr 0x{MemStartAddress:X2} ({Name}): 0x{Data:X4} ({Value})", 
                    0x03,
                    0x0A/*BAC_RATE*/,
                    "BAC_RATE",
                    valueRaw,
                    bacRate
                );
            }

            _icm20948.SetMemsUInt16(0x03, 0x0A/*BAC_RATE*/, valueRaw);
        }

        public void SetGyroFullScale(Icm20948GyroFS gyroFS)
        {
            uint value = gyroFS switch
            {
                Icm20948GyroFS.Value2000dps => 1u << 28,
                Icm20948GyroFS.Value1000dps => 1u << 27,
                Icm20948GyroFS.Value500dps => 1u << 26,
                Icm20948GyroFS.Value250dps => 1u << 25,
                _ => throw new NotSupportedException()
            };

            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Set Mem Bank 0x{MemBank:X2} Mem Start Addr 0x{MemStartAddress:X2} ({Name}): {Value}", 
                    0x04,
                    0x8C/*GYRO_FULL_SCALE*/,
                    "GYRO_FULL_SCALE",
                    value
                );
            }

            _icm20948.SetMemsUInt32(0x04, 0x8C/*GYRO_FULL_SCALE*/, value);
        }

        public void SetAccScale2(Icm20948AccelFS accelFS)
        {
            uint value = accelFS switch
            {
                Icm20948AccelFS.Value2g => 1u << 19,
                Icm20948AccelFS.Value4g => 1u << 18,
                Icm20948AccelFS.Value8g => 1u << 17,
                Icm20948AccelFS.Value16g => 1u << 16,
                _ => throw new NotSupportedException()
            };

            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Set Mem Bank 0x{MemBank:X2} Mem Start Addr 0x{MemStartAddress:X2} ({Name}): {Value}", 
                    0x04,
                    0xF4/*ACC_SCALE2*/,
                    "ACC_SCALE2",
                    value
                );
            }

            _icm20948.SetMemsUInt32(0x04/*Bank 4*/, 0xF4/*ACC_SCALE2*/, value);
        }

        public void SetAccelAlphaVar(ushort hwSmplRtDiv)
        {
            uint value;

            if (hwSmplRtDiv <= 5/*1125Hz / 5 = 225Hz*/)
            {
                value = 1_026_019_965u;
            }
            else if (hwSmplRtDiv <= 10/*1125Hz / 10 = 112Hz*/)
            {
                value = 977_872_018u;
            }
            else if (hwSmplRtDiv <= 11/*1125Hz / 11 = 102Hz*/)
            {
                value = 858_993_459u;
            }
            else if (hwSmplRtDiv <= 20/*1125Hz / 20 = 56Hz*/)
            {
                value = 882_002_213u;
            }
            else if (hwSmplRtDiv <= 22/*1125Hz / 22 = 51Hz*/)
            {
                value = 858_993_459u;
            }
            else if (hwSmplRtDiv <= 75/*1125Hz / 75 = 15Hz*/)
            {
                value = 357_913_941u;
            }
            else if (hwSmplRtDiv <= 225/*1125Hz / 225 = 5Hz*/)
            {
                value = 107_374_182u;
            }
            else
            {
                throw new NotSupportedException();
            }

            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Set Mem Bank 0x{MemBank:X2} Mem Start Addr 0x{MemStartAddress:X2} ({Name}): {Value}", 
                    0x05,
                    0xB0/*ACCEL_ALPHA_VAR*/,
                    "ACCEL_ALPHA_VAR",
                    value
                );
            }

            _icm20948.SetMemsUInt32(0x05, 0xB0/*ACCEL_ALPHA_VAR*/, value);
        }

        public void SetAccelAVar(ushort hwSmplRtDiv)
        {
            uint value;

            if (hwSmplRtDiv <= 5/*1125Hz / 5 = 225Hz*/)
            {
                value = 47_721_859u;
            }
            else if (hwSmplRtDiv <= 10/*1125Hz / 10 = 112Hz*/)
            {
                value = 95_869_806u;
            }
            else if (hwSmplRtDiv <= 11/*1125Hz / 11 = 102Hz*/)
            {
                value = 214_748_365u;
            }
            else if (hwSmplRtDiv <= 20/*1125Hz / 20 = 56Hz*/)
            {
                value = 191_739_611u;
            }
            else if (hwSmplRtDiv <= 22/*1125Hz / 22 = 51Hz*/)
            {
                value = 214_748_365u;
            }
            else if (hwSmplRtDiv <= 75/*1125Hz / 75 = 15Hz*/)
            {
                value = 715_827_883u;
            }
            else if (hwSmplRtDiv <= 225/*1125Hz / 225 = 5Hz*/)
            {
                value = 966_367_642u;
            }
            else
            {
                throw new NotSupportedException();
            }

            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Set Mem Bank 0x{MemBank:X2} Mem Start Addr 0x{MemStartAddress:X2} ({Name}): {Value}", 
                    0x05,
                    0xC0/*ACCEL_A_VAR*/,
                    "ACCEL_A_VAR",
                    value
                );
            }

            _icm20948.SetMemsUInt32(0x05, 0xC0/*ACCEL_A_VAR*/, value);
        }

        public void SetAccelCalRate(ushort hwSmplRtDiv)
        {
            ushort value;

            if (hwSmplRtDiv <= 10/*1125Hz / 10 = 112Hz*/)
            {
                value = 0;
            }
            else if (hwSmplRtDiv <= 11/*1125Hz / 11 = 102Hz*/)
            {
                value = 1;
            }
            else if (hwSmplRtDiv <= 225/*1125Hz / 225 = 5Hz*/)
            {
                value = 0;
            }
            else
            {
                throw new NotSupportedException();
            }

            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Set Mem Bank 0x{MemBank:X2} Mem Start Addr 0x{MemStartAddress:X2} ({Name}): {Value}", 
                    0x05,
                    0xE4/*ACCEL_CAL_RATE*/,
                    "ACCEL_CAL_RATE",
                    value
                );
            }

            _icm20948.SetMemsUInt16(0x05, 0xE4/*ACCEL_CAL_RATE*/, value);
        }

        public void SetB2SMtx(Vector3 row1, Vector3 row2, Vector3 row3)
        {
            const float multiplier = 1u << 30;
            Vector3 row1Converted = row1 * multiplier;
            Vector3 row2Converted = row2 * multiplier;
            Vector3 row3Converted = row3 * multiplier;

            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Set Mem Bank 0x{MemBank:X2} Mem Start Addr 0x{MemStartAddress:X2} ({Name}): {Value}", 
                    0x0D,
                    0x00/*B2S_MTX_00*/,
                    "B2S_MTX_00",
                    (int)row1Converted.X
                );
            }

            _icm20948.SetMemsInt32(0x0D, 0x00/*B2S_MTX_00*/, (int)row1Converted.X);

            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Set Mem Bank 0x{MemBank:X2} Mem Start Addr 0x{MemStartAddress:X2} ({Name}): {Value}", 
                    0x0D,
                    0x04/*B2S_MTX_01*/,
                    "B2S_MTX_01",
                    (int)row1Converted.Y
                );
            }

            _icm20948.SetMemsInt32(0x0D, 0x04/*B2S_MTX_01*/, (int)row1Converted.Y);

            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Set Mem Bank 0x{MemBank:X2} Mem Start Addr 0x{MemStartAddress:X2} ({Name}): {Value}", 
                    0x0D,
                    0x08/*B2S_MTX_02*/,
                    "B2S_MTX_02",
                    (int)row1Converted.Y
                );
            }

            _icm20948.SetMemsInt32(0x0D, 0x08/*B2S_MTX_02*/, (int)row1Converted.Z);

            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Set Mem Bank 0x{MemBank:X2} Mem Start Addr 0x{MemStartAddress:X2} ({Name}): {Value}", 
                    0x0D,
                    0x0C/*B2S_MTX_10*/,
                    "B2S_MTX_10",
                    (int)row2Converted.X
                );
            }

            _icm20948.SetMemsInt32(0x0D, 0x0C/*B2S_MTX_10*/, (int)row2Converted.X);

            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Set Mem Bank 0x{MemBank:X2} Mem Start Addr 0x{MemStartAddress:X2} ({Name}): {Value}", 
                    0x0D,
                    0x10/*B2S_MTX_11*/,
                    "B2S_MTX_11",
                    (int)row2Converted.Y
                );
            }

            _icm20948.SetMemsInt32(0x0D, 0x10/*B2S_MTX_11*/, (int)row2Converted.Y);

            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Set Mem Bank 0x{MemBank:X2} Mem Start Addr 0x{MemStartAddress:X2} ({Name}): {Value}", 
                    0x0D,
                    0x14/*B2S_MTX_12*/,
                    "B2S_MTX_12",
                    (int)row2Converted.Z
                );
            }

            _icm20948.SetMemsInt32(0x0D, 0x14/*B2S_MTX_12*/, (int)row2Converted.Z);

            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Set Mem Bank 0x{MemBank:X2} Mem Start Addr 0x{MemStartAddress:X2} ({Name}): {Value}", 
                    0x0D,
                    0x18/*B2S_MTX_20*/,
                    "B2S_MTX_20",
                    (int)row3Converted.X
                );
            }

            _icm20948.SetMemsInt32(0x0D, 0x18/*B2S_MTX_20*/, (int)row3Converted.X);

            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Set Mem Bank 0x{MemBank:X2} Mem Start Addr 0x{MemStartAddress:X2} ({Name}): {Value}", 
                    0x0D,
                    0x1C/*B2S_MTX_21*/,
                    "B2S_MTX_21",
                    (int)row3Converted.Y
                );
            }

            _icm20948.SetMemsInt32(0x0D, 0x1C/*B2S_MTX_21*/, (int)row3Converted.Y);

            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Set Mem Bank 0x{MemBank:X2} Mem Start Addr 0x{MemStartAddress:X2} ({Name}): {Value}", 
                    0x0D,
                    0x20/*B2S_MTX_22*/,
                    "B2S_MTX_22",
                    (int)row3Converted.Z
                );
            }

            _icm20948.SetMemsInt32(0x0D, 0x20/*B2S_MTX_22*/, (int)row3Converted.Z);
        }
    }
}
