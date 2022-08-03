using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedStock.Application.Models.Requests.Commands.Create
{
    public class CreateRequestCommandValidator: AbstractValidator<CreateRequestCommand>
    {
        public CreateRequestCommandValidator()
        {
            RuleFor(c => c.Address).NotEmpty();
            RuleFor(c => c.Materials).NotEmpty();
            RuleFor(c => c.RelatedOperator).NotEmpty();
            RuleFor(c => c.RelatedOrganizationId).NotEmpty();
            RuleFor(c => c.Organization).NotEmpty();
        }
    }
}
