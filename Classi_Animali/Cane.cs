using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Cane : Animal
{
    public override void Verso()
    {
        Console.WriteLine("Abbaiare");
    }

    public override void Mangia()
    {
        Console.WriteLine("Croccantini");
    }
}
