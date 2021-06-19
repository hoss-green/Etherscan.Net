using System;
using System.Globalization;
using System.Numerics;

namespace EthScanNet.Lib.Models.EScan
{
    public class EScanAddress
    {
        private string _address;
        
        public EScanAddress(string address)
        {
            if (!address.StartsWith("0x"))
            {
                throw new NotSupportedException("address must start with leading 0x and be in hex format");
            }

            string tempAddress = address.Substring(2, address.Length - 2);
            
            if (!BigInteger.TryParse(tempAddress, NumberStyles.HexNumber, null, out BigInteger result))
            {
                throw new NotSupportedException("address must be in hex format");
            }

            this._address = address;
        }

        public override string ToString()
        {
            return this._address;
        }
    }
}