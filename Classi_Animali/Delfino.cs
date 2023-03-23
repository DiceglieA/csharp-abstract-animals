using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Delfino : Animal 
{
    public override void Verso()
    {
        Console.WriteLine("Fischio");
    }

    public override void Mangia()
    {
        Console.WriteLine("Acciughe, Sardine");
    }
}
