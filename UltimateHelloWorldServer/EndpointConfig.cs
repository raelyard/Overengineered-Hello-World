
using System;

namespace UltimateHelloWorldServer
{
    using NServiceBus;
    
    public class EndpointConfig : IConfigureThisEndpoint
    {
        public void Customize(BusConfiguration configuration)
        {
            configuration.UsePersistence<InMemoryPersistence>();
            configuration.EnableInstallers();
            Console.WriteLine("Hello World");
        }
    }
}
