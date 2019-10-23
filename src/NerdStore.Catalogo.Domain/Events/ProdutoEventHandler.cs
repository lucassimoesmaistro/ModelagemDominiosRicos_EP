﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NerdStore.Catalogo.Domain.Events
{
    public class ProdutoEventHandler :
        INotificationHandler<ProdutoAbaixoEstoqueEvent>
    {
        private readonly IProdutoRepository _produtoRepository;
        //private readonly IEstoqueService _estoqueService;
        //private readonly IMediatorHandler _mediatorHandler;
        public ProdutoEventHandler(IProdutoRepository produtoRepository)//,
                                   //IEstoqueService estoqueService,
                                   //IMediatorHandler mediatorHandler)
        {
            _produtoRepository = produtoRepository;
            //_estoqueService = estoqueService;
            //_mediatorHandler = mediatorHandler;
        }
        public async Task Handle(ProdutoAbaixoEstoqueEvent mensagem, CancellationToken cancellationToken)
        {
            var produto = await _produtoRepository.ObterPorId(mensagem.AggregateId);

            // Enviar um email para aquisicao de mais produtos.
        }
    }
}
