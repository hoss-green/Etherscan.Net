# Etherscan.Net
I originally wrapped this for use in another project, I figured that if I was doing this, I may as well open source it to the community and see if I can help out anyone working with .NET5/.NETCore. I needed something that supported all the Etherscan networks, not just the Ethereum chain. 

## Packages
Current Nuget packages are available here: https://www.nuget.org/packages/Etherscan.net/

## Demo
For people who learn by example, there is a demo project called EthScanNet.Test which shows how the API works.
For people who prefer guides:

## Usage
Firstly choose the Etherscan network you'd like to join
```C#
public static readonly EScanNetwork EScanMainNet = new("https://api.etherscan.io/api");
public static readonly EScanNetwork RopstenNet = new("https://api-ropsten.etherscan.io/api");
public static readonly EScanNetwork KovanNet = new("https://api-kovan.etherscan.io/api");
public static readonly EScanNetwork RinkebyNet = new("https://api-rinkeby.etherscan.io/api");
public static readonly EScanNetwork GoerliNet = new("https://api-goerli.etherscan.io/api");
public static readonly EScanNetwork BscTestNet = new("https://api-testnet.bscscan.com/api");
public static readonly EScanNetwork BscMainNet = new("https://api.bscscan.com/api");
```

Instantiate a new EScanClient with the relevant network you wish to connect to (from Etherscan).
``` C#
EScanClient client = new(EScanNetwork.BscTestNet, "YourApiKeyToken");
```

If you're on the free API tier, the throttle is set to 200ms (5 actions per second maximum), to turn this off, set the throttle to null
``` C#
EScanClient client = new(EScanNetwork.BscTestNet, "YourApiKeyToken", null);
```

Call one of the API end points to get your result, I would suggest wrapping in a try/catch block to catch errors:
``` C#
try 
{
    EScanBalance apiBalance = await client.Accounts.GetBalanceAsync(new("0x0000000000000000000000000000000000001004"));
}
catch (Exception e)
{
    Console.WriteLine(e);
    throw;
}
```

# Tip!
Always happy to receive donations to help me support my work or buy pizza.

BSC: 0x44ed8E0c45b82d12cAF02f73294fa9AfED48eD80

ETH: 0x44ed8E0c45b82d12cAF02f73294fa9AfED48eD80

BTC: 1Jwk86Rx42aJqKymBaCwtM8nqBinxGqMpX

## License
MIT: Copyright (c) 2021 Hoss

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.