using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FluentValidation;
using NetBook.DataAccess.Interfaces;

namespace NetBook.Business.Araclar
{
    public class DogrulamaAraci
    {
        public bool Dogrula(IValidator validator, IEntity entity)
        {
            bool sonuc = true;

            var dogrulamaKontrol = validator.Validate(entity);
            if (!dogrulamaKontrol.IsValid)
            {
                string message = null;
                foreach (var error in dogrulamaKontrol.Errors)
                {
                    message += error.ErrorMessage + "\n";
                }

                MessageBox.Show(message);
                sonuc = false;
            }
            return sonuc;
        }
    }
}
