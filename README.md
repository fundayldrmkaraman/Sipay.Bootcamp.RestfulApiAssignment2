# Sipay.Bootcamp.RestfulApiAssignment2

Bu haftaki ödevde Dependency Injection kullanarak servislerin eklendiği, Swagger implementasyonu ve global loglama için middleware'ın eklenmiş olduğu, sahte kullanıcı giriş sistemi ve custom bir attribute ile kontrolün yapıldığı bir örnek uygulama mevcuttur.

## Dependency Injection 
Bir sınıfın/nesnenin bağımlılıklardan kurtulmasını amaçlayan ve o nesneyi olabildiğince bağımsızlaştıran bir programlama tekniği/prensibidir. Dependency Injection uygulayarak; bir sınıfının bağımlı olduğu nesneden bağımsız hareket edebilmesini sağlayabilir ve kod üzerinde olası geliştirmelere karşın değişiklik yapma ihtiyacını ortadan kaldırabilirsiniz.

![image](https://github.com/fundayldrmkaraman/Sipay.Bootcamp.RestfulApiAssignment2/assets/108402804/27015508-db3e-4892-b7fa-a0c8e134dfd5)

Dependency Injection uygulamanın avantajları nelerdir ?
•	Bağımlılık oluşturacak nesneleri direkt olarak kullanmak yerine, bu nesneleri dışardan verilmesiyle sistem içerisindeki bağımlılığı minimize etmek amaçlanır. Böylece bağımlılık bulunan sınıf üzerindeki değişikliklerden korunmuş oluruz.
•	Unit testlerin yazımını kolaylaştırırken doğruluğunu da artırır. Yazılım geliştirmedeki en önemli konulardan biri de yazılım içerisinde bulunan componentlerin “loosely coupled” (gevşek bağlı) olmasıdır. Dependency Injection’da bunu sağlayabilen önemli tekniklerden birisidir. Böylece bağımsızlığı sağlanan sınıflar tek başına test edilebilir.

## Middleware
Middlewareler Request/Response Pipeline’ı üzerinde özelleştirilmiş aksiyonlar alınmasını mümkün kılan, bu Pipeline akışının handle edilmesini sağlayan modüler ve etkili classlardır. Bu sınıfları kullanarak controller metodunuza gelen request’leri veya response’ları modify edebilir, header check yapabilir yada authorization kontrollerini kolayca entegre edebiliriz
Middleware ile neler yapılabilir sorusunun cevabı ise:
•	Request’lerin pipelinelar üzerinden spesifik olarak istenilen kontrollerden geçmesi sağlanabilir.
•	Response’ların cache üzerinden türetilmesi sağlanabilir,
•	Uygulama üzerinde merkezi loglama mekanizmaları oluşturabilir,
•	Birazdan üzerinde bahsedeceğimiz Exception Handling için çözümler üretilebilir.
•	Diyelim ki siz gelen requestteki client headerdaki headerın key ve value değerleri kontrol edip ona göre bir response ve içerisinde status code dönmek istiyorsunuz. HeaderCheckMiddleware.cs adında bir middleware oluşturup başarılı bir şekilde kontrolü sağlayabilirsiniz.

![image](https://github.com/fundayldrmkaraman/Sipay.Bootcamp.RestfulApiAssignment2/assets/108402804/b1fb86e4-a959-4ca4-84f9-f94322054634)


Kaynaklar:
•	https://gokhana.medium.com/dependency-injection-nedir-nas%C4%B1l-uygulan%C4%B1r-kod-%C3%B6rne%C4%9Fiyle-44f4b0d576e4
•	https://medium.com/@mustafa.alkan/global-exception-handler-middleware-656e608c5af6
