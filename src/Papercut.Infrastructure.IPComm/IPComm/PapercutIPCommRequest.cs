namespace Papercut.Infrastructure.IPComm.IPComm
{
    using System;

    public class PapercutIPCommRequest
    {
        public PapercutIPCommCommandType CommandType { get; set; }

        public Type Type { get; set; }

        public int ByteSize { get; set; }
    }
}