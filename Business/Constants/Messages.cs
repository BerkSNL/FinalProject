using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz!";
        public static string MaintenanceTime = "Sistem bakımda!";
        public static string ProductsListed = "Ürünler listelendi.";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir!";
        public static string ProductNameAlreadyExists = "Bu isimde bir ürün zaten var!";
        internal static string CategoryLimitExceeded = "Kategori sayısı 15'i aştığı için sisteme yeni ürün eklenemez!";
    }
}
