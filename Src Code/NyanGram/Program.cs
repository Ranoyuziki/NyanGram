using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NyanGram
{
    internal  class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            DialogFNyanGram gram = new DialogFNyanGram();
            Console.WriteLine("[NyanGram] Waiting For Injecting...");
            gram.OpenDialogAndInject();
        }
    }
}
