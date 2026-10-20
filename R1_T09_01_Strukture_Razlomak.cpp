#include <iostream>
#include <cmath>
using namespace std;

struct Razlomak
{
  int brojilac, imenilac;
};

int NZD(int a, int b)
{
    while (b != 0)
    {
        int tmp = a % b;
        a = b;
        b = tmp;
    }
    return a;
}

void skrati(Razlomak &r)
{
   int nzd = NZD(r.brojilac, r.imenilac);
   r.brojilac /= nzd;
   r.imenilac /= nzd;
}

Razlomak saberi(const Razlomak &a, const Razlomak &b)
{
    Razlomak r;
    r.brojilac = a.brojilac * b.imenilac + a.imenilac * b.brojilac;
    r.imenilac = a.imenilac * b.imenilac;
    skrati(r);
    return r;
}

Razlomak mnozi(const Razlomak &a, const Razlomak &b)
{
    Razlomak r;
    r.brojilac = a.brojilac * b.brojilac;
    r.imenilac = a.imenilac * b.imenilac;
    skrati(r);
    return r;
}

Razlomak ucitaj()
{
    Razlomak r;
    char c;
    cin >> r.brojilac >> c >> r.imenilac;
    skrati(r);
    return r;
}

void ispisi(const Razlomak &r)
{
    cout << r.brojilac << "/" << r.imenilac << endl;
}

int main()
{
    Razlomak a = ucitaj();
    Razlomak b = ucitaj();
    ispisi(saberi(a, b));
    ispisi(mnozi(a, b));
    return 0;
}
