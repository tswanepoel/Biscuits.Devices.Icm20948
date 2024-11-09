namespace Biscuits.Devices.Icm20948
{
    using System;
    using Microsoft.Extensions.Logging;

    public partial class Icm20948Spi
    {
        public float ReadTimebaseCorrectionPll()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(Icm20948Spi));
            }

            byte valueRaw = ReadRegisterByte(Icm20948UserBank.UserBank1, 0x28/*TIMEBASE_CORRECTION_PLL*/);

            float value =
                (valueRaw & 0x80) != 0
                    ? (127 - (valueRaw & 0x7F)) / 127f * -.1f
                    : valueRaw / 127f * .1f;

            if (_logger.IsEnabled(LogLevel.Debug))
            {
                _logger.LogDebug(
                    "Read from User Bank 0x{UserBank:X2} Reg 0x{Address:X2} ({Name}): {Value}",
                    (byte)Icm20948UserBank.UserBank1,
                    0x28/*TIMEBASE_CORRECTION_PLL*/,
                    "TIMEBASE_CORRECTION_PLL",
                    value
                );
            }

            return value;
        }
    }
}
