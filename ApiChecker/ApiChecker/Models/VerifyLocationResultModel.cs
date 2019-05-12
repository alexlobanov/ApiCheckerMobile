using System;
namespace ApiChecker.Models
{
    public class VerifyLocationResultModel
    {
        public float TotalTime { get; set; }

        public string Location { get; set; }

        public bool Status { get; set; }

        public int ResponseCode { get; set; }



        public int Wait { get; set; }

        public int Download { get; set; }

        public int FirstByte { get; set; }

        public int Dns { get; set; }

        public int Tcp { get; set; }
    }
}
