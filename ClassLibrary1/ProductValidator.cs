using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;

namespace ClassLibrary1
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(model => model.Name).NotEmpty();
        }
    }
}
