using FluentValidation;
using MyMusic.Api.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMusic.Api.Validators
{
        public class SaveArtistResourceValidator : AbstractValidator<SaveArtistResource>
        {
            public SaveArtistResourceValidator()
            {
                RuleFor(a => a.Name)
                    .NotEmpty()
                    .MaximumLength(50);
            }
        }
    }

