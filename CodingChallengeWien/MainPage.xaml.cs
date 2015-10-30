using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace CodingChallengeWien
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void challenge1Button_Click(object sender, RoutedEventArgs e)
        {
            var kontoNummer = "31032027080";
            var bankLeitZahl = "11000";
            var iban = Challenges.Challenge01.IbanBerechnung(kontoNummer, bankLeitZahl);

            MessageDialog dialog = new MessageDialog(iban, "Information");
            await dialog.ShowAsync();

        }

        private async void challenge2Button_Click(object sender, RoutedEventArgs e)
        {
            //00-80-41-ae-fd-7e oder 00:80:41:ae:fd:7e
            var mac1 = "00-80-41-ae-fd-7e";
            var mac2 = "00:80:41:ae:fd:7e";
            var mac3 = "UU:80:41:ae:fd:7e";

            var isMac1 = Challenges.Challenge02.MacBerechnung(mac1);
            var isMac2 = Challenges.Challenge02.MacBerechnung(mac2);
            var isMac3 = Challenges.Challenge02.MacBerechnung(mac3);

            var message = string.Format("{0}: {1}, {2}: {3}", mac1, isMac1, mac2, isMac2);
            MessageDialog dialog = new MessageDialog(message, "Information (true, true)");
            await dialog.ShowAsync();

            message = string.Format("{0}: {1}", mac3, isMac3);
            dialog = new MessageDialog(message, "Information (false)");
            await dialog.ShowAsync();

        }

    }
}
