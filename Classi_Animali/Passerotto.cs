using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Passerotto : Animal
{
    public override void Verso()
    {
        Console.WriteLine("Cinguettio");
    }

    public override void Mangia()
    {
        Console.WriteLine("Semi, Cereali");
    }
}