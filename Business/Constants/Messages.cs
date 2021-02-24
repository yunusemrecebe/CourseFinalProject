using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi!";
        public static string ProductNameInvalid = "Ürün ismi geçersiz!";
        public static string MaintenanceTime = "Sistem Bakımda.";
        public static string ProductsListed = "Ürünler Listelendi.";
        public static string ProductCountOfCategoryError = "Bu kategoride en fazla 10 ürün olabilir!";
        public static string ProductUpdated = "Ürün güncellendi!";
        public static string ProductNameAlreadyExistInDatabase = "Daha önce aynı isimde bir ürün eklenmiş!";
        public static string CategoryCountGreaterThenLimit = "Kategori sayısı limiti aşıldığı için yeni ürün eklenemez!";
    }
}
