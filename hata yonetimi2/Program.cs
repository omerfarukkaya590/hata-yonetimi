using System;

namespace hata_yonetimi2
{
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{Console.WriteLine("Bir sayı giriniz:");
            //int sayı =Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Girmiş oldupunuz sayı şudur:" + sayı);
            //}
            //catch(Exception ex)
            //{
            //Console.WriteLine("Hata: "+ ex.Message.ToString());
            //}
            //finally
            //{
            //    Console.WriteLine("İşlem tamamlandı.");
            //}
            try
            {
                 //int a=int.Parse("test");
                 //int a =int.Parse(null);
                 int a= int.Parse("-20000000000");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Boş değer girdniz.");
                Console.WriteLine(ex);
            }
            catch (FormatException ex)  
            {
                Console.WriteLine("Veri tipi uygun değil.");
                Console.WriteLine(ex);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("Çok küçük ya da çok büyük değer girdniz.");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("İşlem başarıyla tamamlandı.");
            }
        }
    }
}
