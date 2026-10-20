using System;

class R1_T09_01_Strukture_Knjiga
{
    struct Razlomak
    {
        public int brojilac, imenilac;
    }
    static Razlomak ucitaj()
    {
        Razlomak r;
        string[] s = Console.ReadLine().Split('/');
        r.brojilac = int.Parse(s[0]);
        r.imenilac = int.Parse(s[1]);
        skrati(ref r);
        return r;
    }
    static void ispisi(Razlomak r)
    {
        Console.WriteLine(r.brojilac + "/" + r.imenilac);
    }
    static Razlomak saberi(Razlomak a, Razlomak b)
    {
        Razlomak r;
        r.brojilac = a.brojilac * b.imenilac + 
            a.imenilac * b.brojilac;
        r.imenilac = a.imenilac * b.imenilac;
        skrati(ref r);
        return r;
    }
    static Razlomak mnozi(Razlomak a, Razlomak b)
    {
        Razlomak r;
        r.brojilac = a.brojilac * b.brojilac;
        r.imenilac = a.imenilac * b.imenilac;
        skrati(ref r);
        return r;
    }

    static int NZD(int a, int b)
    {
        while (b != 0)
        {
            int p = a % b;
            a = b;
            b = p;
        }
        return a;
    }
    static void skrati(ref Razlomak r)
    {
        int nzd = NZD(r.brojilac, r.imenilac);
        r.brojilac /= nzd;
        r.imenilac /= nzd;
    }
    static void Main()
    {
        Razlomak r1 = ucitaj();
        Razlomak r2 = ucitaj();
        ispisi(saberi(r1, r2));
        ispisi(mnozi(r1, r2));
    }
}
