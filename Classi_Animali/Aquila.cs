using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Aquila : Animal
{
    public override void Verso()
    {
        Console.WriteLine("Strido");
    }

    public override void Mangia()
    {
        Console.WriteLine("Mammiferi,Uccelli");
    }
}
