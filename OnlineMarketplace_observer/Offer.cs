namespace OnlineMarketplace
{
    public class Offer
    {

        private string _message;

        public Offer(string message)
        {
            _message = message;
        }


        public string getMessage()
        {
            return _message;
        }
    }
}