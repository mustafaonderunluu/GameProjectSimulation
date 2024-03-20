# GameProject

GameProject
Bu proje, bir oyun projesinin temel altyapısını oluşturan bir C# uygulamasını içerir. Temel amacı, oyun oyuncularının yönetimini sağlamak için bir mikro hizmet yapısını örneklemektir.

Proje Yapısı
Proje, aşağıdaki bileşenleri içerir:

Gamer: Oyuncu sınıfı, oyun platformunda kullanıcıları temsil eder. Özellikler arasında ID, ad, soyad, kimlik numarası ve doğum yılı bulunur.

IGamerService: Oyuncu hizmetlerini tanımlayan bir arayüzdür. GamerManager bu arayüzü uygular ve Add, Update ve Delete gibi temel işlevleri içerir.

GamerManager: Oyuncu hizmetlerini uygulayan sınıftır. Bir oyuncunun eklenmesi, güncellenmesi veya silinmesi gibi işlevleri gerçekleştirir. Ayrıca bir IUserValidationService'ye ihtiyaç duyar.

IUserValidationService: Kullanıcı doğrulamasını tanımlayan bir arayüzdür. Bu arayüzü uygulayan sınıflar, kullanıcı doğrulama işlemlerini gerçekleştirir.

UservalidationManager: IUserValidationService arayüzünü uygulayan bir sınıftır. Kullanıcı doğrulama işlevini gerçekleştirir ve örnek bir doğrulama mantığı içerir.

NewEStateUserValidationManager: IUserValidationService arayüzünü uygulayan başka bir sınıftır. Burada, örnek bir doğrulama mantığı sağlanır.
