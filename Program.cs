using System;
using modul4_103022300062;

class Program
{

    static void Main()
    {
        //SOAL 1
        //String input = Console.ReadLine();

        //Enum.TryParse(input, true, out KodeProduk.Produk produk);
        //{
        //    String kodeProduk = KodeProduk.getKodeProduk(produk);
        //    Console.WriteLine($"Kode Produk {produk}: {kodeProduk}");

        //}

        //SOAL 2
        FanLaptop fan = new FanLaptop();
        fan.currentState = FanLaptop.FanState.Quiet;

        Console.WriteLine("Fan " + fan.currentState );

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Pilihan Aksi: ");
            Console.WriteLine("1. Mode Up");
            Console.WriteLine("2. Mode Down");
            Console.WriteLine("3. Turbo Shortcut");
            Console.WriteLine("4. Keluar");
            String input = Console.ReadLine();
            Console.WriteLine();

            switch (input)
            {
                case "1":
                    if(fan.currentState == FanLaptop.FanState.Quiet)
                    {
                        fan.activateTrigger(FanLaptop.Trigger.ModeUp);
                        Console.WriteLine("Fan Quiet berubah menjadi " + fan.currentState);
                    } else if (fan.currentState == FanLaptop.FanState.Balanced)
                    {
                        fan.activateTrigger(FanLaptop.Trigger.ModeUp);
                        Console.WriteLine("Fan Balanced berubah menjadi " + fan.currentState);
                    }else
                    {
                        fan.activateTrigger(FanLaptop.Trigger.ModeUp);
                        Console.WriteLine("Fan Performance berubah menjadi " + fan.currentState);
                    }
                    break;

                case "2":
                    if (fan.currentState == FanLaptop.FanState.Balanced)
                    {
                        fan.activateTrigger(FanLaptop.Trigger.ModeDown);
                        Console.WriteLine("Fan Balanced berubah menjadi " + fan.currentState);
                    }
                    else if (fan.currentState == FanLaptop.FanState.Performance)
                    {
                        fan.activateTrigger(FanLaptop.Trigger.ModeDown);
                        Console.WriteLine("Fan Performance berubah menjadi " + fan.currentState);
                    }
                    else
                    {
                        fan.activateTrigger(FanLaptop.Trigger.ModeDown);
                        Console.WriteLine("Fan Turbo berubah menjadi " + fan.currentState);
                    }
                    break;

                case "3":
                    if (fan.currentState == FanLaptop.FanState.Quiet)
                    {
                        fan.activateTrigger(FanLaptop.Trigger.TurboShortcut);
                        Console.WriteLine("Fan Quiet berubah menjadi " + fan.currentState);
                    }else
                    {
                        fan.activateTrigger(FanLaptop.Trigger.TurboShortcut);
                        Console.WriteLine("Fan Turbo berubah menjadi " + fan.currentState);
                    }
                    break;

                case "4":
                    Console.WriteLine("bye");
                    return;
            }

        }
    }
}