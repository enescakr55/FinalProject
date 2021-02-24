using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün adı hatalı";
        public static string MaintenanceTime = "Bakımdayız";
        public static string ProductsListed ="Ürünler Listelendi";
        public static string CategoryCountError = "Kategori ürün limitini aştınız.";
        public static string ProductUpdated = "Ürün başarı ile güncellendi";
        public static string CategoryLimitExceeded = "Kategori sayısı fazla olduğundan ürün eklenemiyor.";
    }
}
