using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetBook.Business.Dogrulamalar;
using NetBook.Business.Servisler;
using NetBook.DataAccess.VeriErisim;
using NetBook.Entities;

namespace NetBook.Business.Yonetim
{
    public class AdresManager : YonetimSablonu<Adres, AdresDAL, AdresValidator>, IAdresService
    {
    }
}
