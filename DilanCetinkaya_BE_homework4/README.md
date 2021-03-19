( * ) ile işaretlediğim ödevlerin tamamında Controller > Services  > DbContext  yapısı  tasarlanmalıdır.
 (Her madde için ayrı proje oluşturulacak )

1 -)  Singleton -  Transaction - Scoped  kavramlarını açıkça anlaşıldığı bir örnek yapılacak.  

2 -) [( * ) opsiyonel]
	    MiddleWare Loglama yapan bir projemiz yapılacak. Request ve response’lar ayrı ayrı loglanacak.
		Log içeriklerini sizin belirlemenizi istiyorum.  Dosyayı açında anlaşılır şekilde olması önemli. 
		(Bu log ne zaman gelmiş vb sorularına cevap olması gerekiyor. )
        		
		Dosyalar içerisinden arama yaparken;  
		Request.txt ‘den seçtiğim bir request’in response’unu  Response.txt içerisinde kolaylıkla bulabilmeliyim
		
		Request     : Request.txt
		Response    :  Response.txt

3 -) CleanCode dersinde konuştuğumuz tüm maddelerin örneklerini Console Application üzerinde örneklenecek.
	Konu içeriklerine aşağıdaki linklerden ulaşabilirsiniz. Örnekleriniz aynı olmasın.
	https://bilisim.io/2020/04/20/clean-code-principles/
	https://bilisim.io/2020/04/25/clean-code-method-principles/

4 -) [( * ) zorunlu] 
	
	    2 adet controller  Totalde minimum 4 action olacak şekilde ( fazlası da olabilir )bir senaryo oluşturup proje 		    oluşturulacak.
	    Projenize  Swagger eklenecek.
            
5 -) [( * ) zorunlu] 

	    Min 2 controller totalde minimum 4 action olacak şekilde ( fazlası da olabilir ) bir senaryo oluşturulacak.
	    Projede 3. Hafta yaptığımız Generic Repository Pattern uygulanacak.
            Select - Insert - Update - Delete işlemleri yapılması gerekiyor.
	   
6 -) [( * ) Opsiyonel ] 

	     Db üzerinden ,applicationSetting veya txt herhangi birini tercih edebilirsiniz.

	     IP adresi  ve ulaşabileceği controller şeklinde WhiteList oluşturulacak.
			192.168.1.1
				 HomeController 
				 CustomerController
			 192.168.1.2
				  PersonController

	      Request geldiğinde whiteList’e uymayanlar handle edilecek message ve status eklenip geriye dönülebilir.

	
 7 -) Derste işlediğimiz Versionlama tekrar edilecek. QueryString ve  header üzerinden version bilgisini okuyan versiyonları yapılacak. 
      Versiyonlara göre methodlara erişim vs olması gerekiyor.
	 
 8 -) Bu haftaki projemize temize çekilip yeniden yazılacak.  (Test için yaptığımız controller vs kaldırabilirsiniz.)
      JWT ‘de Refresh Token eklenecek.
		
 9 -) X bir iş yapan “Worker Service” oluşturulacak.
      Ayrı bir proje olabilir veya mevcut bir projeye dahil olabilir. 
      Günlük hayatınızda işinize yarayacak bir şey de olabilir ( Örneğin belirli bir lokasyonda son 3 aydır hiç erişmediğiniz klasörlerin listesini veren bir servis )
