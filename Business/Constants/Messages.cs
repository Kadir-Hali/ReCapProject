using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class SystemMessages
    {
        public static string MaintenanceTime = "Sistem bakımda";
        public static string AuthorizationDenied = "Yetkiniz yok!";
    }
    public static class CarMessages
    {
        public static string CarAdded = "Araç eklendi";
        public static string CarDeleted = "Araç silindi";
        public static string CarUpdated = "Araç güncellendi";
        public static string CarNameInvalid = "Araç adı yada araç fiyatı geçersiz";
        public static string CarsListed = "Araçların tümü listelendi";
        public static string CarByIdListed = "Seçilen araç listelendi";
        public static string CarsBrandListed = "Araçlar markalarına göre listelendi";
        public static string CarsColorListed = "Araçlar renklerine göre listelendi";
        public static string CarDetailsListed = "Seçilen aracın detayları listelendi";
        public static string CarByDailyPriceListed = "Günlük kiralama fiyatlarına göre filtrelenip listelendi.";
    }

    public static class BrandMessages
    {
        public static string BrandAdded = "Marka eklendi";
        public static string BrandDeleted = "Marka silindi";
        public static string BrandUpdated = "Marka güncellendi";
        public static string BrandsListed = "Markaların tümü listelendi";
        public static string BrandByIdListed = "Seçilen marka'ya ait tüm araçalar listelendi";
    }

    public static class ColorMessages
    {
        public static string ColorAdded = "Renk eklendi";
        public static string ColorDeleted = "Renk silindi";
        public static string ColorUpdated = "Renk güncellendi";
        public static string ColorsListed = "Renklerin tümü listelendi";
        public static string ColorByIdListed = "Seçilen renkli araçlar listelendi";
        public static string ColorsBrandListed = "Araçlar markalarına göre listelendi";
    }
    public static class UserMessages
    {
        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string UserUpdated = "Kullanıcı güncellendi";
        public static string UsersListed = "Kullanıcıların tümü listelendi";
        public static string UserByIdListed = "Seçilen kullanıcı listelendi";
    }
    public static class CustomerMessages
    {
        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomerDeleted = "Müşteri silindi";
        public static string CustomerUpdated = "Müşteri güncellendi";
        public static string CustomersListed = "Müşterilerin tümü listelendi";
        public static string CustomerByIdListed = "Seçilen müşteri listelendi";
    }
    public static class RentalMessages
    {
        public static string RentalAdded = "Kiralama işlemi eklendi";
        public static string RentalDeleted = "Kiralama işlemi silindi";
        public static string RentalUpdated = "Kiralama işlemi güncellendi";
        public static string RentalInvalid = "Araç teslim alınmadığından dolayı kiralanamaz.!";
        public static string RentalsListed = "Kiralama işlemlerinin tümü listelendi";
        public static string RentalByIdListed = "Seçilen Kiralama işlemi listelendi";
    }
    public static class CarImagesMessages
    {
        public static string CarImageAdded = "Araç'a resim eklendi";
        public static string CarImageDeleted = "Araç'ın resmi silindi";
        public static string CarImageUpdated = "Araç'ın resmi güncellendi";
        public static string CarImagesListed = "Araç resimlerinin tümü listelendi";
        public static string CarImageByIdListed = "Seçilen araç'ın resmi listelendi";
        public static string CarImageLimitExceded = "Görsel limitini aştığınız için daha fazla görsel eklenemiyor.";
    }
    public static class AuthMessages 
    {
        public static string UserRegistered = "Kayıt oldu.";
        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string PasswordError = "Parola hatası.";
        public static string SuccessfulLogin = "Başarılı giriş.";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu.";
        public static string UserAlreadyExists = "Kullanıcı zaten var."
    }
}
