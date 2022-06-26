using CSTechTask.Concretes.Siyah;
using CSTechTask.Concretes.Beyaz;
using CSTechTask.Concretes.BosKare;

using System.Collections.Generic;
using CSTechTask.Model;
using CSTechTask.Interfaces;
using System.Linq;
using System;
using CSTechTask.Services;

namespace CSTechTask
{
    static class Program
    {
        static void Main()
        {
            string path = @"C:\Users\USER\Desktop\cozum\CSTechTask\Applicant_Assesment_Test_4_EK_AtFil\board1.txt";//input path'i.
            string board = System.IO.File.ReadAllText(path);

            List<string> taslar = board.Split(" ").ToList();// Tahta üzerindeki tüm taşların oluşturulması için kullanılacak olan listenin düzenlenmesi.  

            for (int i = 0; i < taslar.Count; i++)
            {
                taslar[i] = taslar[i].Replace("\r", "");// oluşan \r değerinin silinme işlemi.
                taslar[i] = taslar[i].Replace("\n", "");// oluşan \n değerinin silinme işlemi.
            }

            int x = 0, x1 = 0, x2 = 0, x3 = 0, x4 = 0, x5 = 0, x6 = 0, x7 = 0;// Tahtadaki satırlarda kullanılacak x değerleri.
            int y = 7;// Tahtadaki sütunlarda kullanılacak y değeri.

            double puan;// Siyah taşlardaki tehdit durumunu ölçmek için kullanılacak değer.
            double puan1; // Beyaz taşlardaki tehdit durumunu ölçmek için kullanılacak değer.

            List<SiyahPiyon> siyahPiyon = new();
            List<SiyahAt> siyahAt = new();
            List<SiyahKale> siyahKale = new();
            List<SiyahFil> siyahFil = new();
            SiyahVezir siyahVezir;
            SiyahSah siyahSah;
            List<BosKare> bosKare = new();
            List<BeyazPiyon> beyazPiyon = new();
            List<BeyazAt> beyazAt = new();
            List<BeyazKale> beyazKale = new();
            List<BeyazFil> beyazFil = new();
            BeyazVezir beyazVezir;
            BeyazSah beyazSah;
            List<Beyaz> beyazTasListesi = new(); // Beyaz taşlarda tehdit hesabı uygulanması için beyaz taşların tutulduğu liste.
            List<Siyah> siyahTasListesi = new(); // Siyah taşlarda tehdit hesabı uygulanması için siyah taşların tutulduğu liste. 



            for (int i = 0; i < 64; i++)// input değerlerine göre taşların oluşturulması ve beyaz ve siyah olarak birbirlerinden ayrılma işlemleri.
            {

                if (i < 8)
                {
                    if (taslar[i] == "ps")
                    {
                        siyahPiyon.Add(new SiyahPiyon(x, y));
                        siyahTasListesi.Add(new SiyahPiyon(x, y));
                    }
                    else if (taslar[i] == "as")
                    {
                        siyahAt.Add(new SiyahAt(x, y));
                        siyahTasListesi.Add(new SiyahAt(x, y));
                    }
                    else if (taslar[i] == "fs")
                    {
                        siyahFil.Add(new SiyahFil(x, y));
                        siyahTasListesi.Add(new SiyahFil(x, y));
                    }
                    else if (taslar[i] == "ks")
                    {
                        siyahKale.Add(new SiyahKale(x, y));
                        siyahTasListesi.Add(new SiyahKale(x, y));
                    }
                    else if (taslar[i] == "vs")
                    {
                        siyahVezir = new SiyahVezir(x, y);
                        siyahTasListesi.Add(new SiyahVezir(x, y));
                    }
                    else if (taslar[i] == "ss")
                    {
                        siyahSah = new SiyahSah(x, y);
                        siyahTasListesi.Add(new SiyahSah(x, y));
                    }
                    else if (taslar[i] == "--")
                    {
                        bosKare.Add(new BosKare(x, y));
                    }
                    else if (taslar[i] == "pb")
                    {
                        beyazPiyon.Add(new BeyazPiyon(x, y));
                        beyazTasListesi.Add(new BeyazPiyon(x, y));
                    }
                    else if (taslar[i] == "ab")
                    {
                        beyazAt.Add(new BeyazAt(x, y));
                        beyazTasListesi.Add(new BeyazAt(x, y));
                    }
                    else if (taslar[i] == "fb")
                    {
                        beyazFil.Add(new BeyazFil(x, y));
                        beyazTasListesi.Add(new BeyazFil(x, y));
                    }
                    else if (taslar[i] == "kb")
                    {
                        beyazKale.Add(new BeyazKale(x, y));
                        beyazTasListesi.Add(new BeyazKale(x, y));
                    }
                    else if (taslar[i] == "vb")
                    {
                        beyazVezir = new BeyazVezir(x, y);
                        beyazTasListesi.Add(new BeyazVezir(x, y));
                    }
                    else if (taslar[i] == "sb")
                    {
                        beyazSah = new BeyazSah(x, y);
                        beyazTasListesi.Add(new BeyazSah(x, y));
                    }
                    x++;
                }

                else if (8 <= i && i < 16)
                {
                    y = 6;

                    if (taslar[i] == "ps")
                    {
                        siyahPiyon.Add(new SiyahPiyon(x1, y));
                        siyahTasListesi.Add(new SiyahPiyon(x1, y));
                    }
                    else if (taslar[i] == "as")
                    {
                        siyahAt.Add(new SiyahAt(x1, y));
                        siyahTasListesi.Add(new SiyahAt(x1, y));
                    }
                    else if (taslar[i] == "fs")
                    {
                        siyahFil.Add(new SiyahFil(x1, y));
                        siyahTasListesi.Add(new SiyahFil(x1, y));
                    }
                    else if (taslar[i] == "ks")
                    {
                        siyahKale.Add(new SiyahKale(x1, y));
                        siyahTasListesi.Add(new SiyahKale(x1, y));
                    }
                    else if (taslar[i] == "vs")
                    {
                        siyahVezir = new SiyahVezir(x1, y);
                        siyahTasListesi.Add(new SiyahVezir(x1, y));
                    }
                    else if (taslar[i] == "ss")
                    {
                        siyahSah = new SiyahSah(x1, y);
                        siyahTasListesi.Add(new SiyahSah(x1, y));
                    }
                    else if (taslar[i] == "--")
                        bosKare.Add(new BosKare(x1, y));
                    else if (taslar[i] == "pb")
                    {
                        beyazPiyon.Add(new BeyazPiyon(x1, y));
                        beyazTasListesi.Add(new BeyazPiyon(x1, y));
                    }
                    else if (taslar[i] == "ab")
                    {
                        beyazAt.Add(new BeyazAt(x1, y));
                        beyazTasListesi.Add(new BeyazAt(x1, y));
                    }
                    else if (taslar[i] == "fb")
                    {
                        beyazFil.Add(new BeyazFil(x1, y));
                        beyazTasListesi.Add(new BeyazFil(x1, y));
                    }
                    else if (taslar[i] == "kb")
                    {
                        beyazKale.Add(new BeyazKale(x1, y));
                        beyazTasListesi.Add(new BeyazKale(x1, y));
                    }
                    else if (taslar[i] == "vb")
                    {
                        beyazVezir = new BeyazVezir(x1, y);
                        beyazTasListesi.Add(new BeyazVezir(x1, y));
                    }
                    else if (taslar[i] == "sb")
                    {
                        beyazSah = new BeyazSah(x1, y);
                        beyazTasListesi.Add(new BeyazSah(x1, y));
                    }
                    x1++;
                }
                else if (16 <= i && i < 24)
                {
                    y = 5;

                    if (taslar[i] == "ps")
                    {
                        siyahPiyon.Add(new SiyahPiyon(x2, y));
                        siyahTasListesi.Add(new SiyahPiyon(x2, y));
                    }
                    else if (taslar[i] == "as")
                    {
                        siyahAt.Add(new SiyahAt(x2, y));
                        siyahTasListesi.Add(new SiyahAt(x2, y));
                    }
                    else if (taslar[i] == "fs")
                    {
                        siyahFil.Add(new SiyahFil(x2, y));
                        siyahTasListesi.Add(new SiyahFil(x2, y));
                    }
                    else if (taslar[i] == "ks")
                    {
                        siyahKale.Add(new SiyahKale(x2, y));
                        siyahTasListesi.Add(new SiyahKale(x2, y));
                    }
                    else if (taslar[i] == "vs")
                    {
                        siyahVezir = new SiyahVezir(x2, y);
                        siyahTasListesi.Add(new SiyahVezir(x2, y));
                    }
                    else if (taslar[i] == "ss")
                    {
                        siyahSah = new SiyahSah(x2, y);
                        siyahTasListesi.Add(new SiyahSah(x2, y));
                    }
                    else if (taslar[i] == "--")
                        bosKare.Add(new BosKare(x2, y));
                    else if (taslar[i] == "pb")
                    {
                        beyazPiyon.Add(new BeyazPiyon(x2, y));
                        beyazTasListesi.Add(new BeyazPiyon(x2, y));
                    }
                    else if (taslar[i] == "ab")
                    {
                        beyazAt.Add(new BeyazAt(x2, y));
                        beyazTasListesi.Add(new BeyazAt(x2, y));
                    }
                    else if (taslar[i] == "fb")
                    {
                        beyazFil.Add(new BeyazFil(x2, y));
                        beyazTasListesi.Add(new BeyazFil(x2, y));
                    }
                    else if (taslar[i] == "kb")
                    {
                        beyazKale.Add(new BeyazKale(x2, y));
                        beyazTasListesi.Add(new BeyazKale(x2, y));
                    }
                    else if (taslar[i] == "vb")
                    {
                        beyazVezir = new BeyazVezir(x2, y);
                        beyazTasListesi.Add(new BeyazVezir(x2, y));
                    }
                    else if (taslar[i] == "sb")
                    {
                        beyazSah = new BeyazSah(x2, y);
                        beyazTasListesi.Add(new BeyazSah(x2, y));
                    }
                    x2++;
                }
                else if (24 <= i && i < 32)
                {
                    y = 4;

                    if (taslar[i] == "ps")
                    {
                        siyahPiyon.Add(new SiyahPiyon(x3, y));
                        siyahTasListesi.Add(new SiyahPiyon(x3, y));
                    }
                    else if (taslar[i] == "as")
                    {
                        siyahAt.Add(new SiyahAt(x3, y));
                        siyahTasListesi.Add(new SiyahAt(x3, y));
                    }
                    else if (taslar[i] == "fs")
                    {
                        siyahFil.Add(new SiyahFil(x3, y));
                        siyahTasListesi.Add(new SiyahFil(x3, y));
                    }
                    else if (taslar[i] == "ks")
                    {
                        siyahKale.Add(new SiyahKale(x3, y));
                        siyahTasListesi.Add(new SiyahKale(x3, y));
                    }
                    else if (taslar[i] == "vs")
                    {
                        siyahVezir = new SiyahVezir(x3, y);
                        siyahTasListesi.Add(new SiyahVezir(x3, y));
                    }
                    else if (taslar[i] == "ss")
                    {
                        siyahSah = new SiyahSah(x3, y);
                        siyahTasListesi.Add(new SiyahSah(x3, y));
                    }
                    else if (taslar[i] == "--")
                        bosKare.Add(new BosKare(x3, y));
                    else if (taslar[i] == "pb")
                    {
                        beyazPiyon.Add(new BeyazPiyon(x3, y));
                        beyazTasListesi.Add(new BeyazPiyon(x3, y));
                    }
                    else if (taslar[i] == "ab")
                    {
                        beyazAt.Add(new BeyazAt(x3, y));
                        beyazTasListesi.Add(new BeyazAt(x3, y));
                    }
                    else if (taslar[i] == "fb")
                    {
                        beyazFil.Add(new BeyazFil(x3, y));
                        beyazTasListesi.Add(new BeyazFil(x3, y));
                    }
                    else if (taslar[i] == "kb")
                    {
                        beyazKale.Add(new BeyazKale(x3, y));
                        beyazTasListesi.Add(new BeyazKale(x3, y));
                    }
                    else if (taslar[i] == "vb")
                    {
                        beyazVezir = new BeyazVezir(x3, y);
                        beyazTasListesi.Add(new BeyazVezir(x3, y));
                    }
                    else if (taslar[i] == "sb")
                    {
                        beyazSah = new BeyazSah(x3, y);
                        beyazTasListesi.Add(new BeyazSah(x3, y));
                    }
                    x3++;
                }
                else if (32 <= i && i < 40)
                {
                    y = 3;

                    if (taslar[i] == "ps")
                    {
                        siyahPiyon.Add(new SiyahPiyon(x4, y));
                        siyahTasListesi.Add(new SiyahPiyon(x4, y));
                    }
                    else if (taslar[i] == "as")
                    {
                        siyahAt.Add(new SiyahAt(x4, y));
                        siyahTasListesi.Add(new SiyahAt(x4, y));
                    }
                    else if (taslar[i] == "fs")
                    {
                        siyahFil.Add(new SiyahFil(x4, y));
                        siyahTasListesi.Add(new SiyahFil(x4, y));
                    }
                    else if (taslar[i] == "ks")
                    {
                        siyahKale.Add(new SiyahKale(x4, y));
                        siyahTasListesi.Add(new SiyahKale(x4, y));
                    }
                    else if (taslar[i] == "vs")
                    {
                        siyahVezir = new SiyahVezir(x4, y);
                        siyahTasListesi.Add(new SiyahVezir(x4, y));
                    }
                    else if (taslar[i] == "ss")
                    {
                        siyahSah = new SiyahSah(x4, y);
                        siyahTasListesi.Add(new SiyahSah(x4, y));
                    }
                    else if (taslar[i] == "--")
                        bosKare.Add(new BosKare(x4, y));
                    else if (taslar[i] == "pb")
                    {
                        beyazPiyon.Add(new BeyazPiyon(x4, y));
                        beyazTasListesi.Add(new BeyazPiyon(x4, y));
                    }
                    else if (taslar[i] == "ab")
                    {
                        beyazAt.Add(new BeyazAt(x4, y));
                        beyazTasListesi.Add(new BeyazAt(x4, y));
                    }
                    else if (taslar[i] == "fb")
                    {
                        beyazFil.Add(new BeyazFil(x4, y));
                        beyazTasListesi.Add(new BeyazFil(x4, y));
                    }
                    else if (taslar[i] == "kb")
                    {
                        beyazKale.Add(new BeyazKale(x4, y));
                        beyazTasListesi.Add(new BeyazKale(x4, y));
                    }
                    else if (taslar[i] == "vb")
                    {
                        beyazVezir = new BeyazVezir(x4, y);
                        beyazTasListesi.Add(new BeyazVezir(x4, y));
                    }
                    else if (taslar[i] == "sb")
                    {
                        beyazSah = new BeyazSah(x4, y);
                        beyazTasListesi.Add(new BeyazSah(x4, y));
                    }
                    x4++;
                }
                else if (40 <= i && i < 48)
                {
                    y = 2;

                    if (taslar[i] == "ps")
                    {
                        siyahPiyon.Add(new SiyahPiyon(x5, y));
                        siyahTasListesi.Add(new SiyahPiyon(x5, y));
                    }
                    else if (taslar[i] == "as")
                    {
                        siyahAt.Add(new SiyahAt(x5, y));
                        siyahTasListesi.Add(new SiyahAt(x5, y));
                    }
                    else if (taslar[i] == "fs")
                    {
                        siyahFil.Add(new SiyahFil(x5, y));
                        siyahTasListesi.Add(new SiyahFil(x5, y));
                    }
                    else if (taslar[i] == "ks")
                    {
                        siyahKale.Add(new SiyahKale(x5, y));
                        siyahTasListesi.Add(new SiyahKale(x5, y));
                    }
                    else if (taslar[i] == "vs")
                    {
                        siyahVezir = new SiyahVezir(x5, y);
                        siyahTasListesi.Add(new SiyahVezir(x5, y));
                    }
                    else if (taslar[i] == "ss")
                    {
                        siyahSah = new SiyahSah(x5, y);
                        siyahTasListesi.Add(new SiyahSah(x5, y));
                    }
                    else if (taslar[i] == "--")
                        bosKare.Add(new BosKare(x5, y));
                    else if (taslar[i] == "pb")
                    {
                        beyazPiyon.Add(new BeyazPiyon(x5, y));
                        beyazTasListesi.Add(new BeyazPiyon(x5, y));
                    }
                    else if (taslar[i] == "ab")
                    {
                        beyazAt.Add(new BeyazAt(x5, y));
                        beyazTasListesi.Add(new BeyazAt(x5, y));
                    }
                    else if (taslar[i] == "fb")
                    {
                        beyazFil.Add(new BeyazFil(x5, y));
                        beyazTasListesi.Add(new BeyazFil(x5, y));
                    }
                    else if (taslar[i] == "kb")
                    {
                        beyazKale.Add(new BeyazKale(x5, y));
                        beyazTasListesi.Add(new BeyazKale(x5, y));
                    }
                    else if (taslar[i] == "vb")
                    {
                        beyazVezir = new BeyazVezir(x5, y);
                        beyazTasListesi.Add(new BeyazVezir(x5, y));
                    }
                    else if (taslar[i] == "sb")
                    {
                        beyazSah = new BeyazSah(x5, y);
                        beyazTasListesi.Add(new BeyazSah(x5, y));
                    }
                    x5++;
                }
                else if (48 <= i && i < 56)
                {
                    y = 1;

                    if (taslar[i] == "ps")
                    {
                        siyahPiyon.Add(new SiyahPiyon(x6, y));
                        siyahTasListesi.Add(new SiyahPiyon(x6, y));
                    }
                    else if (taslar[i] == "as")
                    {
                        siyahAt.Add(new SiyahAt(x6, y));
                        siyahTasListesi.Add(new SiyahAt(x6, y));
                    }
                    else if (taslar[i] == "fs")
                    {
                        siyahFil.Add(new SiyahFil(x6, y));
                        siyahTasListesi.Add(new SiyahFil(x6, y));
                    }
                    else if (taslar[i] == "ks")
                    {
                        siyahKale.Add(new SiyahKale(x6, y));
                        siyahTasListesi.Add(new SiyahKale(x6, y));
                    }
                    else if (taslar[i] == "vs")
                    {
                        siyahVezir = new SiyahVezir(x6, y);
                        siyahTasListesi.Add(new SiyahVezir(x6, y));
                    }
                    else if (taslar[i] == "ss")
                    {
                        siyahSah = new SiyahSah(x6, y);
                        siyahTasListesi.Add(new SiyahSah(x6, y));
                    }
                    else if (taslar[i] == "--")
                        bosKare.Add(new BosKare(x6, y));
                    else if (taslar[i] == "pb")
                    {
                        beyazPiyon.Add(new BeyazPiyon(x6, y));
                        beyazTasListesi.Add(new BeyazPiyon(x6, y));
                    }
                    else if (taslar[i] == "ab")
                    {
                        beyazAt.Add(new BeyazAt(x6, y));
                        beyazTasListesi.Add(new BeyazAt(x6, y));
                    }
                    else if (taslar[i] == "fb")
                    {
                        beyazFil.Add(new BeyazFil(x6, y));
                        beyazTasListesi.Add(new BeyazFil(x6, y)); ;
                    }
                    else if (taslar[i] == "kb")
                    {
                        beyazKale.Add(new BeyazKale(x6, y));
                        beyazTasListesi.Add(new BeyazKale(x6, y));
                    }
                    else if (taslar[i] == "vb")
                    {
                        beyazVezir = new BeyazVezir(x6, y);
                        beyazTasListesi.Add(new BeyazVezir(x6, y));
                    }
                    else if (taslar[i] == "sb")
                    {
                        beyazSah = new BeyazSah(x6, y);
                        beyazTasListesi.Add(new BeyazSah(x6, y));
                    }
                    x6++;
                }
                else if (56 <= i && i < 64)
                {
                    y = 0;

                    if (taslar[i] == "ps")
                    {
                        siyahPiyon.Add(new SiyahPiyon(x7, y));
                        siyahTasListesi.Add(new SiyahPiyon(x7, y));
                    }
                    else if (taslar[i] == "as")
                    {
                        siyahAt.Add(new SiyahAt(x7, y));
                        siyahTasListesi.Add(new SiyahAt(x7, y));
                    }
                    else if (taslar[i] == "fs")
                    {
                        siyahFil.Add(new SiyahFil(x7, y));
                        siyahTasListesi.Add(new SiyahFil(x7, y));
                    }
                    else if (taslar[i] == "ks")
                    {
                        siyahKale.Add(new SiyahKale(x7, y));
                        siyahTasListesi.Add(new SiyahKale(x7, y));
                    }
                    else if (taslar[i] == "vs")
                    {
                        siyahVezir = new SiyahVezir(x7, y);
                        siyahTasListesi.Add(new SiyahVezir(x7, y));
                    }
                    else if (taslar[i] == "ss")
                    {
                        siyahSah = new SiyahSah(x7, y);
                        siyahTasListesi.Add(new SiyahSah(x7, y));
                    }
                    else if (taslar[i] == "--")
                        bosKare.Add(new BosKare(x7, y));
                    else if (taslar[i] == "pb")
                    {
                        beyazPiyon.Add(new BeyazPiyon(x7, y));
                        beyazTasListesi.Add(new BeyazPiyon(x7, y));
                    }
                    else if (taslar[i] == "ab")
                    {
                        beyazAt.Add(new BeyazAt(x7, y));
                        beyazTasListesi.Add(new BeyazAt(x7, y));
                    }
                    else if (taslar[i] == "fb")
                    {
                        beyazFil.Add(new BeyazFil(x7, y));
                        beyazTasListesi.Add(new BeyazFil(x7, y));
                    }
                    else if (taslar[i] == "kb")
                    {
                        beyazKale.Add(new BeyazKale(x7, y));
                        beyazTasListesi.Add(new BeyazKale(x7, y));
                    }
                    else if (taslar[i] == "vb")
                    {
                        beyazVezir = new BeyazVezir(x7, y);
                        beyazTasListesi.Add(new BeyazVezir(x7, y));
                    }
                    else if (taslar[i] == "sb")
                    {
                        beyazSah = new BeyazSah(x7, y);
                        beyazTasListesi.Add(new BeyazSah(x7, y));
                    }
                    x7++;
                }

            }
            PuanServiceSiyah a = new();//Siyah taşlarda tehdit hesabı uygulanması için oluşturulmuş nesne. 
            puan = a.PuanHesapla(beyazTasListesi, siyahTasListesi);
            Console.WriteLine("Siyah: " + puan);
            PuanServiceBeyaz b = new();//Beyaz taşlarda tehdit hesabı uygulanması için oluşturulmuş nesne. 
            puan1 = b.PuanHesapla(beyazTasListesi, siyahTasListesi);
            Console.WriteLine("Beyaz: " + puan1);
        }
    }
}