// namespace for the client
namespace MHubClient
{
    public class Message
    {
        // properties
        public string SubscriberID { get; set; }
        public string Topic { get; set; }
        public string Payload { get; set; }

        // func NewMessage
        public Message(string SubscriberID, string Topic, string Payload)
        {
            SubscriberID = subscriberID;
            Topic = topic;
            Payload = payload;
        }
        public static Message NewMessage(string subscriberID, string topic, string payload)
        {
            return new Message(subscriberID, topic, payload);
        }
        //!todo tostring
    }
    public class HubClient
    {
        // properties
        public string subscriberID { get; set; }
        public string Topics { get; set; }
        public Action<Message> handler { get; set; } // func(Message)
        public IPEndPoint Address { get; set; } // net.TCPAddr
        public SslStream Conn { get; set; } // tls.Conn
        public bool Debug { get; set; }

    }
    class Programs
    {
        // main func
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}