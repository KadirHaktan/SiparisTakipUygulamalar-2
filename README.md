# SiparisTakipUygulamalar-2
# Çok Katmanlı Mimari ile geliştirilen C# (ASP.NET MVC) uygulaması

# Kullanılan Katmanlar
# Core Katmanı(Diğer katmanlardaki işlemlerin daha temiz yazılması için referans gören katmandır.Framework katmanı da denilebilir)
# Veri Erişim Katmanı
# İş Katmanı
# User Interface(MVC) Katmanı

# Kullanılan Teknolojiler ve frameworkler

# Entity Framework
# Fluent Validation(Validasyon)
# PostSharp(Aspect Oriented Programming yapmak için Cross Cutting Cornces dediğimiz yapıların iş katmanında çağrılırken birbirinden ayrılaştırıp ama yinede ilgili metoda girip işlemlerini gerçekleşebilmesi kullanılan programlama tekniği diyebiliriz.Metodun içine yazmak  yerine Attribute olarak metodun üstüne ekleyerek ilgili işlemin metodun girmesini sağlıyoruz.Bu sayede daha temiz kod yazmış oluyoruz )
# Log4Net(Loglama)
# Microsoft'un Caching kütüphanesi


# Kullanılan başka yapı

# Transactional operasyon yapısı:
# Veritabanım içinde birebir ilişkisi olan tablolar için özellikle İş Katmanında TransactionalAdd ya da Transactional Update gibi metotlar tanımlamış olup örneğin Müşteri tablosundan bir kayıt eklediğimde aynı anda Telefon tabloma da bir kayıt eklemeye çalışıyor olacağım.Ama bir tablo ekleme problemi yaşarsam diğerine de ekleme yapmayıp işlemi tamamen durduracak



