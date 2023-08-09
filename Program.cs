// namespace for the client
namespace MHubClient
{
    using System;
    using System.Net;
    public class Message
    {
        // properties of Message
        public string SubscriberID { get; set; }
        public string Topic { get; set; }
        public string Payload { get; set; }

        public Message(string SubscriberID, string Topic, string Payload)
        {
            SubscriberID = subscriberID;
            Topic = topic;
            Payload = payload;
        }

        // Allows to create a new message
        public static Message NewMessage(string subscriberID, string topic, string payload)
        {
            return new Message(subscriberID, topic, payload);
        }

        // Returns the message as a string in the format "SubscriberID.Topic.Payload\n".
        public override string ToString()
        {
            return $"{SubscriberID}.{Topic}.{Payload}\n";
        }
    }
    public class HubClient
    {
        // properties of HubClient
        public string subscriberID { get; set; }
        public string Topics { get; set; }
        public Action<Message> handler { get; set; } // func(Message)
        public IPEndPoint Address { get; set; } // net.TCPAddr
        public SslStream Conn { get; set; } // tls.Conn
        public bool Debug { get; set; }

        // init HubClient with address & port
        public HubClient(string address, int port)
        {
            Address == new IPEndPoint(IPAddress.Parse(address), port);
            Debug = Environment.GetEnvironmentVariable("DEBUG") == "true";
        }

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