using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace Mobileshop.Models
{
    public class PhonesDbInitializer:DropCreateDatabaseAlways<MobileContext>
    {
        protected override void Seed(MobileContext db)
        {
            db.Phones.Add(new Phone { Price = 1399,Producent = "Samsung",Model = "Galaxy note 9 ",Colors = "Green diamond,Space grey,Pink gold",Diagonal=6.9});
            db.Phones.Add(new Phone { Price = 999, Producent = "Apple", Model = "Iphone XR ", Colors = "Blue,Black,Pink gold",Diagonal=6.1});
            db.Phones.Add(new Phone { Price = 450, Producent = "Xiaomi", Model = "Pocophone F1 ", Colors = "Grey, Blue Sky",Diagonal=6.3 });
            db.Phones.Add(new Phone { Price = 1199, Producent = "Huawei", Model = "P 20 Pro ", Colors = "Green ,Blue,Pink gold",Diagonal = 6.7 });
            db.Phones.Add(new Phone { Price = 999, Producent = "Google", Model = "Pixel 3 ", Colors = "Orange ,Blue,White", Diagonal = 5.9 });
            base.Seed(db);
        }   
    }
}