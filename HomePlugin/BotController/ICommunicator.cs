﻿namespace HOME
{
    public interface ICommunicator
    {
        void Connect();
        void Disconnect();
        byte[] ReadBytes(uint offset, int length);
        bool Connected { get; set; }
        int Port { get; set; }
        string IP { get; set; }
    }
}