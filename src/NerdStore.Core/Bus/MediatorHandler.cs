using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using NerdStore.Core.Messages;

namespace NerdStore.Core.Bus
{
    public class MediatorHandler : IMediatorHandler
    {
        private readonly IMediator _mediator;
//        private readonly IEventSourcingRepository _eventSourcingRepository;

        public MediatorHandler(IMediator mediator) //, IEventSourcingRepository eventSourcingRepository)
        {
            _mediator = mediator;
            //_eventSourcingRepository = eventSourcingRepository;
        }


        public async Task PublicarEvento<T>(T evento) where T : Event
        {
            await _mediator.Publish(evento);
        }


        public async Task<bool> EnviarComando<T>(T comando) where T : Command
        {
            return await _mediator.Send(comando);
        }
    }
}
