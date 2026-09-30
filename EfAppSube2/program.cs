using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfAppSube2
{
    internal class program
    {

        static void Main(string[] args)
        {
            //{
            //    var ogr = new Ogrenci { Ad = "Yahya", Soyad = "Değirmenci", Numara = "1283" };
            //    using (var ctx = new OkulDbContext())
            //    {
            //        ctx = new OkulDbContext();
            //        ctx.Ogrenciler.Add(ogr);
            //        int sonuc = ctx.SaveChanges();
            //        Console.WriteLine(sonuc > 0 ? "İşlem Başarılı" : "İşlem Başarısız"); 
            //    }


            //**UPTADE

            //using (var ctx = new OkulDbContext())
            //{
            //    var ogr = ctx.Ogrenciler.Find(2);
            //    ogr.Numara = "789";
            //    ctx.Entry(ogr).State=EntityState.Modified;
            //}

            //**SELECT

            //using (var ctx = new OkulDbContext())
            //{
            //    var lst = ctx.Ogrenciler.ToList();
            //    foreach (var item in lst) 
            //    {
            //        Console.WriteLine(item.ToString());

            //    }
            //}

            //**

            using (var ctx = new OkulDbContext())
            {
                var ogr = ctx.Ogrenciler.Find(2);
                if (ogr != null)
                {
                    ctx.Ogrenciler.Remove(ogr);
                }
                ctx.SaveChanges();
            }
        }
    }
}


