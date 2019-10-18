﻿using System;
using System.Threading.Tasks;
using NServiceBus;
using Sample;

class MyHandler :
    IHandleMessages<MyMessage>
{
    public Task Handle(MyMessage message, IMessageHandlerContext context)
    {
        Console.WriteLine($"Hello from MyHandler {message.Name}");
        return Task.CompletedTask;
    }
}