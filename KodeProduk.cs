﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_103022300062
{
    internal class KodeProduk
    {
        public enum Produk { Laptop, Smartphone, Tablet, Headset,
            Keyboard, Mouse, Printer, Monitor, Smartwatch, Kamera}

        public static String[] kodeProduk = { "E100", "E101", "E102", "E103",
                "E104", "E105", "E106", "E107", "E108", "E109" };

        public static String getKodeProduk(Produk produk)
        {
            return kodeProduk[(int)produk];
        }
    }
}
