using System.Runtime.Serialization;

namespace Business.Constants
{
    public static class Messages
    {
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductListed = "Ürünler listelendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string ProductCountOfCategoryError = "Kategoride ondan fazla ürün olamaz";
        public static string ProductNameAlreadyExists = "Aynı isimde zaten bir ürün var";
        public static string CategoryLimitExceeded = "Kategori limiti aşıldığı için yeni ürün eklenemiyor";
        public static string AuthorizationDenied = "Yetkiniz yok";
        internal static string UserRegistered = "Kullanıcı kaydı başarılı";
        internal static string UserNotFound = "Kullanıcı bulunamadı";
        internal static string PasswordError = "Hatalı parola";
        internal static string SuccessfulLogin = "Giriş başarılı";
        internal static string UserAlreadyExists = "Kullanıcı zaten kayıtlı";
        internal static string AccessTokenCreated = "Access Token oluşturuldu";
    }
}