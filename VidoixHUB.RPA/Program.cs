using System;
using System.Windows.Forms;
using VidoixHUB.RPA;

public static class Program
{
    [STAThread]
    private static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        var proccesies = System.Diagnostics.Process.GetProcessesByName("Rpar");

        if (proccesies.Length != 1)
            System.Diagnostics.Process.GetCurrentProcess().Kill();

        Application.Run(new MainForm());
    }
}
