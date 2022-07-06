using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class TmobileInfo
    {
        public Device device { get; set; }
        public Signal signal { get; set; }
        public Time Time { get; set; }
    }

    public class Signal
    {
        [JsonProperty(PropertyName = "4g")]
        public _4g _4g { get; set; }
        [JsonProperty("5g")]
        public _5g _5g { get; set; }
        public Generic generic { get; set; }
    }

    public class Device
    {
        public string friendlyName { get; set; }
        public string hardwareVersion { get; set; }
        public bool isEnabled { get; set; }
        public bool isMeshSupported { get; set; }
        public string macId { get; set; }
        public string manufacturer { get; set; }
        public string manufacturerOUI { get; set; }
        public string model { get; set; }
        public string name { get; set; }
        public string role { get; set; }
        public string serial { get; set; }
        public string softwareVersion { get; set; }
        public string type { get; set; }
        public string updateState { get; set; }
    }

    public class _4g
    {
        public List<string> bands { get; set; }
        public double bars { get; set; }
        public int cid { get; set; }
        public int eNBID { get; set; }
        public int rsrp { get; set; }
        public int rsrq { get; set; }
        public int rssi { get; set; }
        public int sinr { get; set; }
    }

    public class _5g
    {
        public List<string> bands { get; set; }
        public double bars { get; set; }
        public int cid { get; set; }
        public int gNBID { get; set; }
        public int rsrp { get; set; }
        public int rsrq { get; set; }
        public int rssi { get; set; }
        public int sinr { get; set; }
    }

    public class DaylightSavings
    {
        public bool isUsed { get; set; }
    }


    public class Generic
    {
        public string apn { get; set; }
        public bool hasIPv6 { get; set; }
        public string registration { get; set; }
        public bool roaming { get; set; }
    }



    public class Time
    {
        public DaylightSavings daylightSavings { get; set; }
        public int localTime { get; set; }
        public string localTimeZone { get; set; }
        public int upTime { get; set; }
    }

}
