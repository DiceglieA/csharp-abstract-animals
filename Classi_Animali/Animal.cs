using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Animal
{
    public void Dormi() => Console.WriteLine("ZZZ");
    public abstract void Verso();
    public abstract void Mangia();
}
