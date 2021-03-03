using System;
using System.Collections.Generic;
using System.Threading;

namespace ConsoleApp2
{
    class Program
    {
        static Thread Login_Thread = new Thread(new ThreadStart(Login));
        static Thread Exit_Thread = new Thread(new ThreadStart(Exit));
        static Thread kontrol = new Thread(new ThreadStart(Kontrol));
        private static Thread Asansor_Thread_0 = new Thread(new ThreadStart(Asansor_0));
        private static Thread Asansor_Thread_1 = new Thread(new ThreadStart(Asansor_1));
        static Thread Asansor_Thread_2 = new Thread(new ThreadStart(Asansor_2));
        static Thread Asansor_Thread_3 = new Thread(new ThreadStart(Asansor_3));
        static Thread Asansor_Thread_4 = new Thread(new ThreadStart(Asansor_4));
        
        static object Lock_Zemin = new object(); 
        static object Lock_1 = new object();
        static object Lock_2 = new object();
        static object Lock_3 = new object();
        static object Lock_4 = new object();

        static List<int> login_list = new List<int>();
        static List<int> login_target = new List<int>();
        static List<int> Exit_1 = new List<int>();
        static List<int> Exit_2 = new List<int>();
        static List<int> Exit_3 = new List<int>();
        static List<int> Exit_4 = new List<int>();

        private static int[,] kisiler = new int[5, 2]; // katlardaki toplam ve kuyrukta bulunan insan sayısı
        static Boolean[] aktiflik = { false, false, false, false, false };
        static Random rand = new Random();
        static int[] max_kat = new int[5];
        static int[] doluluk = new int[5];
        static int[] asansoryuk = new int[5];
        static bool[] yon = { true, true, true, true, true };
        static int[] asansorkonum = new int[5];

        static int[,] asansor_0 = new int[10, 2];
        static int[,] asansor_1 = new int[10, 2];
        static int[,] asansor_2 = new int[10, 2];
        static int[,] asansor_3 = new int[10, 2];
        static int[,] asansor_4 = new int[10, 2];

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Login_Thread.Start();
            Exit_Thread.Start();
            kontrol.Start();
            Asansor_Thread_0.Start();
            Asansor_Thread_1.Start();
            Asansor_Thread_2.Start();
            Asansor_Thread_3.Start(); 
            Asansor_Thread_4.Start();

            aktiflik[0] = true;
            int i = 0;
            int temp = 0;
            while (true)
            {
                Thread.Sleep(200);
                Console.WriteLine("\n------------------------------------------");
                Console.WriteLine("Zemin Kat Kuyruk: " + kisiler[0, 0]);
                Console.WriteLine("1. Kata Çıkan: " + kisiler[1, 0] + "    Kuyruk: " + kisiler[1, 1]);
                Console.WriteLine("2. Kata Çıkan: " + kisiler[2, 0] + "    Kuyruk: " + kisiler[2, 1]);
                Console.WriteLine("3. Kata Çıkan: " + kisiler[3, 0] + "    Kuyruk: " + kisiler[3, 1]);
                Console.WriteLine("4. Kata Çıkan: " + kisiler[4, 0] + "    Kuyruk: " + kisiler[4, 1]);
                Console.WriteLine("Çıkış Yapanlar: " + kisiler[0, 1]);

                temp = 0;
                Console.WriteLine("1. Asansör Aktiflik: " + aktiflik[0]); /// 1. Asansör 
                if (yon[0] == true)
                {
                    Console.WriteLine("\tAsansör Kat:" + asansorkonum[0]);
                    Console.WriteLine("\tAsansör Yönü: Yukarı");
                    Console.WriteLine("\tAsansör Kapasitesi: 10");
                    Console.WriteLine("\tAsansördeki Kişi Sayısı:" + asansoryuk[0]);

                    Console.Write("\tAsansördekiler: ");
                    while (temp < 10)
                    {
                        Console.Write("[ " + asansor_0[temp, 0] + ", " + asansor_0[temp, 1] + " ]");
                        temp++;
                        if (asansor_0[temp, 0] == 0)
                            break;
                    }
                    Console.WriteLine("");
                }
                else if (yon[0] == false)
                {
                    Console.WriteLine("\tAsansör Kat:" + asansorkonum[0]);
                    Console.WriteLine("\tAsansör Yönü: Aşağı");
                    Console.WriteLine("\tAsansör Kapasitesi: 10");
                    Console.WriteLine("\tAsansördeki Kişi Sayısı:" + asansoryuk[0]);
                }

                temp = 0;
                Console.WriteLine("2. Asansör Aktiflik: " + aktiflik[1]);       /// 2. Asansör 
                if (yon[1] == true)
                {
                    Console.WriteLine("\tAsansör Kat:" + asansorkonum[1]);
                    Console.WriteLine("\tAsansör Yönü: Yukarı");
                    Console.WriteLine("\tAsansör Kapasitesi: 10");
                    Console.WriteLine("\tAsansördeki Kişi Sayısı:" + asansoryuk[1]);

                    Console.Write("\tAsansördekiler: ");
                    while (temp < 10)
                    {
                        Console.Write("[ " + asansor_1[temp, 0] + ", " + asansor_1[temp, 1] + " ]");
                        temp++;
                        if (asansor_1[temp, 0] == 0)
                            break;
                    }
                    Console.WriteLine("");
                }
                else if (yon[1] == false)
                {
                    Console.WriteLine("\tAsansör Kat:" + asansorkonum[1]);
                    Console.WriteLine("\tAsansör Yönü: Aşağı");
                    Console.WriteLine("\tAsansör Kapasitesi: 10");
                    Console.WriteLine("\tAsansördeki Kişi Sayısı:" + asansoryuk[1]);
                }

                temp = 0;
                Console.WriteLine("3. Asansör Aktiflik: " + aktiflik[2]);       /// 3. Asansör 
                if (yon[2] == true)
                {
                    Console.WriteLine("\tAsansör Kat:" + asansorkonum[2]);
                    Console.WriteLine("\tAsansör Yönü: Yukarı");
                    Console.WriteLine("\tAsansör Kapasitesi: 10");
                    Console.WriteLine("\tAsansördeki Kişi Sayısı:" + asansoryuk[2]);

                    Console.Write("\tAsansördekiler: ");
                    while (temp < 10)
                    {
                        Console.Write("[ " + asansor_2[temp, 0] + ", " + asansor_2[temp, 1] + " ]");
                        temp++;
                        if (asansor_2[temp, 0] == 0)
                            break;
                    }
                    Console.WriteLine("");
                }
                else if (yon[2] == false)
                {
                    Console.WriteLine("\tAsansör Kat:" + asansorkonum[2]);
                    Console.WriteLine("\tAsansör Yönü: Aşağı");
                    Console.WriteLine("\tAsansör Kapasitesi: 10");
                    Console.WriteLine("\tAsansördeki Kişi Sayısı:" + asansoryuk[2]);
                }

                temp = 0;
                Console.WriteLine("4. Asansör Aktiflik: " + aktiflik[3]);       /// 4. Asansör 
                if (yon[3] == true)
                {
                    Console.WriteLine("\tAsansör Kat:" + asansorkonum[3]);
                    Console.WriteLine("\tAsansör Yönü: Yukarı");
                    Console.WriteLine("\tAsansör Kapasitesi: 10");
                    Console.WriteLine("\tAsansördeki Kişi Sayısı:" + asansoryuk[3]);

                    Console.Write("\tAsansördekiler: ");
                    while (temp < 10)
                    {
                        Console.Write("[ " + asansor_3[temp, 0] + ", " + asansor_3[temp, 1] + " ]");
                        temp++;
                        if (asansor_3[temp, 0] == 0)
                            break;
                    }
                    Console.WriteLine("");
                }
                else if (yon[3] == false)
                {
                    Console.WriteLine("\tAsansör Kat:" + asansorkonum[3]);
                    Console.WriteLine("\tAsansör Yönü: Aşağı");
                    Console.WriteLine("\tAsansör Kapasitesi: 10");
                    Console.WriteLine("\tAsansördeki Kişi Sayısı:" + asansoryuk[3]);
                }

                temp = 0;
                Console.WriteLine("5. Asansör Aktiflik: " + aktiflik[4]);       /// 5. Asansör 
                if (yon[4] == true)
                {
                    Console.WriteLine("\tAsansör Kat:" + asansorkonum[4]);
                    Console.WriteLine("\tAsansör Yönü: Yukarı");
                    Console.WriteLine("\tAsansör Kapasitesi: 10");
                    Console.WriteLine("\tAsansördeki Kişi Sayısı:" + asansoryuk[4]);

                    Console.Write("\tAsansördekiler: ");
                    while (temp < 10)
                    {
                        Console.Write("[ " + asansor_4[temp, 0] + ", " + asansor_4[temp, 1] + " ]");
                        temp++;
                        if (asansor_4[temp, 0] == 0)
                            break;
                    }
                    Console.WriteLine("");
                }
                else if (yon[4] == false)
                {
                    Console.WriteLine("\tAsansör Kat:" + asansorkonum[4]);
                    Console.WriteLine("\tAsansör Yönü: Aşağı");
                    Console.WriteLine("\tAsansör Kapasitesi: 10");
                    Console.WriteLine("\tAsansördeki Kişi Sayısı:" + asansoryuk[4]);
                }

                temp = 0;
                Console.Write("\n0. Kat: ");
                while (temp < login_target.Count)
                {
                    Console.Write("[ " + login_list[temp] + ", " + login_target[temp] + " ]");
                    temp++;
                    if(temp == 10)
                    {
                        Console.Write("[ .. ]");
                        break;
                    }
                }
                temp = 0;
                Console.Write("\n1. Kat: ");
                while (temp < Exit_1.Count)
                {
                    Console.Write("[ " + Exit_1[temp] + ", 0]");
                    temp++;
                }
                temp = 0;
                Console.Write("\n2. Kat: ");
                while (temp < Exit_2.Count)
                {
                    Console.Write("[ " + Exit_2[temp] + ", 0]");
                    temp++;
                }
                temp = 0;
                Console.Write("\n3. Kat: ");
                while (temp < Exit_3.Count)
                {
                    Console.Write("[ " + Exit_3[temp] + ", 0]");
                    temp++;
                }
                temp = 0;
                Console.Write("\n4. Kat: ");
                while (temp < Exit_4.Count)
                {
                    Console.Write("[ " + Exit_4[temp] + ", 0]");
                    temp++;
                }
            }
        }
        private static int Kat_1(int doluluk, int asansor)
        {
            lock(Lock_1)
            {
                if (Exit_1.Count != 0)
                {
                    for (int k = 0; k < Exit_1.Count; k++)
                    {
                        if(doluluk < 10)
                        {
                            if (doluluk + Exit_1[0] <= 10)
                            {
                                doluluk += Exit_1[0];                                   
                                kisiler[1, 1] -= Exit_1[0]; // kuyruk azaltılır  
                                Exit_1.RemoveAt(0);                                     
                            }
                            else if (doluluk + Exit_1[0] > 10)
                            {
                                int temp = 10 - doluluk;
                                doluluk += temp;                                      
                                kisiler[1, 1] -= temp;  // kuyruk azaltılır
                                Exit_1[0] -= temp;
                            }
                        }
                        else if (doluluk >= 10)
                           break;
                    }
                }
                return doluluk;
            }
        }
        private static int Kat_2(int doluluk, int asansor)
        {
            lock (Lock_2)
            {
                if (Exit_2.Count != 0)
                {
                    for (int k = 0; k <= Exit_2.Count; k++)
                    {
                        if (doluluk + Exit_2[0] <= 10)
                        {
                            doluluk += Exit_2[0];
                            kisiler[2, 1] -= Exit_2[0];
                            Exit_2.RemoveAt(0);
                        }
                        else if (doluluk + Exit_2[0] > 10)
                        {
                            int temp = 10 - doluluk;
                            doluluk += temp;
                            kisiler[2, 1] -= temp;
                            Exit_2[0] -= temp;
                        }
                        if (doluluk >= 10)
                            break;
                    }
                }
                return doluluk;
            }
        }
        private static int Kat_3(int doluluk, int asansor)
        {
            lock (Lock_3)
            {
                if (Exit_3.Count != 0)
                {
                    for (int k = 0; k <= Exit_3.Count; k++)
                    {
                        if (doluluk + Exit_3[0] <= 10)
                        {
                            doluluk += Exit_3[0];
                            kisiler[3, 1] -= Exit_3[0];
                            Exit_3.RemoveAt(0);
                        }
                        else if (doluluk + Exit_3[0] > 10)
                        {
                            int temp = 10 - doluluk;
                            doluluk += temp;
                            kisiler[3, 1] -= temp;
                            Exit_3[0] -= temp;
                        }
                        if (doluluk >= 10)
                            break;
                    }
                }
                return doluluk;
            }
        }
        private static int Kat_4(int doluluk, int asansor)
        {
            lock (Lock_4)
            {
                if (Exit_4.Count != 0)
                {
                    for (int k = 0; k <= Exit_4.Count; k++)
                    {
                        if (doluluk + Exit_4[0] <= 10)
                        {
                            doluluk += Exit_4[0];
                            kisiler[4, 1] -= Exit_4[0];
                            Exit_4.RemoveAt(0);
                        }
                        else if (doluluk + Exit_4[0] > 10)
                        {
                            int temp = 10 - doluluk;
                            doluluk += temp;
                            kisiler[4, 1] -= temp;
                            Exit_4[0] -= temp;
                        }
                        if (doluluk >= 10)
                            break;
                    }
                }
                return doluluk;
            }
        }
        private static void Asagi(int[,] dizi, int asansor, int kat)
        {
            yon[asansor] = false;
            doluluk[asansor] = 0; 
            asansoryuk[asansor] = 0;
            int kat_baslangic = kat;

            if (kat_baslangic == 1) ///sırayla 1-2-3-4 gider
            {
                if (Exit_1.Count != 0)
                {
                    asansorkonum[asansor] = 1;
                    doluluk[asansor] = Kat_1(doluluk[asansor], asansor);
                    asansoryuk[asansor] = doluluk[asansor];       
                }    
                if (doluluk[asansor] < 10 && Exit_2.Count != 0)
                {
                    Thread.Sleep(200 * Math.Abs(asansorkonum[asansor] - 2));
                    asansorkonum[asansor] = 2;
                    doluluk[asansor] = Kat_2(doluluk[asansor], asansor);
                    asansoryuk[asansor] = doluluk[asansor];
                }
                if (doluluk[asansor] < 10 && Exit_3.Count != 0)
                {
                    Thread.Sleep(200 * Math.Abs(asansorkonum[asansor] - 3));
                    asansorkonum[asansor] = 3;
                    doluluk[asansor] = Kat_3(doluluk[asansor], asansor);
                    asansoryuk[asansor] = doluluk[asansor];
                }
                if (doluluk[asansor] < 10 && Exit_4.Count != 0)
                {
                    Thread.Sleep(200 * Math.Abs(asansorkonum[asansor] - 4));
                    asansorkonum[asansor] = 4;
                    doluluk[asansor] = Kat_4(doluluk[asansor], asansor);
                    asansoryuk[asansor] = doluluk[asansor];
                }
                while(true)
                {
                    Thread.Sleep(200);
                    asansorkonum[asansor]--;
                    if (asansorkonum[asansor] == 0)
                            break;
                }
                asansoryuk[asansor] = 0;
                kisiler[0, 1] += doluluk[asansor];
                doluluk[asansor] = 0;
            } 
            else if (kat_baslangic == 2) /// 2 ve 3 den sonra 1 i kontrol eder yoksa 4 e devam eder
            {
                if ( Exit_2.Count != 0)
                {
                    Thread.Sleep(200 * Math.Abs(asansorkonum[asansor] - 2));
                    asansorkonum[asansor] = 2;
                    doluluk[asansor] = Kat_2(doluluk[asansor], asansor);
                    asansoryuk[asansor] = doluluk[asansor];
                }
                if( Exit_1.Count != 0)
                {
                    if (10 == asansoryuk[asansor] + Exit_1[0])
                    {
                        if (Exit_1.Count != 0 && doluluk[asansor] < 10 )
                        {
                            Thread.Sleep(200 * Math.Abs(asansorkonum[asansor] - 1));
                            asansorkonum[asansor] = 1;
                            doluluk[asansor] = Kat_1(doluluk[asansor], asansor);
                            asansoryuk[asansor] = doluluk[asansor];
                        }
                    }
                }
                if (doluluk[asansor] < 10 && Exit_3.Count != 0)
                {
                    Thread.Sleep(200 * Math.Abs(asansorkonum[asansor] - 3));
                    asansorkonum[asansor] = 3;
                    doluluk[asansor] = Kat_3(doluluk[asansor], asansor);
                    asansoryuk[asansor] = doluluk[asansor];
                }
                if (Exit_1.Count != 0)
                {
                    if (10 == asansoryuk[asansor] + Exit_1[0])
                    {
                        if (Exit_1.Count != 0 && doluluk[asansor] < 10)
                        {
                            Thread.Sleep(200 * Math.Abs(asansorkonum[asansor] - 1));
                            asansorkonum[asansor] = 1;
                            doluluk[asansor] = Kat_1(doluluk[asansor], asansor);
                            asansoryuk[asansor] = doluluk[asansor];
                        }
                    }
                }
                if (doluluk[asansor] < 10 && Exit_4.Count != 0)
                {
                    Thread.Sleep(200 * Math.Abs(asansorkonum[asansor] - 4));
                    asansorkonum[asansor] = 4;
                    doluluk[asansor] = Kat_4(doluluk[asansor], asansor);
                    asansoryuk[asansor] = doluluk[asansor];
                }
                if (Exit_1.Count != 0 && doluluk[asansor] < 10)
                {
                    Thread.Sleep(200 * Math.Abs(asansorkonum[asansor] - 1));
                    asansorkonum[asansor] = 1;
                    doluluk[asansor] = Kat_1(doluluk[asansor], asansor);
                    asansoryuk[asansor] = doluluk[asansor];
                }
                while (true)
                {
                    Thread.Sleep(200);
                    asansorkonum[asansor]--;
                    if (asansorkonum[asansor] == 0)
                        break;
                }
                asansoryuk[asansor] = 0;
                kisiler[0, 1] += doluluk[asansor];
                doluluk[asansor] = 0;
            }
            else if (kat_baslangic == 3) /// 4 e çıkar sonra 2 ve 1 i kontrol ederek iner
            {
                if (Exit_3.Count != 0)
                {
                    asansorkonum[asansor] = 3;
                    doluluk[asansor] = Kat_3(doluluk[asansor], asansor);
                    asansoryuk[asansor] = doluluk[asansor];
                }
                if (doluluk[asansor] < 10 && Exit_4.Count != 0)
                {
                    Thread.Sleep(200 * Math.Abs(asansorkonum[asansor] - 4));
                    asansorkonum[asansor] = 4;
                    doluluk[asansor] = Kat_4(doluluk[asansor], asansor);
                    asansoryuk[asansor] = doluluk[asansor];
                }
                if (doluluk[asansor] < 10 && Exit_2.Count != 0)
                {
                    Thread.Sleep(200 * Math.Abs(asansorkonum[asansor] - 2));
                    asansorkonum[asansor] = 2;
                    doluluk[asansor] = Kat_2(doluluk[asansor], asansor);
                    asansoryuk[asansor] = doluluk[asansor];
                }
                if (doluluk[asansor] < 10 && Exit_1.Count != 0)
                {
                    Thread.Sleep(200 * Math.Abs(asansorkonum[asansor] - 1));
                    asansorkonum[asansor] = 1;
                    doluluk[asansor] = Kat_1(doluluk[asansor], asansor);
                    asansoryuk[asansor] = doluluk[asansor];
                }
                while (true)
                {
                    Thread.Sleep(200);
                    asansorkonum[asansor]--;
                    if (asansorkonum[asansor] == 0)
                        break;
                }
                asansoryuk[asansor] = 0;
                kisiler[0, 1] += doluluk[asansor];
                doluluk[asansor] = 0;
            }
            else if (kat_baslangic == 4)
            {
                if (Exit_4.Count != 0)
                {
                    asansorkonum[asansor] = 4;
                    doluluk[asansor] = Kat_4(doluluk[asansor], asansor);
                    asansoryuk[asansor] = doluluk[asansor];
                    kat = 4;
                }
                if (doluluk[asansor] < 10 && Exit_3.Count != 0)
                {
                    Thread.Sleep(200 * Math.Abs(asansorkonum[asansor] - 3));
                    asansorkonum[asansor] = 3;
                    doluluk[asansor] = Kat_3(doluluk[asansor], asansor);
                    asansoryuk[asansor] = doluluk[asansor];
                }
                if (doluluk[asansor] < 10 && Exit_2.Count != 0)
                {
                    Thread.Sleep(200 * Math.Abs(asansorkonum[asansor] - 2));
                    asansorkonum[asansor] = 2;
                    doluluk[asansor] = Kat_2(doluluk[asansor], asansor);
                    asansoryuk[asansor] = doluluk[asansor];
                }
                if (doluluk[asansor] < 10 && Exit_1.Count != 0)
                {
                    Thread.Sleep(200 * Math.Abs(asansorkonum[asansor] - 1));
                    asansorkonum[asansor] = 1;
                    doluluk[asansor] = Kat_1(doluluk[asansor], asansor);
                    asansoryuk[asansor] = doluluk[asansor];
                }
                while (true)
                {
                    Thread.Sleep(200);
                    asansorkonum[asansor]--;
                    if (asansorkonum[asansor] == 0)
                        break;
                }
                asansoryuk[asansor] = 0;
                kisiler[0, 1] += doluluk[asansor];
                doluluk[asansor] = 0;
            }
        }
        private static void Yukari(int[,] dizi, int asansor)
        {
            if (asansor == 0)
            {
                yon[0] = true;
                int i = 0;
                for (i = 0; i < 10; i++) // max çıkılacak katı bulur
                {
                    if (max_kat[asansor] < dizi[i, 1])
                    {
                        max_kat[asansor] = dizi[i, 1];
                    }
                }
                for (int k = 1; k <= max_kat[asansor]; k++)
                {
                    Thread.Sleep(200);
                    asansorkonum[0] = k;
                    for (i = 0; i < 10; i++)   // katta inecek grupları kontrol eder
                    {
                        if (dizi[i, 1] == k)
                        {
                            kisiler[k, 0] += dizi[i, 0];
                        }
                    }
                }
                asansoryuk[0] = 0;
                i = 0;
                while (i < 10)
                {
                    asansor_0[i, 0] = 0;
                    asansor_0[i, 1] = 0;
                    i++;
                }
                Asagi(asansor_0, 0, max_kat[asansor]);
                max_kat[0] = 0;
            }
            else if (asansor == 1)
            {
                yon[1] = true;
                int i = 0;
                for (i = 0; i < 10; i++) // max çıkılacak katı bulur
                {
                    if (max_kat[asansor] < dizi[i, 1])
                    {
                        max_kat[asansor] = dizi[i, 1];
                    }
                }
                for (int k = 1; k <= max_kat[asansor]; k++)
                {
                    Thread.Sleep(200);
                    asansorkonum[1] = k;
                    for (i = 0; i < 10; i++)
                    {
                        if (dizi[i, 1] == k)
                        {
                            kisiler[k, 0] += dizi[i, 0];
                        }
                    }
                }
                i = 0;
                while (i < 10)
                {
                    asansor_1[i, 0] = 0;
                    asansor_1[i, 1] = 0;
                    i++;
                }
                asansoryuk[1] = 0;
                Asagi(asansor_1, 1, max_kat[asansor]);
                max_kat[1] = 0;
            }
            else if (asansor == 2)
            {
                yon[2] = true;
                int i = 0;
                for (i = 0; i < 10; i++) // max çıkılacak katı bulur
                {
                    if (max_kat[asansor] < dizi[i, 1])
                    {
                        max_kat[asansor] = dizi[i, 1];
                    }
                }
                for (int k = 1; k <= max_kat[asansor]; k++)
                {
                    Thread.Sleep(200);
                    asansorkonum[2] = k;
                    for (i = 0; i < 10; i++)
                    {
                        if (dizi[i, 1] == k)
                        {
                            kisiler[k, 0] += dizi[i, 0];
                        }
                    }
                }
                i = 0;
                while (i < 10)
                {
                    asansor_2[i, 0] = 0;
                    asansor_2[i, 1] = 0;
                    i++;
                }
                asansoryuk[2] = 0;
                Asagi(asansor_2, 2, max_kat[asansor]);
                max_kat[2] = 0;
            }
            else if (asansor == 3)
            {
                yon[3] = true;
                int i = 0;
                for (i = 0; i < 10; i++) // max çıkılacak katı bulur
                {
                    if (max_kat[asansor] < dizi[i, 1])
                    {
                        max_kat[asansor] = dizi[i, 1];
                    }
                }
                for (int k = 1; k <= max_kat[asansor]; k++)
                {
                    Thread.Sleep(200);
                    asansorkonum[3] = k;
                    for (i = 0; i < 10; i++)
                    {
                        if (dizi[i, 1] == k)
                        {
                            kisiler[k, 0] += dizi[i, 0];
                        }
                    }
                }
                i = 0;
                while (i < 10)
                {
                    asansor_3[i, 0] = 0;
                    asansor_3[i, 1] = 0;
                    i++;
                }
                asansoryuk[3] = 0;
                Asagi(asansor_3, 3, max_kat[asansor]);
                max_kat[3] = 0;
            }
            else if (asansor == 4)
            {
                yon[4] = true;
                int i = 0;
                for (i = 0; i < 10; i++) // max çıkılacak katı bulur
                {
                    if (max_kat[asansor] < dizi[i, 1])
                    {
                        max_kat[asansor] = dizi[i, 1];
                    }
                }
                for (int k = 1; k <= max_kat[asansor]; k++)
                {
                    Thread.Sleep(200);
                    asansorkonum[4] = k;
                    for (i = 0; i < 10; i++)
                    {
                        if (dizi[i, 1] == k)
                        {
                            kisiler[k, 0] += dizi[i, 0];
                        }
                    }
                }
                i = 0;
                while (i < 10)
                {
                    asansor_4[i, 0] = 0;
                    asansor_4[i, 1] = 0;
                    i++;
                }
                asansoryuk[4] = 0;
                Asagi(asansor_4, 4, max_kat[asansor]);
                max_kat[4] = 0;
            }
        }   
        private static void Asansor_0()
        {
            asansoryuk[0] = 0;
            while (true)
            {
                if (login_list.Count != 0)
                {
                    for (int j = 0; j < login_list.Count; j++)
                    {
                    if (asansoryuk[0] < 10)
                    {
                        lock (Lock_Zemin)
                        {
                            if (asansoryuk[0] + login_list[0] <= 10 && login_target.Count != 0)
                            {
                                asansor_0[j, 0] = login_list[0];
                                asansoryuk[0] += login_list[0];
                                asansor_0[j, 1] = login_target[0];
                                login_list.RemoveAt(0);
                                login_target.RemoveAt(0);
                            }
                            else if (asansoryuk[0] + login_list[0] > 10 && login_target.Count != 0)
                            {
                                int temp = 10 - asansoryuk[0];
                                asansor_0[j, 0] = temp;
                                asansoryuk[0] += temp;
                                login_list[0] -= temp;
                                asansor_0[j, 1] = login_target[0];
                            }
                        }
                    }
                    else
                        break;
                    }
                    kisiler[0, 0] -= asansoryuk[0]; // sıra güncellenir
                    Yukari(asansor_0, 0);
                }
                else
                    Thread.Sleep(500);
            }   
        }
        private static void Asansor_1()
        {
            asansoryuk[1] = 0;
            while (true)
            {
                if (aktiflik[1] == false)
                {
                    Thread.Sleep(100);
                }
                if (aktiflik[1] == true)
                {
                    if (login_list.Count != 0)
                    {
                        for (int j = 0; j < login_list.Count; j++)
                        {
                            if (asansoryuk[1] < 10)
                            {
                                lock (Lock_Zemin)
                                {
                                    if (asansoryuk[1] + login_list[0] <= 10 && login_target.Count != 0)
                                    {
                                        asansor_1[j, 0] = login_list[0];
                                        asansoryuk[1] += login_list[0];
                                        asansor_1[j, 1] = login_target[0];
                                        login_list.RemoveAt(0);
                                        login_target.RemoveAt(0);
                                    }
                                    else if (asansoryuk[1] + login_list[0] > 10 && login_target.Count != 0)
                                    {
                                        int temp = 10 - asansoryuk[1];
                                        asansor_1[j, 0] = temp;
                                        asansoryuk[1] += temp;
                                        login_list[0] -= temp;
                                        asansor_1[j, 1] = login_target[0];
                                    }
                                }
                            }
                            else
                                break;
                        }
                        kisiler[0, 0] -= asansoryuk[1]; // sıra güncellenir
                        Yukari(asansor_1, 1);
                    }
                    else
                        Thread.Sleep(500);
                }
                
            }
        }
        private static void Asansor_2()
        {
            asansoryuk[2] = 0;
            while (true)
            {
                if (aktiflik[2] == false)
                {
                    Thread.Sleep(100);
                }
                if (aktiflik[2] == true)
                {
                    if (login_list.Count != 0)
                    {
                        for (int j = 0; j < login_list.Count; j++)
                        {

                        if (asansoryuk[2] < 10)
                        {
                            lock (Lock_Zemin)
                            {
                                if (asansoryuk[2] + login_list[0] <= 10 && login_target.Count != 0)
                                {
                                    asansor_2[j, 0] = login_list[0];
                                    asansoryuk[2] += login_list[0];
                                    asansor_2[j, 1] = login_target[0];
                                    login_list.RemoveAt(0);
                                    login_target.RemoveAt(0);
                                }
                                else if (asansoryuk[2] + login_list[0] > 10 && login_target.Count != 0)
                                {
                                    int temp = 10 - asansoryuk[2];
                                    asansor_2[j, 0] = temp;
                                    asansoryuk[2] += temp;
                                    login_list[0] -= temp;
                                    asansor_2[j, 1] = login_target[0];
                                }
                            }
                        }
                        else
                            break;
                        }
                        kisiler[0, 0] -= asansoryuk[2]; // sıra güncellenir
                        Yukari(asansor_2, 2);
                    }
                    else
                        Thread.Sleep(500);
                }

            }
        }
        private static void Asansor_3()
        {
            asansoryuk[3] = 0;
            while (true)
            {
                if (aktiflik[3] == false)
                {
                    Thread.Sleep(100);
                }
                if (aktiflik[3] == true)
                {
                    if (login_list.Count != 0)
                    {
                        for (int j = 0; j < login_list.Count; j++)
                        {
                        if (asansoryuk[3] < 10)
                        {
                            lock (Lock_Zemin)
                            {
                                if (asansoryuk[3] + login_list[0] <= 10 && login_target.Count != 0)
                                {
                                    asansor_3[j, 0] = login_list[0];
                                    asansoryuk[3] += login_list[0];
                                    asansor_3[j, 1] = login_target[0];
                                    login_list.RemoveAt(0);
                                    login_target.RemoveAt(0);
                                }
                                else if (asansoryuk[3] + login_list[0] > 10 && login_target.Count != 0)
                                {
                                    int temp = 10 - asansoryuk[3];
                                    asansor_3[j, 0] = temp;
                                    asansoryuk[3] += temp;
                                    login_list[0] -= temp;
                                    asansor_3[j, 1] = login_target[0];
                                }
                            }
                        }
                        else
                            break;
                        }
                        kisiler[0, 0] -= asansoryuk[3]; // sıra güncellenir
                        Yukari(asansor_3, 3);
                    }
                    else
                        Thread.Sleep(500);
                }

            }
        }
        private static void Asansor_4()
        {
            asansoryuk[4] = 0;
            while (true)
            {
                if (aktiflik[4] == false)
                {
                    Thread.Sleep(100);
                }
                if (aktiflik[4] == true)
                {
                    if (login_list.Count != 0)
                    {
                        for (int j = 0; j < login_list.Count; j++)
                        {
                        if (asansoryuk[4] < 10)
                        {
                            lock (Lock_Zemin)
                            {
                                if (asansoryuk[4] + login_list[0] <= 10 && login_target.Count != 0)
                                {
                                    asansor_4[j, 0] = login_list[0];
                                    asansoryuk[4] += login_list[0];
                                    asansor_4[j, 1] = login_target[0];
                                    login_list.RemoveAt(0);
                                    login_target.RemoveAt(0);
                                }
                                else if (asansoryuk[4] + login_list[0] > 10 && login_target.Count != 0)
                                {
                                    int temp = 10 - asansoryuk[4];
                                    asansor_4[j, 0] = temp;
                                    asansoryuk[4] += temp;
                                    login_list[0] -= temp;
                                    asansor_4[j, 1] = login_target[0];
                                }
                            }
                        }
                        else
                            break;
                        }
                        kisiler[0, 0] -= asansoryuk[4]; // sıra güncellenir
                        Yukari(asansor_4, 4);
                    }
                    else
                        Thread.Sleep(500);
                }

            }
        }
        private static void Login()
        {
            int rand_deger;
            while (true)
            {
                rand_deger = rand.Next(1, 11);
                kisiler[0, 0] += rand_deger;
                login_list.Add(rand_deger); //Giren
                rand_deger = rand.Next(1, 5);
                login_target.Add(rand_deger); //Hedef
                Thread.Sleep(500);
            }
        }
        private static void Exit()
        {
            while (true)
            {
                int rand_exit = rand.Next(1, 5);
                switch(rand_exit)
                {
                    case 1:
                        rand_exit = rand.Next(1, 6);
                        kisiler[1, 1] += rand_exit;
                        Exit_1.Add(rand_exit);
                        break; 
                    case 2:
                        rand_exit = rand.Next(1, 6);
                        kisiler[2, 1] += rand_exit;
                        Exit_2.Add(rand_exit);
                        break;
                    case 3:
                        rand_exit = rand.Next(1, 6);
                        kisiler[3, 1] += rand_exit;
                        Exit_3.Add(rand_exit);
                        break;
                    case 4:
                        rand_exit = rand.Next(1, 6);
                        kisiler[4, 1] += rand_exit;
                        Exit_4.Add(rand_exit);
                        break;
                }
                Thread.Sleep(1000);
            }
        }
        private static void Kontrol()
        {
            int toplam = 0;
            int aktif_asansor = 1;
            while (true)
            {
                Thread.Sleep(200); // Eklendi
                toplam = kisiler[0, 0] + kisiler[1, 1] + kisiler[2, 1] + kisiler[3, 1] + kisiler[4, 1];

                if (toplam > 20)
                {
                    aktiflik[1] = true;
                    aktif_asansor = 2;
                }
                if (toplam > 40)
                {
                    aktiflik[2] = true;
                    aktif_asansor = 3;
                }
                if (toplam > 60)
                {
                    aktiflik[3] = true;
                    aktif_asansor = 4;
                }
                if (toplam > 80)
                {
                    aktiflik[4] = true;
                    aktif_asansor = 5;
                }
                if (toplam < 10*aktif_asansor)
                {
                    if (aktif_asansor == 5)
                    {
                        aktiflik[4] = false;
                        aktif_asansor = 4;
                    }
                    else if (aktif_asansor == 4)
                    {
                        aktiflik[4] = false;
                        aktiflik[3] = false;
                        aktif_asansor = 3;
                    }
                    else if (aktif_asansor == 3)
                    {
                        aktiflik[4] = false;
                        aktiflik[3] = false;
                        aktiflik[2] = false;
                        aktif_asansor = 2;
                    }
                    else
                    {
                        aktiflik[4] = false;
                        aktiflik[3] = false;
                        aktiflik[2] = false;
                        aktiflik[1] = false;
                        aktif_asansor = 1;
                    }
                }
            }
        }
    }
}
