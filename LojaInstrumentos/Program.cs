using System.Windows.Forms;

namespace LojaInstrumentos;

internal static class Program
{
    [STAThread]
    private static void Main()
    {
        ApplicationConfiguration.Initialize();

        using (var splash = new FormSplash())
        {
            if (splash.ShowDialog() != DialogResult.OK)
            {
                return;
            }
        }

        Application.Run(new FormPrincipal());
    }
}
