namespace DosyaIslemleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string yazi = "merhaba \"dünya\"";

            //var klasorler = System.IO.Directory.GetDirectories(@"C:\Projects\yzl-8436");

            //while(true)
            //{
            //    Console.Write("Lütfen path girin: ");
            //    string path = Console.ReadLine();

            //    if (path == "exit")
            //        break;

            //    string[] klasorler = Directory.GetDirectories(path);
            //    foreach (var item in klasorler)
            //    {
            //        Console.WriteLine(item);
            //    }

            //    string[] dosyalar = Directory.GetFiles(path);
            //    foreach (var item in dosyalar)
            //    {
            //        Console.WriteLine(item);
            //    }

            //    Console.WriteLine("--------------------------");
            //    Console.WriteLine("    ");
            //}

            //Directory.Move(@"C:\Projects\yzl-8436\deneme.txt", @"C:\Projects\yzl-8436\deneme_klasor\deneme.txt");
            //DriveInfo[] suruculer = DriveInfo.GetDrives();
            //foreach (DriveInfo item in suruculer)
            //{
            //    Console.WriteLine(item.Name);//isim
            //    Console.WriteLine(item.TotalFreeSpace.ToString());//boş alan
            //    Console.WriteLine(item.TotalSize.ToString());//Toplamalan
            //    Console.WriteLine(item.VolumeLabel);//Önad
            //}

            //Console.WriteLine("Lütfen ")

            //if (File.Exists(@"c:\deneme.txt"))
            //    File.Create(@"c:\deneme.txt");

            File.WriteAllText(@"C:\Projects\yzl-8436\deneme_klasor\deneme.txt", "ahmet");
            string icerik = File.ReadAllText(@"C:\Projects\yzl-8436\deneme_klasor\deneme.txt");

            File.Delete(@"C:\Projects\yzl-8436\deneme_klasor\deneme.txt");
        }
    }
}