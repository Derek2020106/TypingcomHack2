using Microsoft.Web.WebView2.Core;

namespace TypingCom3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            try
            {
                _ = CoreWebView2Environment.GetAvailableBrowserVersionString();
            }
            catch (WebView2RuntimeNotFoundException)
            {
                Logger.Log("Missing WebView2 Runtime", Logger.Level.Error);
                MessageBox.Show(
                    "You don't have the Microsoft WebView2 Component installed.\nThis is a requirement to run the cheat.\nPlease install it then run the cheat again.",
                    "Fatal Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                Environment.Exit(0); // Don't call Close() because window is not initialized yet
            }

            InitializeComponent();
            LoadPreviousUser();
            SetupWebview();
        }

        private void LoadPreviousUser()
        {
            int Opens = UserConfig.Get("UsrCnf_OpenAmount");
            Logger.Log("Open Number:" + Opens);

            if (Opens != 0)
            {
                Config.TypingRate = UserConfig.Get("UsrCnf_TypingRate_Real");
                typingRateSlider.Value = UserConfig.Get("UsrCnf_TypingRate_Visual");

                Config.TypingRateVariancy = UserConfig.Get("UsrCnf_TypingRateV");
                typingRateSlider_V.Value = Config.TypingRateVariancy;

                Config.Accuracy = UserConfig.Get("UsrCnf_Accuracy");
                accuracySlider.Value = Config.Accuracy;

                Config.AccuracyVariancy = UserConfig.Get("UsrCnf_AccuracyV");
                accuracySlider_V.Value = Config.AccuracyVariancy;
            }

            Opens++;
            UserConfig.Set("UsrCnf_OpenAmount", Opens);
        }

        private async void SetupWebview()
        {
            Logger.Log("Building WebView2");
            Logger.Log("Ensuring Initialization");
            await webView.EnsureCoreWebView2Async();

            Logger.Log("Loading typing.com");
            webView.Source = new Uri("https://typing.com");
        }

        private void UI_Click_Start(object sender, EventArgs e)
        {
            Logger.Log("Manual Start Clicked");
        }

        private void UI_Slider_Accuracy_V(object sender, EventArgs e)
        {

        }

        private void UI_Slider_Accuracy(object sender, EventArgs e)
        {
            
        }

        private void UI_Slider_TypingRate_V(object sender, EventArgs e)
        {

        }

        private void UI_Slider_TypingRate(object sender, EventArgs e)
        {

        }
    }
}
