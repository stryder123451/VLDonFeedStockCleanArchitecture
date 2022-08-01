using FeedStock.Application.Interfaces;
using FeedStock.Domain.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedStock.Application.Models.Requests.Commands.Create
{
    public class CreateRequestCommandHandler : IRequestHandler<CreateRequestCommand, int>
    {
        private IFeedStockDbContext _context;
        public CreateRequestCommandHandler(IFeedStockDbContext context)
        {
            _context = context;
        }
        public async Task<int> Handle(CreateRequestCommand request, CancellationToken cancellationToken)
        {
                var organization = await _context.Organizations.FirstOrDefaultAsync(x=>x.Name==request.Organization,cancellationToken);
                
                var record = new Request()
                {
                    Address = request.Address,
                    Data = request.Data,
                    Description = request.Description,
                    FinishedData = request.FinishedData,
                    LastModified = request.LastModified,
                    Mark = request.Mark,
                    Materials = request.Materials,
                    Name = request.Name,
                    OldCartonPrice = request.OldCartonPrice,
                    OldPlenkaPrice = request.OldPlenkaPrice,
                    OldPoddonPrice = request.OldPoddonPrice,
                    Organization = request.Organization,
                    Price = request.Price,
                    RelatedOperator = request.RelatedOperator,
                    State = request.State,
                    TakenData = request.TakenData,
                    WeightData = request.WeightData,
                    WhoClosed = request.WhoClosed,
                    WhoTook = request.WhoTook,
                    WhoWeighed = request.WhoWeighed,
                    RelatedOrganizationId = organization.Id,
                };

                await _context.Requests.AddAsync(record, cancellationToken);
                await _context.SaveChangesAsync(cancellationToken);
            return record.Id;
         
        }
    }
}
