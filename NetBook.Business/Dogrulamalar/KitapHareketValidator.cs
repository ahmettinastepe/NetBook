﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using NetBook.Entities;

namespace NetBook.Business.Dogrulamalar
{
    public class KitapHareketValidator:AbstractValidator<KitapHareket>
    {
        public KitapHareketValidator()
        {
            
        }
    }
}
