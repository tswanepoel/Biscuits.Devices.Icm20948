namespace Biscuits.Devices.Icm20948.UserBank2
{
    public enum Icm20948AccelDlpfCfg : byte
    {
        Value246HzDefault = 0x0,
        Value246Hz = 0x1,
        Value111_4Hz = 0x2,
        Value50_4Hz = 0x3,
        Value23_9Hz = 0x4,
        Value11_5Hz = 0x5,
        Value5_7Hz = 0x6,
        Value473Hz = 0x7
    }
}