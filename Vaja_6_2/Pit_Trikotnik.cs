using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Pit_Trikotnik
{
    private double a;
    private double b;
    private double c;

    public Pit_Trikotnik()
    {
        a = 3;
        b = 4;
        c = 5;
    }
    public Pit_Trikotnik(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public void NastaviStranice(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public double Obseg()
    {
        return (a + b + c);
    }

    public double Ploscina()
    {
        return (a * b) / 2;
    }
}

