using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ApiChecker.Models
{
    public class GlobalLocationModel
    {
        /// <summary>
        /// Location where test completed 
        /// </summary>
        /// <value>The location.</value>
        public string Location { get; set; }

        /// <summary>
        /// Current status of service
        /// </summary>
        /// <value><c>true</c> if service working (200 OK); otherwise, <c>false</c>.</value>
        public bool Status { get; set; }

        /// <summary>
        /// HTTP status code response from current locaiton
        /// </summary>
        /// <value>The HTTP response code.</value>
        public int ResponseCode { get; set; }

        /// <summary>
        /// How long data get downloaded in miliseconds 
        /// </summary>
        /// <value>Download Timming (ms)</value>
        public int Download { get; set; }

        /// <summary>
        /// DNS resolution time
        /// </summary>
        /// <value>DNS resolution time</value>
        public int Dns { get; set; }

        /// <summary>
        /// TCP connection open time
        /// </summary>
        /// <value>TCP connection type</value>
        public int Tcp { get; set; }

        [JsonProperty("elapsedTime")]
        public float TotalTime;

        public override string ToString()
        {
            return $"{Location} - Response Code: {ResponseCode}";
        }


    }
}
