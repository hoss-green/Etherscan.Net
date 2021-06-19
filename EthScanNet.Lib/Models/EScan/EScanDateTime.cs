using System;

namespace EthScanNet.Lib.Models.EScan
{
    public class EScanDateTime
    {
        private string _timeStamp;
        private DateTime _dateTime;


        // public BscDateTime(string timeStamp)
        // {
        //     this._timeStamp = timeStamp;
        //     if(long.TryParse(timeStamp, out long timeStampParsed))
        //     {
        //         throw new NotSupportedException("timeSpan must be able to be parsed to a long.");
        //     }
        //     
        //     this.DateTime = new(timeStampParsed);
        // }

        public EScanDateTime(long timeStamp)
        {
            this._timeStamp = timeStamp.ToString();
            this._dateTime = new(timeStamp);
        }

        public override string ToString()
        {
            return this._timeStamp;
        }

        public DateTime ToDateTime()
        {
            return this._dateTime;
        }
    }
}