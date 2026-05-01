namespace Biscuits.Devices.Icm20948.Tests
{
    using Microsoft.Extensions.Logging;
    using Xunit;
    using Xunit.Abstractions;
    using Biscuits.Devices.Icm20948.UserBank0;
    using Biscuits.Devices.Icm20948.UserBank2;
    using Biscuits.Devices.Icm20948.UserBank3;

    public class Icm20948Tests : IDisposable
    {
        private readonly Icm20948Fixture _fixture;
        private readonly ILogger<Icm20948Tests> _logger;
        private readonly Icm20948Spi _icm20948;

        public Icm20948Tests(ITestOutputHelper output)
        {
            _fixture = new Icm20948Fixture(output);
            _logger = _fixture.LoggerFactory.CreateLogger<Icm20948Tests>();
            _icm20948 = _fixture.Icm20948;
        }

        private async Task Initialize()
        {
            _logger.LogDebug("Reset device");
            // ICM_20948::swReset
            {
                Icm20948PwrMgmt1 pwrMgmt1 = _icm20948.ReadPwrMgmt1();
                pwrMgmt1.DeviceReset = true;
                _icm20948.WritePwrMgmt1(pwrMgmt1);
                await Task.Delay(TimeSpan.FromMilliseconds(100));
            }

            _logger.LogDebug("Wake up from sleep");
            // ICM_20948::sleep(false)
            {
                Icm20948PwrMgmt1 pwrMgmt1 = _icm20948.ReadPwrMgmt1();
                pwrMgmt1.Sleep = false;
                _icm20948.WritePwrMgmt1(pwrMgmt1);
                await Task.Delay(TimeSpan.FromMicroseconds(175));
            }

            _logger.LogDebug("Turn off low power");
            // ICM_20948::lowPower(false)
            {
                Icm20948PwrMgmt1 pwrMgmt1 = _icm20948.ReadPwrMgmt1();
                pwrMgmt1.LpEn = false;
                _icm20948.WritePwrMgmt1(pwrMgmt1);
                await Task.Delay(TimeSpan.FromMicroseconds(175));
            }

            _logger.LogDebug("Disable I2C interface");
            // SPI only
            {
                Icm20948UserCtrl userCtrl = _icm20948.ReadUserCtrl();
                userCtrl.I2cIFDis = true;
                _icm20948.WriteUserCtrl(userCtrl);
                await Task.Delay(TimeSpan.FromMilliseconds(60));
            }
        }

        [Fact]
        public void ReadWhoAmI_ShouldReturnCorrectDeviceId()
        {
            // Act
            byte result = _icm20948.ReadWhoAmI();

            // Assert
            Assert.Equal(0xEA, result);
        }

        [Fact]
        public async Task MagnetometerReadWhoAmI_ShouldReturnCorrectDeviceId()
        {
            // Arrange
            await Initialize();

            _logger.LogDebug("Disconnect bypass to auxiliary sensors");
            // ICM_20948::i2cMasterPassthrough
            {
                Icm20948IntPinCfg intPinCfg = _icm20948.ReadIntPinCfg();
                intPinCfg.BypassEn = false;
                _icm20948.WriteIntPinCfg(intPinCfg);
            }

            _logger.LogDebug("Set up I2C master");
            // ICM_20948::i2cMasterEnable
            {
                Icm20948I2cMstCtrl i2cMstCtrl = _icm20948.ReadI2cMstCtrl();
                i2cMstCtrl.I2cMstPNsr = Icm20948I2cMstPNsr.StopBetweenReads;
                i2cMstCtrl.I2cMstClk = Icm20948I2cMstClk.Value345_6kHzWith46_67PercentDutyCycle;
                _icm20948.WriteI2cMstCtrl(i2cMstCtrl);
            }

            _logger.LogDebug("Reset magnetometer");
            // ICM_20948::resetMag
            {
                Icm20948UserCtrl userCtrl = _icm20948.ReadUserCtrl();
                userCtrl.I2cMstEn = true;
                _icm20948.WriteUserCtrl(userCtrl);
                await Task.Delay(TimeSpan.FromMilliseconds(60));

                _icm20948.I2cSlv4WriteByte(0x0C/*AK09916*/, 0x32/*CNTL3*/, 0x01/*SRST*/, TimeSpan.FromMilliseconds(100));

                userCtrl.I2cMstEn = false;
                _icm20948.WriteUserCtrl(userCtrl);
            }

            // Act
            byte whoIAm1;
            byte whoIAm2;

            _logger.LogDebug("Check magnetometer WHO_AM_I");
            // ICM_20948::magWhoIAm
            {
                Icm20948UserCtrl userCtrl = _icm20948.ReadUserCtrl();
                userCtrl.I2cMstEn = true;
                _icm20948.WriteUserCtrl(userCtrl);
                await Task.Delay(TimeSpan.FromMilliseconds(60));

                whoIAm1 = _icm20948.I2cSlv4ReadByte(0x0C/*AK09916*/, 0x00/*WHO_I_AM_1*/, TimeSpan.FromMilliseconds(100));
                whoIAm2 = _icm20948.I2cSlv4ReadByte(0x0C/*AK09916*/, 0x01/*WHO_I_AM_2*/, TimeSpan.FromMilliseconds(100));
                
                userCtrl.I2cMstEn = false;
                _icm20948.WriteUserCtrl(userCtrl);
            }

            // Assert
            Assert.Equal(0x4809, (whoIAm1 << 8) | whoIAm2);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
            _fixture?.Dispose();
        }
    }
}