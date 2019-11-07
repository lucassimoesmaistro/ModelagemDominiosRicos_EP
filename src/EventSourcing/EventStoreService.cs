﻿using EventStore.ClientAPI;
using Microsoft.Extensions.Configuration;

namespace EventSourcing
{
    //docker pull eventstore/eventstore
    //docker run --name eventstore-node -it -p 2113:2113 -p 1113:1113 eventstore/eventstore
    //docker run -ti eventstore/eventstore
    public class EventStoreService : IEventStoreService
    {
        private readonly IEventStoreConnection _connection;

        public EventStoreService(IConfiguration configuration)
        {
            _connection = EventStoreConnection.Create(
                configuration.GetConnectionString("EventStoreConnection"));

            _connection.ConnectAsync();
        }

        public IEventStoreConnection GetConnection()
        {
            return _connection;
        }
    }
}
