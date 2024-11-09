namespace Biscuits.Devices.Icm20948.UserBank0
{
    public enum Icm20948ClkSel : byte
    {
        Internal20MHz = 0x0,
        AutoDetect = 0x1,
        AutoDetect2 = 0x2,
        AutoDetect3 = 0x3,
        AutoDetect4 = 0x4,
        AutoDetect5 = 0x5,
        Internal20MHz2 = 0x6,
        Stopped = 0x7
    }
}
