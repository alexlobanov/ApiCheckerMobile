using System;
using System.Collections.Generic;

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

        public int FirstByte { get; set; }

        public int Dns { get; set; }

        public int Tcp { get; set; }

        public float TotalTime => Download + FirstByte + Dns + Tcp;

        public override string ToString()
        {
            return $"{Location} - Response Code: {ResponseCode}";
        }


    }
}
