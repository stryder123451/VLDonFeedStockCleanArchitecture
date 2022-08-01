using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedStock.Application.Models.Requests.Commands.Update
{
    public class UpdateRequestCommand : IRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Data { get; set; }
        public string Materials { get; set; }
        public string State { get; set; }
        public string Address { get; set; }
        public int RelatedOrganizationId { get; set; }
        public string RelatedOperator { get; set; }
        public string Organization { get; set; }
        public string Description { get; set; }
        public string TakenData { get; set; }
        public string WeightData { get; set; }
        public string FinishedData { get; set; }
        public string WhoTook { get; set; }
        public string WhoWeighed { get; set; }
        public string WhoClosed { get; set; }
        public string LastModified { get; set; }
        public float Price { get; set; }
        public float OldPoddonPrice { get; set; }
        public float OldCartonPrice { get; set; }
        public float OldPlenkaPrice { get; set; }
        public string Mark { get; set; }
    }
}
