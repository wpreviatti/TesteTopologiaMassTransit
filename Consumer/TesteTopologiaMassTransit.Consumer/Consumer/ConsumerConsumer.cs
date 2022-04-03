namespace Company.Consumers
{
    using System.Threading.Tasks;
    using MassTransit;
    using Contracts;
    using System;
    using TesteTopologiaMassTransit.Api.Models;

    public class ConsumerConsumer :
        IConsumer<TesteModel>
    {
        public Task Consume(ConsumeContext<TesteModel> context)
        {
            Console.WriteLine($"Valor recebido e entendido {context.Message.Id}");
            return Task.CompletedTask;
        }
    }
}