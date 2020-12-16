using System;
using System.Windows.Forms;
using VidoixHUB.Farmer.Forms;

static class Program
{
    [STAThread]
    static void Main(string[] args)
    {
#if DEBUG
        Username = "betterThanYou";
        Password = "FM97sivas57";
        Width = 575;
        Heigth = 300;
#else
        if (args.Length != 5)
            System.Diagnostics.Process.GetCurrentProcess().Kill();

        try
        {
            Username = args[0];
            Password = args[1];
            ThreadName = args[2];
            Width = int.Parse(args[3]);
            Heigth = int.Parse(args[4]);
            ErrorWaitTime = int.Parse(args[5]);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }
#endif

        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new WebForm());
    }
    public static string Username;
    public static string Password;
    public static string ThreadName;
    public static int Width;
    public static int Heigth;
    public static int ErrorWaitTime;
}