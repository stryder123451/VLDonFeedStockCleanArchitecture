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

namespace FeedStock.Application.Models.Requests.Commands.Update
{
    public class UpdateRequestCommandHandler : IRequestHandler<UpdateRequestCommand>
    {
        private IFeedStockDbContext _context;
        public UpdateRequestCommandHandler(IFeedStockDbContext context)
        {
            _context = context;
        }
        public async Task<Unit> Handle(UpdateRequestCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.Requests.FirstOrDefaultAsync(x=> x.Id == request.Id, cancellationToken);
            if (entity == null)
            {
                throw new NotFoundException(nameof(Request), request.Id);
            }
            entity.State = request.State;
            entity.Organization = request.Organization;
            entity.Name = request.Name;
            entity.Data = request.Data;
            entity.Address = request.Address;
            entity.Materials = request.Materials;
            entity.Description = request.Description;
            entity.Id = request.Id;
            entity.RelatedOrganizationId = request.RelatedOrganizationId;
            entity.LastModified = request.LastModified;
            entity.TakenData = request.TakenData;
            entity.WeightData = request.WeightData;
            entity.FinishedData = request.FinishedData;
            entity.WhoClosed = request.WhoClosed;
            entity.WhoTook = request.WhoTook;
            entity.WhoWeighed = request.WhoWeighed;
            entity.Price = request.Price;
            entity.OldCartonPrice = request.OldCartonPrice;
            entity.OldPlenkaPrice = request.OldPlenkaPrice;
            entity.OldPoddonPrice = request.OldPoddonPrice;

            await _context.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
