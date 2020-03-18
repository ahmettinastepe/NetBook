using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using NetBook.Entities;

namespace NetBook.Business.Dogrulamalar
{
    public class UyeValidator:AbstractValidator<Uye>
    {
        public UyeValidator()
        {
            RuleFor(c => c.SinifId).NotEmpty().WithMessage("Sınıf seçimi yapmak zorunludur.");
        }
    }
}
