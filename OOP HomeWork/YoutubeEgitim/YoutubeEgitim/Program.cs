

using System.Xml;

public class Program
{
    public static void Main(string[] args)
    {
        //interface:İş yapan operasyonlarin sadece imza seviyesinde yazarak yazilimda bagimliligi korumak adina yapilan calismadir.
        //

        //IOC CONTAINER
        CustomerManager customerManager = new CustomerManager(new Customer(),new TeacherCreditManager());
        customerManager.GiveCredit();
































        //int sayi1 = 10;
        //int sayi2 = 20;
        //sayi1 = sayi2;
        //sayi2 = 100;

        //Console.WriteLine(sayi1);

        //int[] sayilar1 = new int[] { 1, 2, 3 };
        //int[] sayilar2 = new int[] { 10, 20, 30 };

        //sayilar1 = sayilar2;

        //sayilar2[0] = 1000;

        //Console.WriteLine(sayilar1[0]);


        //CreditManager creditManager = new CreditManager();
        //creditManager.Calculate();
        //creditManager.Calculate();
        //creditManager.Save();

        //Customer customer = new Customer(); //Örnegini oluşturmak , instance olusturmak, instance creation 
        //customer.Id = 1;
        //customer.City = "ANKARA";

        //CustomerManager customerManager = new CustomerManager(customer);
        //customerManager.Save();
        //customerManager.Delete();

        //Company company = new Company();
        //company.TaxNumber = "1000000";
        //company.CompanyName = "Arçelik";
        //company.Id = 100;

        //CustomerManager customerManager2 = new CustomerManager(new Person());
        //Person person = new Person();
        //person.NationaIdentity = "12454";


        //Customer c1 = new Customer();
        //Customer c2 = new Person();
        //Customer c3 = new Company();

    }

}

public class CreditManager//operations
{
    public void Calculate(int creditType)
    {
        //sonar qube
        if (creditType ==1)//esnaf
        {

        }
        if (creditType == 2)//ögretmen
        {

        }
        Console.WriteLine("Hesaplandı");
    }

    public void Save()
    {
        Console.WriteLine("Kredi Verildi...");
    }
}

abstract class BaseCreditManager : ICreditManager
{//Tamamlanmamiş için doldurulmul methodlar yazilabilir.
    public abstract void Calculate();

    public virtual void Save()
    {
        Console.WriteLine("Kaydedildi.");
    }
}
interface ICreditManager
{
    void Calculate();
    void Save();
}

class TeacherCreditManager :BaseCreditManager, ICreditManager//implements
{
    public override void Calculate()
    {
        //Hesaplamalar.
        Console.WriteLine("Ögretmen Kredisi Hesaplandı");
    }
    public override void Save()
    {
        //
        base.Save();
        //
    }
    

}

class MilitaryCreditManager :BaseCreditManager, ICreditManager
{
    public override void Calculate()
    {
        Console.WriteLine("Asler Kredisi Hesaplandı");
    }

   
}
//SOLİD NEDİR
//Bir class sadece bir iş yapmali.
public class Customer//özellikler properts
{
    public Customer()
    {
        Console.WriteLine("Müsteri Nesnesi Baslatildi.");
    }
    public int Id { get; set; }
    public string City { get; set; }
    
}

public class Company:Customer
{
    public string CompanyName { get; set; }
    public string TaxNumber { get; set; }

}

public class Person:Customer
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string NationaIdentity { get; set; }

}
//Katmanli Mimariler
class CustomerManager
{
    ICreditManager _creditManager;

    private Customer _customer;
    public CustomerManager(Customer customer,ICreditManager creditManager)
    {
        _customer = customer;
        _creditManager = creditManager;
    }
    public void Save()
    {
        Console.WriteLine("Müsteri Kayit Edildi..." );
    }
    public void Delete()
    {
        Console.WriteLine("Müsteri silindi");
    }

    public void GiveCredit()
    {
        _creditManager.Calculate();
        Console.WriteLine("Kredi Verildi");
    }


}