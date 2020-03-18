using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using NetBook.Business.Dogrulamalar;
using NetBook.Business.Servisler;
using NetBook.DataAccess.Interfaces;
using NetBook.DataAccess.VeriErisim;
using NetBook.Entities;

namespace NetBook.Business.Yonetim
{
    public class KitapManager : YonetimSablonu<Kitap, KitapDAL, KitapValidator>, IKitapService
    {
        public Kitap IdDegerineGoreGetir(int Id)
        {
            return this.Getir(c => c.Id == Id);
        }

        public override Kitap Sil(Kitap entity)
        {
            return base.Sil(entity);
            IKitapHareketService kitapHareketService=new KitapHareketManager();
            kitapHareketService.Sil(c => c.KitapId == entity.Id);
        }
    }
}
