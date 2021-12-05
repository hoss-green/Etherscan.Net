using EthScanNet.Lib.Enums;
using EthScanNet.Lib.Models.ApiResponses.Accounts;
using EthScanNet.Lib.Models.EScan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EthScanNet.Lib.Models.ApiRequests.Accounts
{
    internal class EScanGetERC20TokenTransferEvents: EScanAccountRequest
    {
        public EScanGetERC20TokenTransferEvents(EScanAddress address, EScanClient eScanClient)
           : base(address, eScanClient, EScanModules.Account, EScanActions.TxErc20Token, typeof(EScanERC20TokenTransferEvents))
        {
        }
    }
}
