using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using NetBook.DataAccess.Context;
using NetBook.DataAccess.Interfaces;
using NetBook.Entities;

namespace NetBook.DataAccess.VeriErisim
{
   public class KitapDAL :EntityAnaSablon<Kitap, NetBookContext>, IKitapDal
    {
      
    }
}
