using System;
using System.Collections.Generic;
using System.Text;

namespace HerancaMultipla.Devices
{
    //Posso herdar de uma classe e também implementar uma interface
    class Printer : Device, IPrinter
    {
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Printer processing: " + document);
        }
        public void Print(string document)
        {
            Console.WriteLine("Printer print: " + document);
        }
    }
}
