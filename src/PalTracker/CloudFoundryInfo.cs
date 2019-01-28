namespace PalTracker
{
    public class CloudFoundryInfo
    {
        public string Port { get; }
        public string MemoryLimit { get; }
        public string CfInstanceIndex { get; }
        public string CfInstanceAddr { get; }

        public CloudFoundryInfo(string port, string memorylimit, string instanceindex, string instanceaddr)
        {   
            Port = port;
            MemoryLimit = memorylimit;
            CfInstanceIndex = instanceindex;
            CfInstanceAddr = instanceaddr;
        }
    }
}