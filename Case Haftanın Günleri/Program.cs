// Günü yazınca Haftanın kaçıncı günü olduğunu söylüyor
Console.Write("Gün adı giriniz: ");
string GunAd = Console.ReadLine().ToLower();
switch (GunAd)
{ 
    case "pazartesi":
        Console.WriteLine("Haftanın 1. Günü");
        break;
    case "salı": 
        Console.WriteLine("Haftanın 2. Günü"); 
        break;
    case "çarşamba": 
        Console.WriteLine("Haftanın 3. Günü"); 
        break;
    case "perşembe": 
        Console.WriteLine("Haftanın 4. Günü"); 
        break;
    case "cuma": 
        Console.WriteLine("Haftanın 5. Günü"); 
        break;
    case "cumartesi": 
        Console.WriteLine("Haftanın 6. Günü"); 
        break;
    case "pazar": 
        Console.WriteLine("Haftanın 7. Günü"); 
        break;
    default: Console.WriteLine("Böyle bir gün var mı sence(soruyorum sadece)"); 
        break;
}    



