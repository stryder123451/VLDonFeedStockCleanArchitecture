using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedStock.Application.Models.Requests.Commands.Delete
{
    public class DeleteRequestCommand : IRequest
    {
        public int Id { get; set; }
    }
}
