using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using NetBook.Entities;

namespace NetBook.Business.Dogrulamalar
{
    public class KitapValidator:AbstractValidator<Kitap>
    {
        public KitapValidator()
        {
            RuleFor(c => c.KitapKodu).NotEmpty().WithMessage("Kitap Kodu alanı boş geçilemez.");
            RuleFor(c => c.KitapAdi).NotEmpty().WithMessage("Kitap Adı alanı boş geçilemez.");
            RuleFor(c => c.YazarId).NotEmpty().WithMessage("Yazar seçim alanı boş geçilemez.");
        }
    }
}
