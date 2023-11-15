internal class Program
{   
    private static void Main(string[] args)
    {
        //See https://aka.ms/new-console-template for more information
        Console.WriteLine("Hello, World!");

        //forOrnegi();
        //kacisİfadeleriOrnegi();
        //tersSlashKullanimiOrnegi();
        //ortuluDegiskenTanımlamaOrnegi();
        //dizeDegismezleriOrnegi();
        //tek/çift
        //ifKullanimiOrnegi();       
        //mutlakDegerOrnegi();        
        //karakterOrnegi();

        Console.ReadKey();

        static void forOrnegi()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            for (int i = 10 ; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
        }

        static void kacisİfadeleriOrnegi()
        {
            string ifade = "Btk \nAkademi \tProgramlama \nDersleri \tÖrnekleri";
            Console.WriteLine(ifade);
        }

        static void tersSlashKullanimiOrnegi()
        {
            string ifade = "C:\\user\\mkuneroglu"; //ters slash kullanımına dikkat etmek gerek 
                                                   //eğer ekranda ters slaş kullanımlasını istersek \\ iki ters slash kullanmak gerek
            string ifade2 = @"C:\user\mkuneroglu"; // diğer bir yöntem çift tırnaktan önce @ işareti 
            Console.WriteLine(ifade + "\n" + ifade2);
        }

        static void ortuluDegiskenTanımlamaOrnegi()
        {
            var ifade = Console.ReadKey(); //var örtülü değişken tanımlaması için kullanılır
            Console.WriteLine();
            Console.WriteLine(ifade.Key); // nokta operatrü ile yapılabilecek işler örneği
            
            Console.WriteLine(ifade.KeyChar);
        }

        static void dizeDegismezleriOrnegi()
        {
            var ifade = "    Merhaba programlama dünyası     .";
            Console.WriteLine(ifade);
            Console.WriteLine(ifade.ToLower());
            Console.WriteLine(ifade.ToUpper());
            Console.WriteLine(ifade.Length);
            Console.WriteLine(ifade.TrimStart());
            Console.WriteLine(ifade.TrimEnd());
            Console.WriteLine(ifade.Trim());
            Console.WriteLine(ifade[10]);
            Console.WriteLine(ifade[12]);
            Console.WriteLine(ifade[ifade.Length - 1]);
            Console.WriteLine(ifade[^1]);//yukarıdaki satır yerine kullanılabilir
        }

        static void ifKullanimiOrnegi()
        {
            Console.WriteLine("Bir sayı giriniz");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine($"{a} çift bir sayıdır");
            }
            else
            {
                Console.WriteLine($"{a} tek bir sayıdır");
            }
        }

        static void mutlakDegerOrnegi()
        {
            Console.WriteLine("Bir sayı giriniz");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 0)
            {
                Console.WriteLine($"|{n}| = {n * -1}");
            }
            else
            {
                Console.WriteLine($"|{n}| = {n}");
            }
        }

        static void karakterOrnegi()
        {
            Console.WriteLine("Bir karakter giriniz");
            var k = (char)Console.Read();
            if (char.IsDigit(k))
            {
                Console.WriteLine("Rakamdır.");
            }

            else if (char.IsLower(k))
            {
                Console.WriteLine("Küçük karakter");
            }
            else if (char.IsUpper(k))
            {
                Console.WriteLine("Büyük karakter");
            }
            else
            {
                Console.WriteLine("tanımsız");
            }
        }
    }
}