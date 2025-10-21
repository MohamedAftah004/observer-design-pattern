namespace OnlineMarketplace_with_observer.Entities
{
    public class Offer
    {

        private string _message;

        public Offer(string message)
        {
            _message = message;
        }


        public string GetMessage()
        {
            return _message;
        }
    }
}