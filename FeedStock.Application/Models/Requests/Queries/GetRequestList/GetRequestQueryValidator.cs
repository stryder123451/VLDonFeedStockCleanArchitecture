using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedStock.Application.Models.Requests.Queries.GetRequestList
{
    public class GetRequestQueryValidator : AbstractValidator<GetRequestListQuery>
    {
        public GetRequestQueryValidator()
        {
            RuleFor(c => c.Id).NotEmpty();
        }
    }
}
