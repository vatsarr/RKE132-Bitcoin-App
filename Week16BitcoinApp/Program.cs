using Newtonsoft.Json;
using System.Net;
using Week16BitcoinApp;

BitCoinRate bitcoin = GetRates();
Console.WriteLine($"Current Bitcoin rate is: {bitcoin.bpi.EUR.rate_float} {bitcoin.bpi.EUR.code}");
Console.WriteLine($"Current Bitcoin rate is: {bitcoin.bpi.USD.rate_float} {bitcoin.bpi.USD.code}");

//Console.WriteLine($"{bitcoin.disclaimer}");

static BitCoinRate GetRates()
{
    string url = "https://api.coindesk.com/v1/bpi/currentprice.json";

    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
    request.Method = "GET";

    var webResponse = request.GetResponse();
    var webStream = webResponse.GetResponseStream();

    BitCoinRate bitCoinRate;

    using (var responseReader = new StreamReader(webStream))
    {
        var response = responseReader.ReadToEnd();
        bitCoinRate = JsonConvert.DeserializeObject<BitCoinRate>(response);
    }
    return bitCoinRate;
}