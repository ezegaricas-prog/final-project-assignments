using System;
using System.Windows.Forms;

// Name: Ezequiel Barrientos
// Class: ITD 2343
// Semester: Fall 2025
// Due Date: October 31, 2025

namespace OperationsApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
