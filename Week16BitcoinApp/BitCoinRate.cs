namespace Week16BitcoinApp
{
    public class BitCoinRate
    {
        public Disclaimer disclaimer { get; set; }
        public Bpi bpi { get; set; }
    }

    public class Disclaimer
    {
        public string disclaimer { get; set; }
    }

    public class Bpi
    {
        public EUR EUR { get; set; }
        public USD USD { get; set; }
    }

    public class EUR
    {
        public string code { get; set; }
        public float rate_float { get; set; }
    }
    public class USD
    {
        public string code { get; set; }
        public float rate_float { get; set; }
    }
}
