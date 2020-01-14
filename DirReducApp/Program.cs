using System;
using System.Collections.Generic;
using System.Text;

namespace DirReducApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //args = new string[] { "NORTH", "EAST", "WEST", "SOUTH", "WEST", "WEST" };
            Directions dir = new Directions();
            string[] resultado = dir.DirReduc_versionClojure(args);
            string strToPrint = StringConstruction.getString(resultado);

            Console.WriteLine(strToPrint);

        }
    }
}
