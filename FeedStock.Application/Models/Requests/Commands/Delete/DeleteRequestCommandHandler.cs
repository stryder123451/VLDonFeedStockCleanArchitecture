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

namespace FeedStock.Application.Models.Requests.Commands.Delete
{
    public class DeleteRequestCommandHandler : IRequestHandler<DeleteRequestCommand>
    {
        public IFeedStockDbContext _context;
        public DeleteRequestCommandHandler(IFeedStockDbContext context)
        {
            _context = context;
        }
        public async Task<Unit> Handle(DeleteRequestCommand request, CancellationToken cancellationToken)
        {
            var res = await _context.Requests.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
            if (res == null)
            {
                throw new NotFoundException(nameof(Request), request.Id);
            }

            _context.Requests.Remove(res);
            await _context.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
