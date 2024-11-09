namespace Biscuits.Devices.Icm20948
{
    using System;
    using System.Device.Spi;
    using Microsoft.Extensions.Logging;
    using Microsoft.Extensions.Logging.Abstractions;

    public partial class Icm20948Spi : IDisposable
    {
        private readonly int _busId;
        private readonly int _chipSelectLine;
        private readonly ILogger<Icm20948Spi> _logger;
        private readonly SpiDevice _device;

        private static readonly object _syncRoot = new();
        private bool _disposed;

        public Icm20948Spi(int busId, int chipSelectLine = -1, ILogger<Icm20948Spi>? logger = null)
        {
            _busId = busId;
            _chipSelectLine = chipSelectLine;
            _logger = logger ?? NullLogger<Icm20948Spi>.Instance;

            var settings = new SpiConnectionSettings(_busId, _chipSelectLine)
            {
                ClockFrequency = 7_000_000/*7 MHz*/,
                Mode = SpiMode.Mode0
            };

            _device = SpiDevice.Create(settings);
        }

        public ushort ReadRegisterUInt16(Icm20948UserBank userBank, byte address)
        {
            lock (_syncRoot)
            {
                var regBankSel = (Icm20948RegBankSel)ReadRegisterByteUnsafe(0x7F/*REG_BANK_SEL*/);
                regBankSel.UserBank = userBank;
                WriteRegisterUnsafe(0x7F/*REG_BANK_SEL*/, [(byte)regBankSel]);

                return ReadRegisterUInt16Unsafe(address);
            }
        }

        public byte ReadRegisterByte(Icm20948UserBank userBank, byte address)
        {
            lock (_syncRoot)
            {
                var regBankSel = (Icm20948RegBankSel)ReadRegisterByteUnsafe(0x7F/*REG_BANK_SEL*/);
                regBankSel.UserBank = userBank;
                WriteRegisterUnsafe(0x7F/*REG_BANK_SEL*/, [(byte)regBankSel]);
                
                return ReadRegisterByteUnsafe(address);
            }
        }

        public void ReadRegister(Icm20948UserBank userBank, byte address, Span<byte> buffer)
        {
            lock (_syncRoot)
            {
                var regBankSel = (Icm20948RegBankSel)ReadRegisterByteUnsafe(0x7F/*REG_BANK_SEL*/);
                regBankSel.UserBank = userBank;
                WriteRegisterUnsafe(0x7F/*REG_BANK_SEL*/, [(byte)regBankSel]);

                ReadRegisterUnsafe(address, buffer);
            }
        }
        
        public void WriteRegisterUInt16(Icm20948UserBank userBank, byte address, ushort value)
        {
            WriteRegister(userBank, address, [(byte)((value >> 8) & 0xFF), (byte)(value & 0xFF)]);
        }

        public void WriteRegisterByte(Icm20948UserBank userBank, byte address, byte value)
        {
            WriteRegister(userBank, address, [value]);
        }

        public void WriteRegister(Icm20948UserBank userBank, byte address, ReadOnlySpan<byte> buffer)
        {
            lock (_syncRoot)
            {
                var regBankSel = (Icm20948RegBankSel)ReadRegisterByteUnsafe(0x7F/*REG_BANK_SEL*/);
                regBankSel.UserBank = userBank;
                WriteRegisterUnsafe(0x7F/*REG_BANK_SEL*/, [(byte)regBankSel]);

                WriteRegisterUnsafe(address, buffer);
            }
        }

        private ushort ReadRegisterUInt16Unsafe(byte address)
        {
            var buffer = new byte[2];
            
            ReadRegisterUnsafe(address, buffer);
            return (ushort)((buffer[0] << 8) | buffer[1]);
        }

        private byte ReadRegisterByteUnsafe(byte address)
        {
            var buffer = new byte[1];

            ReadRegisterUnsafe(address, buffer);
            return buffer[0];
        }

        private void ReadRegisterUnsafe(byte address, Span<byte> buffer)
        {
            var internalBuffer = new byte[1/*Address*/ + buffer.Length];
            internalBuffer[0] = (byte)(0x80/*Read*/ | address);
            _device.TransferFullDuplex(internalBuffer, internalBuffer);
            internalBuffer.AsSpan(1).CopyTo(buffer);
        }

        private void WriteRegisterUnsafe(byte address, ReadOnlySpan<byte> buffer)
        {
            byte[] internalBuffer = [(byte)(0x7F/*Write*/ & address), .. buffer];
            _device.TransferFullDuplex(internalBuffer, internalBuffer);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _device.Dispose();
            }

            _disposed = true;
        }
    }
}
