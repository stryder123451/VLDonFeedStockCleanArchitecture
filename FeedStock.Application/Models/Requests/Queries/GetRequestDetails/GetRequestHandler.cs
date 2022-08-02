using AutoMapper;
using FeedStock.Application.Common.Exceptions;
using FeedStock.Application.Interfaces;
using FeedStock.Domain.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedStock.Application.Models.Requests.Queries.GetRequestDetails
{
    public class GetRequestHandler : IRequestHandler<GetRequest, Request>
    {
        private readonly IFeedStockDbContext _context;
        private readonly IMapper _mapper;
        public async Task<Request> Handle(GetRequest request, CancellationToken cancellationToken)
        {
            var res = await _context.Requests.FirstOrDefaultAsync(x => x.Id == request.Id);
            if (res == null)
            {
                throw new NotFoundException(nameof(Request), request.Id);
            }

            return res;
        }
    }
}

