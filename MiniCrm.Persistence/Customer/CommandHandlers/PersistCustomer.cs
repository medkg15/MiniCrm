﻿using AutoMapper;
using MediatR;
using MiniCrm.Application.Customer.Commands;
using MiniCrm.DataModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MiniCrm.Persistence.Customer.CommandHandlers
{
    public class PersistCustomer : AsyncRequestHandler<AddCustomer>
    {
        private readonly CrmContext context;
        private readonly IMapper mapper;

        public PersistCustomer(CrmContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        protected override async Task Handle(AddCustomer request, CancellationToken cancellationToken)
        {
            var entity = mapper.Map<DataModel.Customer>(request);

            context.Customers.Add(entity);

            await context.SaveChangesAsync(cancellationToken);
        }
    }
}
