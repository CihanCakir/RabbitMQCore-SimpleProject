using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RabbitMQRT.Producer.RabbitMQ
{
    public class Publisher
    {


        public void GetPublish(string routeKey, string? type)
        {
            Stopwatch stopwatch = new Stopwatch();
            var factory = new ConnectionFactory();
            factory.Uri = new Uri("amqp://tpivhhjj:vCIKKcmYXHXiF29djb8XCQgOodUrcf8X@lion.rmq.cloudamqp.com/tpivhhjj");

            using (var connection = factory.CreateConnection())
            {
                using (var channel = connection.CreateModel())
                {
                    channel.ExchangeDeclare("File-Uplooad",durable:true,type:ExchangeType.type)




                }
            }
        }

    }
}
