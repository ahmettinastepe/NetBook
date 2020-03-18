using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetBook.DataAccess.Context;
using NetBook.DataAccess.Interfaces;
using NetBook.Entities;

namespace NetBook.DataAccess.VeriErisim
{
    public class BarkodDAL:EntityAnaSablon<Barkod, NetBookContext>,IBarkodDal
    {
    }
}
