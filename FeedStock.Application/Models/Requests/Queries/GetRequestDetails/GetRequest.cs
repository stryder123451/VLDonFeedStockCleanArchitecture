using AutoMapper;
using FeedStock.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedStock.Application.Models.Requests.Queries.GetRequestDetails
{
    public class GetRequest : IRequest<Request>
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

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Request, GetRequest>()
                .ForMember(requestVM => requestVM.Id, x => x.MapFrom(req => req.Id))
                .ForMember(requestVM => requestVM.Description, x => x.MapFrom(req => req.Description))
                .ForMember(requestVM => requestVM.State, x => x.MapFrom(req => req.State))
                .ForMember(requestVM => requestVM.Address, x => x.MapFrom(req => req.Address))
                .ForMember(requestVM => requestVM.Materials, x => x.MapFrom(req => req.Materials))
                .ForMember(requestVM => requestVM.Data, x => x.MapFrom(req => req.Data))
                .ForMember(requestVM => requestVM.TakenData, x => x.MapFrom(req => req.TakenData))
                .ForMember(requestVM => requestVM.WeightData, x => x.MapFrom(req => req.WeightData))
                .ForMember(requestVM => requestVM.FinishedData, x => x.MapFrom(req => req.FinishedData))
                .ForMember(requestVM => requestVM.LastModified, x => x.MapFrom(req => req.LastModified))
                .ForMember(requestVM => requestVM.Name, x => x.MapFrom(req => req.Name))
                .ForMember(requestVM => requestVM.OldCartonPrice, x => x.MapFrom(req => req.OldCartonPrice))
                .ForMember(requestVM => requestVM.OldPlenkaPrice, x => x.MapFrom(req => req.OldPlenkaPrice))
                .ForMember(requestVM => requestVM.OldPoddonPrice, x => x.MapFrom(req => req.OldPoddonPrice))
                .ForMember(requestVM => requestVM.WhoTook, x => x.MapFrom(req => req.WhoTook))
                .ForMember(requestVM => requestVM.WhoWeighed, x => x.MapFrom(req => req.WhoWeighed))
                .ForMember(requestVM => requestVM.WhoClosed, x => x.MapFrom(req => req.WhoClosed))
                .ForMember(requestVM => requestVM.Mark, x => x.MapFrom(req => req.Mark))
                .ForMember(requestVM => requestVM.Price, x => x.MapFrom(req => req.Price))
                .ForMember(requestVM => requestVM.RelatedOperator, x => x.MapFrom(req => req.RelatedOperator))
                .ForMember(requestVM => requestVM.RelatedOrganizationId, x => x.MapFrom(req => req.RelatedOrganizationId))
                .ForMember(requestVM => requestVM.Organization, x => x.MapFrom(req => req.Organization));
               


        }
    }
}
