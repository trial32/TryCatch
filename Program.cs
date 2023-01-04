// See https://aka.ms/new-console-template for more information


/* try
{
Console.WriteLine("Bir değer giriniz: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Girdiğiniz değer: " + x);
}
catch (Exception ex){

Console.WriteLine("Hata kodu : " + ex.Message.ToString());

}
finally
{
    
Console.WriteLine("İşlem tamamlandı.. ");
}  */

try
{
   // int n = int.Parse(null);
    //int n = int.Parse("null");
    int n = int.Parse("5555555555555555555555555");
}
catch (ArgumentNullException exception)
{
   Console.WriteLine ("Boş değer girdiniz.");
   Console.WriteLine(exception); 
}
catch (OverflowException exception) {

   Console.WriteLine ("Yuksek bir değer girdiniz...");
   Console.WriteLine(exception); 
}

catch (FormatException exception) {

   Console.WriteLine ("Yanlış format girdiniz.");
   Console.WriteLine(exception); 
}
finally {

   Console.WriteLine ("İşlem tamamlandi");
   
}