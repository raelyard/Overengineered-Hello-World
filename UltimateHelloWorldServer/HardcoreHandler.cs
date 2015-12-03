using System;
using Messages;
using NServiceBus;

namespace UltimateHelloWorldServer
{
    public class HardcoreHandler : IHandleMessages<CreateHelloWorld>
    {
        public void Handle(CreateHelloWorld message)
        {
            Console.WriteLine("Hello World");
        }
    }
}
