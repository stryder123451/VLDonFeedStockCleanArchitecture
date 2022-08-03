using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedStock.Application.Models.Requests.Queries.GetRequestDetails
{
    public class GetRequestValidator : AbstractValidator<GetRequest>
    {
        public GetRequestValidator()
        {
            RuleFor(c=>c.Id).NotEmpty();
        }
    }
}
