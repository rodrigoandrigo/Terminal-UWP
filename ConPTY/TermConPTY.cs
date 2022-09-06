using ProcessUWP;
using ProcessUWP.ConPTY.Interop.Definitions;
using Windows.UI.Xaml.Controls;

namespace ProcessUWP.ConPTY
{
    /// <summary>
    /// SteamCMD ConPTY
    /// </summary>
    public class TermConPTY : WindowsPseudoConsole
    {

        public new ProcessInfo Start(short width = 120, short height = 30)
        {
            FileName = "Terminal.exe";

            return base.Start(width, height);
        }
    }
}
