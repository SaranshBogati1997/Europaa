namespace Lib
{
    using System;
    using System.Collections.Generic;
    
    public class DetailLogModel
    {
        public int LogId { get; set; }
        public string Module { get; set; }
        public string LogType { get; set; }
        public string LogMessage { get; set; }
        public string LogDetails { get; set; }
        public DateTime LoggedDate { get; set; }
    }
}
