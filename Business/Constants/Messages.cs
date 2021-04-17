using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public class Messages
    {
        public static string BrandAdded = "Marka Eklendi";
        public static string BrandDeleted = "Marka silindi";
        public static string BrandUpdated = "Marka güncellendi";
        public static string BrandListed = "Markalar listelendi";
        public static string BrandNameInvalid = "Marka ismi geçersiz";

        public static string CarAdded = "Araba Eklendi";
        public static string CarDeleted = "Araba silindi";
        public static string CarUpdated = "Araba güncellendi";
        public static string CarListed = "Arabalar listelendi";
        public static string CarNameInvalid = "Araba ismi geçersiz";

        public static string ColorAdded = "Renk Eklendi";
        public static string ColorDeleted = "Renk silindi";
        public static string ColorUpdated = "Renk güncellendi";
        public static string ColorListed = "Renkler listelendi";
        public static string ColorNameInvalid = "Renk ismi geçersiz";
        public static string ColorNotDeleted = "Renk silinemedi";

        public static string MaintenanceTime = "Sistem bakımda";
        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";

        public static string RentalAdded = "Araç kiralandı";
        public static string RentalDeleted = "Kiralanan araç verileri silindi";
        public static string RentalUpdated = "Kiralanan araç verileri güncellendi";
        public static string DateInvalid = "Araç kiralanamaz";

        public static string CustomerAdded = "Müşteri Eklendi";
        public static string CustomerDeleted = "Müşteri Silindi";
        public static string CustomersListed = "Müşteriler Listelendi";
        public static string CustomerListed = "Müşteri Listelendi";
        public static string CustomerUpdated = "Müşteri Güncellendi";

        public static string UserAdded = "Kullanıcı Eklendi";
        public static string UserDeleted = "Kullanıcı Silindi";
        public static string UsersListed = "Kullanıcılar Listelendi";
        public static string UserListed = "Kullanıcı Listelendi";
        public static string UserUpdated = "Kullanıcı Güncellendi";

        public static string CreditCardAddedSuccessfully = "Kredi kaınız başarıyla kaydedilmiştir.";
        public static string CreditCardDeletedSuccessfully = "Kredi kartınız sistemden başarı ile silinmiştir.";
        public static string GetCreditCardByCardIdSuccessfully = "Kart detayları başarıyla getirildi.";
        public static string GetAllCreditCardsSuccessfully = "Tüm kredi kartları başarıyla getirildi.";
        public static string GetUserCardListSuccessfully = "Kullanıcının tüm kartları başarıyla getirildi.";
        public static string GetCreditCardByCardTypeIdSuccessfully = "Kart tipine göre karlar başarı ile listelendi.";

       
        public static string CardTypeAddedSuccessfully = "Kart tipi başarı ile eklendi.";
        public static string CardTypeUpdatedSuccessfully = "Kart tipi başarıyla güncellendi.";
        public static string CardTypeDeletedSuccessfully = "Kart tipi başarıyla silindi.";
        public static string GetAllCardTypesSuccessfully = "Tüm kart tipleri başarı ile listelendi";
        public static string GetTypeByIdSuccessfully = "Kart tipi detayları başarıyla listelendi.";
        public static string SelectedCardGetsSuccessfully = "Müşterinin 'öncelikli' olarak tanımlanmış kartı başarı ile getirildi. ";

       
        public static string PaymentSuccessfull = "Ödeme başarı ile tamamlandı.";
        public static string PaymentError = "Ödeme sırasında bir hata oluştu";
    }
}
