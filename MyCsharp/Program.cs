using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MyCsharp.MyTestCode;
using MyCsharp.UI;

namespace MyCsharp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);
            Application.Run(new MyForm());
        }
    }
}