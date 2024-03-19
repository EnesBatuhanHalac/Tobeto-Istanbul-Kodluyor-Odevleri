//inheritance -1

//Burada bir Hayvan Sınıfım var ve bu sınıfı kopek ve Tavsan sınıfına miras verdim.Yani Hayvan sınıfım Base class Kopek ve Tavsan classlarim sub class

using OOP2;

Tavsan tavsan = new Tavsan();
tavsan.Name = "Tahir";
tavsan.Renk = "Beyaz";
tavsan.Id = 1;
tavsan.Voice = "vıcdsfk";

Kopek kopek = new Kopek();
kopek.Id = 1;
kopek.Name = "Karabaş";
kopek.Türü = "Golden";
kopek.Voice = "Hav Hav";
kopek.GetName(kopek.Name);


// Inheritance - 2
// 
//  Burada Base class olarak bir User Tanımladım ve Bu userden Student ve Teacher olarak 2 sub class'a miras verdim.

Teacher teacher = new Teacher();
teacher.Id = 1;
teacher.Name = "Enes";
teacher.LastName = "Halac";
teacher.UserName = "ehalac";
teacher.Password = "A12B2544";
teacher.Age = 29;
teacher.Field = "ComputerEngineer";
teacher.Salary = 58.250;


Student student = new Student();

student.Id = 1;
student.Name = "Enes";
student.LastName = "Halac";
student.UserName = "ehalac";
student.Password = "A12B2544";
student.Age = 29;
student.Field = "ComputerEngineer";
student.ClassNumber = "25/B";


// Inheritance -3
//Burada Araba Base classindan Bazı ArabaMarkaları Classlarina miras verdim.

Audi audi = new Audi();
audi.Id = 1;
audi.BrandName = "Audi";
audi.TaxtAYear = 2800.25;
audi.Model = "A1";
audi.Color = "Black";
audi.DoorNumber = 2;
audi.HorsePower = 1200;


Renault renault = new Renault();
renault.Id = 1;
renault.TaxtAYear = 1500.25;
renault.Model = "Megane";
renault.Color = "Black-White";
renault.DoorNumber = 4;
renault.HorsePower = 800;



//Polymorphism Çok Biçimlilik
//Burada insan classindan miras alarak selamVer Methodunu override ettim.
Human human = new Human();
human.SelamVer();

Turko turko = new Turko();
turko.SelamVer();

Fransız fransız = new Fransız();
fransız.SelamVer();


//Polymorphizm-2
//burada Hayvanlara Farklı sesler ekledim.
tavsan.VoiceAnimal();
kopek.VoiceAnimal();


//ABSTRACK VE INTERFACE ARASINDAKI FARKLAR

//ABSTRACT CLASS STATIK UYELER ICEREBILIR INTERFACE ICERMEZ.BIR CLASS SADECE BIR ADET ABSTRACT CLASS MIRAS ALABILIR AMA BIRDEN COK INTERFACE MIRAS ALABILIR.ABSTRACT CLASSLAR METOT IMZALARI VE METOT BODY'SINI ICERIR AMA INTERFACE
//SADECE METOT IMZALARINI ICERIR.INTERFACE IMPLEMENTE EDILMEK ZORUNDADIR.



//Encapsulation kullaniciya vermek istemedigimiz bir veriyi private olarak kullanabilmeyi saglar.Lakin private oldugu zaman veriyi biz de kullanamayiz buna metotlar ve propertyler ile çözüm saglariz ben burada fransiz Name'inde metot ile çözüm sagladim..
//Burada private bir field'a setName metodu ile deger atadim ve getName metodu ile veriyi aldim;
fransız.SetName("Dennis");
Console.WriteLine(fransız.GetName());


//Generic TYPE OLARAK HAYVAN CLASSİNA  Name filed'ına <T> veri tipini verdim ver diger miras alan classlarda bunu <string> olarak belirttim.