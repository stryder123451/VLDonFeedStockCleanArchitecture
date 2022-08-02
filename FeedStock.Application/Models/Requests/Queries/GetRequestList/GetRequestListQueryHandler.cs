using AutoMapper;
using AutoMapper.QueryableExtensions;
using FeedStock.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedStock.Application.Models.Requests.Queries.GetRequestList
{
    public class GetRequestListQueryHandler : IRequestHandler<GetRequestListQuery, GetRequestListClassViewModel>
    {
        private IFeedStockDbContext _context;
        private IMapper _mapper;
        public GetRequestListQueryHandler(IFeedStockDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<GetRequestListClassViewModel> Handle(GetRequestListQuery request, CancellationToken cancellationToken)
        {
            var res = await _context.Requests.Where(req => req.State == request.State).ProjectTo<GetRequestListClass>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);
            return new GetRequestListClassViewModel { RequestList = res };
        }
    }
}
