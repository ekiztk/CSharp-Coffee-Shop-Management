# C# Kafe Yönetim Programı (Coffe Shop Management) 


## Program Özeti
Program, bir kafe yönetmek için gerekli olan temel işlevlerin bilgisayar ile gerçekleştirilmesine olanak tanır.

## Program Özellikleri

### Modüller

####  Siparişler
- Masa sayısı isteğe bağlı değişebilir.
- Her masa için sipariş açılabilir.
- Her masa için aynı anda sadece bir sipariş açık olabilir.
- Her masa için siparişi açan garson ismi belirtilir.
- Her masa için Sipariş Düzenle butonu ile ek pencere açılır.
- Sipariş düzenlenirken, ürünler kategoriye göre getirilir ve siparişe ait, teslim edilen ya da edilmeyen bütün ürünler bir liste halinde sunulur.
- Sipariş kapatılabilmesi için bütün sipariş edilen ürünler teslim edilmiş olmalıdır.
- Sipariş kapatılırken bütün teslim edilmiş siparişler listelenir, toplam fiyat ve ödemeyi alan garson gösterilir.
- Her 10 saniyede bir sipariş verileri otomatik olarak veri tabanından alınarak güncellenir.

####  Mutfak
- Bütün hazır olmayan siparişler listelenir.
- Hazırlanan siparişler,  servise hazır olarak belirtilebilir.
- Her 10 saniyede bir sipariş verileri otomatik olarak veri tabanından alınarak güncellenir.

####  Personel
- Çalışanlar kendi sosyal güvenlik numarası, isim , rol bilgilerini görebilir ve kendi şifrelerini değiştirebilir.

#### Raporlar
- Bütün teslim edilen siparişler; sipariş numarası, sipariş tarihi, teslim eden garson, ürün fiyatı ve ürün isimleri ile listelenir.
- Toplam sipariş adedi ve adisyon miktarı gösterilir.
- Siparişler günlük,haftalık ya da aylık şeklinde filtrelenebilir.

### Ek Özellikler
- Çalışanlar sosyal güvenlik numaraları ve şifreleri ile programa giriş yapmalıdır.
- Çalışanlar kendi bilgilerini görebilir ve kendi şifrelerini değiştirebilir.
- Her çalışan kendi rolüne özel tanımlanmış modüllere erişebilir.
- Bir siparişi sadece o siparişi açan garson güncelleyebilir.
- Çalışanlar, roller ve ürünler veri tabanına manuel eklenmelidir.

## Program Teknik Özellikler
- C#
- C# Events
- C# Delegates
- C# N-Tier Architecture
- Entity Framework 6
- Windows Forms
- User Controls
- Microsoft SQL Server
- SQL Database


## Program UML Diyagramları

### Business UML Diyagram
![BusinessUMLDiagram](https://raw.githubusercontent.com/ekiztk/CSharp-Coffe-Shop-Management/main/UMLDiagrams/BusinessUMLDiagram.svg "BusinessUMLDiagram")

### Database UML Diyagram
![DatabaseUMLDiagram](https://raw.githubusercontent.com/ekiztk/CSharp-Coffe-Shop-Management/main/UMLDiagrams/DatabaseUMLDiagram.svg "DatabaseUMLDiagram")

### Entities UML Diyagram
![EntitiesUMLDiagram](https://raw.githubusercontent.com/ekiztk/CSharp-Coffe-Shop-Management/6f96429105f07ef213c6c95c1a06a5524c6210d8/UMLDiagrams/EntitiesUMLDiagram.svg "EntitiesUMLDiagram")

## Kurulum
- Proje Çözümünü açın.
- App.config dosyasını açın ve connectionString="Server=DESKTOP-O58IPK0;...
kısmındaki DESKTOP-O58IPK0 database adını kendi database adınız ile değiştirin.
- FrmLogin formunun kod kısmını açın.
- Aşağıdaki kod bloğunu aktif ederek programı çalıştırın.(Entity Framework 6 ve Microsoft SQL kullanılmıştır.)
```
//-----------Database Oluşturmak-----------
//CoffeShopDBContext c = new CoffeShopDBContext();
//c.Database.CreateIfNotExists();
//-----------------------------------------
```
- Not: Programda kullanılan hazır veri tabanı [Ready Database](https://github.com/ekiztk/CSharp-Coffe-Shop-Management/tree/main/Ready%20Database) klasöründe mevcuttur.
