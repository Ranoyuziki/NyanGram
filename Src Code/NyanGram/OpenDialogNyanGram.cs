using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;

namespace NyanGram
{

    public class DialogFNyanGram
    {

        [STAThread]
        public void OpenDialogAndInject()
        {
            Mem mem = new Mem();
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "DLL File | *.dll"; //Filter Name :D
            file.Title = "Please Select DLL File";
            file.FileName = String.Empty; //Empty File :D
            DialogResult result = DialogResult.OK;
            if(file.ShowDialog() == result)
            {
                if (mem.OpenProcess("RustClient"))
                {
                    if (mem.InjectDll(file.FileName))
                    {
                        Console.WriteLine($"[NyanGram] Injecting Is Successfulled... \nFileName: {file.FileName}");
                        Thread.Sleep(5000);
                        Environment.Exit(345);
                    }
                    else
                    {
                        Console.Write("[NyanGram] Failed To Injecting DLL...");
                        Thread.Sleep(4500);
                        Environment.Exit(0);
                    }
                }
            }
        }
    }
}
