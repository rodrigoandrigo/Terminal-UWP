using ProcessUWP.ConPTY;
using ProcessUWP.ConPTY.Interop.Definitions;
using System;
using System.IO;
using Windows.UI.Core;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Input;

namespace ProcessUWP
{

    public sealed partial class MainPage : Page
    {
        public TermConPTY termConPTY;
        public MainPage()
        {
            InitializeComponent();

            termConPTY = new TermConPTY
            {
                WorkingDirectory = Directory.GetCurrentDirectory(),
                Arguments = string.Empty,
                FilterControlSequences = true,
            };

            termConPTY.OutputDataReceived += async (sender, data) =>
            {
                await Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
                {
                    Run Data1;
                    Data1 = new Run();
                    Data1.Text = data + "\n";
                    Paragrafo.Inlines.Add(Data1);
                });
            };


            ProcessInfo processInfo = termConPTY.Start();

        }
        public void TextBox1_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            if (e.Key == Windows.System.VirtualKey.Enter)
            {
                Run Text1;
                Text1 = new Run();
                Text1.Text = TextBox1.Text + "\n";
                //Paragrafo.Inlines.Add(Text1);
                termConPTY.WriteLine(TextBox1.Text);
                e.Handled = true;
            }

        }

    }

}
