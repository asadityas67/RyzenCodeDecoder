using System;

namespace RyzenESdecode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Ryzen Codename Decoder v 0.1");
            Console.WriteLine("Made in accordance with \"HOW TO DECODE AMD CODENAMES V5.0\" BY MARVIN(Marvin@moepc.net)");
            Console.WriteLine("Program Written By Aditya Sharma u/asadityas67 or asadityas67@gmail.com");
            Console.WriteLine("Program comes with no warranty");
            Console.WriteLine("For Zen Based CPUs only, may not cover all CPUs");
            Console.WriteLine("Enter The codename you wish to decode :-");
            string code = Console.ReadLine().ToUpper();
            char[] keys = code.ToCharArray();
            Console.WriteLine("");
            switch (keys[0])
            {
                case '1': Console.WriteLine("Prototype Generation : Engineering sample 0");break;
                case '2': Console.WriteLine("Prototype Generation : Engineering sample 1"); break;
                case 'Y': Console.WriteLine("Prototype Generation : Production Ryzen"); break;
                case 'P': Console.WriteLine("Prototype Generation : Production EPYC"); break;
                case 'Z': Console.WriteLine("Prototype Generation : Quantum satis or acceptable to reach desired results"); break;
                default: Console.WriteLine("Invalid");break;
            }
            Console.WriteLine("");
            switch (keys[1])
            {
                case 'D': Console.WriteLine("Platform : Desktop"); break;
                case 'S': Console.WriteLine("Platfrom : Server"); break;
                case 'M': Console.WriteLine("Platfrom : Mobile/Laptop"); break;
                case 'E': Console.WriteLine("Platfrom : Embedded"); break;
                default: Console.WriteLine("Invalid"); break;
            }
            Console.WriteLine("");
            string tdp = keys[6] + "" + keys[7];
            switch (tdp)
            {
                case "A4": Console.WriteLine("TDP Config : Early 32C Naples"); break;
                case "A8": Console.WriteLine("TDP Config : 180W Threadripper"); break;
                case "A9": Console.WriteLine("TDP Config : non-X Threadripper (these exist?)"); break;
                case "AZ": Console.WriteLine("TDP Config : 250W Threadripper"); break;
                case "BA": 
                case "A2": Console.WriteLine("TDP Config : 95W 8 core Zeppelin ES"); break;
                case "BB":
                case "AU": Console.WriteLine("TDP Config : 65W Zeppelin or Pinnacle or Matisse"); break;
                case "BC": Console.WriteLine("TDP Config : 95W Zeppelin or Pinnacle"); break;
                case "BD": Console.WriteLine("TDP Config : 180W Naples"); break;
                case "BE": Console.WriteLine("TDP Config : 155/170W Naples"); break;
                case "BF": Console.WriteLine("TDP Config : 120W Naples"); break;
                case "BG": Console.WriteLine("TDP Config : 105W Pinnacle or Matisse"); break;
                case "BH": Console.WriteLine("TDP Config : 45W Pinnacle - E Series"); break;
                case "BI": Console.WriteLine("TDP Config : 35W Zeppelin Embedded"); break;
                case "BK": Console.WriteLine("TDP Config : 45W Zeppelin Embedded"); break;
                case "C3": Console.WriteLine("TDP Config : 45W Raven Ridge H Series"); break;
                case "C4": Console.WriteLine("TDP Config : 15W Raven/Picasso - U series"); break;
                case "C5": Console.WriteLine("TDP Config : 65W Raven -G Series"); break;
                case "C6": Console.WriteLine("TDP Config : 35W Raven -GE Series"); break;
                case "E2": Console.WriteLine("TDP Config : Early 64C LP ROME"); break;
                default: Console.WriteLine("Invalid"); break;
            }
            Console.WriteLine("");
            switch (keys[8])
            {
                case 'M': Console.WriteLine("Package : AM4 PGA1331");break;
                case 'V': Console.WriteLine("Package : SP3 LGA4094 or TR4"); break;
                case 'U': Console.WriteLine("Package : SP3r2 LGA4094 or TR4"); break;
                case 'R': Console.WriteLine("Package : SP4r2 BGA2028"); break;
                case 'T': Console.WriteLine("FP5 BGA"); break;
                default: Console.WriteLine("Invalid"); break;
            }
            Console.WriteLine("");
            switch (keys[9])
            {
                case '2': Console.WriteLine("Physical Cores : 2"); break;
                case '4': Console.WriteLine("Physical Cores : 4"); break;
                case '6': Console.WriteLine("Physical Cores : 6"); break;
                case '8': Console.WriteLine("Physical Cores : 8"); break;
                case 'C': Console.WriteLine("Physical Cores : 12"); break;
                case 'G': Console.WriteLine("Physical Cores : 16"); break;
                case 'H': Console.WriteLine("Physical Cores : 24"); break;
                case 'I': Console.WriteLine("Physical Cores : 32"); break;
                case 'J': Console.WriteLine("Physical Cores : 64"); break;
            }
            Console.WriteLine("");
            switch (keys[10])
            {
                case 'O': Console.WriteLine("Cache Config : 2x512 KB L2 + 4 MB L3"); break;
                case 'M': Console.WriteLine("Cache Config : 4x512 KB L2 + 4 MB L3"); break;
                case 'K': Console.WriteLine("Cache Config : 4x512 KB L2 + 8 MB L3"); break;
                case 'G': Console.WriteLine("Cache Config : 4x512 KB L2 + 16 MB L3"); break;
                case 'I': Console.WriteLine("Cache Config : 6x512 KB L2 + 16 MB L3"); break;
                case '8': Console.WriteLine("Cache Config : 8x512 KB L2 + 16 MB L3 (Zeppelin SCM)"); break;
                case 'Q': Console.WriteLine("Cache Config : 8x512 KB L2 + 16 MB L3 (WhiteHaven 2x MCM)"); break;
                case 'S': Console.WriteLine("Cache Config : 8x512 KB L2 + 32 MB L3"); break;
                case 'R': Console.WriteLine("Cache Config : 8x512 KB L2 + 64 MB L3"); break;
                case '9': Console.WriteLine("Cache Config : 12x512 KB L2 + 32 MB L3"); break;
                case 'W': Console.WriteLine("Cache Config : 12x512 KB L2 + 64 MB L3"); break;
                case 'A': Console.WriteLine("Cache Config : 16x512 KB L2 + 32 MB L3"); break;
                case 'P': Console.WriteLine("Cache Config : 16x512 KB L2 + 64 MB L3"); break;
                case 'C': Console.WriteLine("Cache Config : 24x512 KB L2 + 64 MB L3"); break;
                case 'H': Console.WriteLine("Cache Config : 32x512 KB L2 + 64 MB L3"); break;
                case 'U': Console.WriteLine("Cache Config : 64x512 KB L2 + 256 MB L3"); break;
                default: Console.WriteLine("Invalid"); break;
            }
            Console.WriteLine("");
            string step = keys[11] + "" + keys[12];
            switch (step)
            {
                case "E4": Console.WriteLine("Stepping : A Zeppelin"); break;
                case "AE": Console.WriteLine("Stepping : B1 Zeppelin "); break;
                case "F2": Console.WriteLine("Stepping : B Raven1 (RV1)"); break;
                case "AF": Console.WriteLine("Stepping : B2 Zeppelin or pinnacle"); break;
                case "F3":
                case "F4": Console.WriteLine("Stepping : B Zeppelin"); break;
                case "FB": Console.WriteLine("Stepping : B0 or B1 Raven1(RV1)"); break;
                case "F6": Console.WriteLine("Stepping : Fenghuang Raven"); break;
                case "FC": Console.WriteLine("Stepping : Raven2(RV2)"); break;
                case "G5": Console.WriteLine("Stepping : ROME"); break;
                case "FG": Console.WriteLine("Stepping : PICASSO"); break;
                case "H2": Console.WriteLine("Stepping : Matisse"); break;
                default: Console.WriteLine("Invalid"); break;
            }
            Console.WriteLine("");
            Console.WriteLine("Some details such as frequencies are not shown because of insufficient data, may be updated later..");
            Console.WriteLine("If there were any issues, this program was written in 1 hour, sorry..");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
