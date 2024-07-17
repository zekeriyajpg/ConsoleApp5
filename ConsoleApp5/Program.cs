Console.Write("Lütfen bir sayı giriniz : ");

int say = Convert.ToInt32(Console.ReadLine());

if (say > 10)
{
    Console.WriteLine("sayı 10 dan büyük");
     if (say % 2 ==0)
     {
        Console.WriteLine("sayı çift");

     }



}
else
{

    Console.WriteLine("sayı 10 dan büyük değil ve tek "); // burda else kullanmamım sebebi kullanıcının hangi sayıyı gireceğini bilemememiz
}

Console.ReadLine();