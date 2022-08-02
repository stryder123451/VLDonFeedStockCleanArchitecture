using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedStock.Application.Models.Requests.Queries.GetRequestList
{
    public class GetRequestListQuery : IRequest<GetRequestListClassViewModel>
    {
        public int Id { get; set; }
        public string State { get; set; }
    }
}
