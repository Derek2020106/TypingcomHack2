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

            Text = "Typing.com Cheat v" + Updates.VersionCode;
        }

        private void LoadPreviousUser()
        {
            int Opens = UserConfig.Get("UsrCnf_OpenAmount");
            Logger.Log("Open Number:" + Opens);

            if (Opens != 0)
            {
                try
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
                catch (Exception)
                {
                    UserConfig.Reset();
                }
            }

            Opens++;
            UserConfig.Set("UsrCnf_OpenAmount", Opens);
        }

        private async void SetupWebview()
        {
            Logger.Log("Building WebView2");
            Logger.Log("Ensuring Initialization");
            await webView.EnsureCoreWebView2Async();

            Logger.Log("Hooking Request and Message Events");
            webView.CoreWebView2.WebResourceRequested += RequestBlocker;
            webView.CoreWebView2.WebResourceResponseReceived += InPageAdBlock;
            webView.CoreWebView2.WebMessageReceived += WebMessageRecieved;
            webView.CoreWebView2.AddWebResourceRequestedFilter(
                null,
                CoreWebView2WebResourceContext.All
            );

            Logger.Log("Loading typing.com");
            webView.Source = new Uri("https://typing.com");
        }

        private void UI_Click_Start(object sender, EventArgs e)
        {
            Logger.Log("Manual Start Clicked");
            webView.ExecuteScriptAsync(
                @"if(document.getElementsByClassName('raceChat').length ? false : true) {
                    z = document.getElementsByClassName('letter');
                    m='';
                    for(let i = 0; i < z.length; i++) {
                        m = m + z[i].innerText;
                    };
                    window.chrome.webview.postMessage(''+m);
                } else {
                    window.chrome.webview.postMessage('GAME_NOT_STARTED_ERROR');
                }"
            );
        }

        private void UI_Click_Discord(object sender, EventArgs e)
        {
            Logger.Log("Discord Button Clicked");
            System.Diagnostics.Process.Start("explorer.exe", BuildEnvironment.DiscordLink);
        }

        private void UI_Slider_Accuracy_V(object sender, EventArgs e)
        {
            accuracySlider_V_L.Text = "Accuracy Variance: ±" + accuracySlider_V.Value;
            Config.AccuracyVariancy = accuracySlider_V.Value;
        }

        private void UI_Slider_Accuracy(object sender, EventArgs e)
        {
            accuracySlider_L.Text = "Accuracy: " + accuracySlider.Value + "%";
            Config.Accuracy = accuracySlider.Value;
        }

        private void UI_Slider_TypingRate_V(object sender, EventArgs e)
        {
            typingRateSlider_V_L.Text = "Typing Rate Variance: ±" + typingRateSlider_V.Value;
            Config.TypingRateVariancy = typingRateSlider_V.Value;
        }

        private void UI_Slider_TypingRate(object sender, EventArgs e)
        {
            int Total = typingRateSlider.Maximum + typingRateSlider.Minimum;
            int RealRate = Total - typingRateSlider.Value;
            Config.TypingRate = RealRate;
            int WPMCalculation = (int)(60 / ((double)RealRate / 1000) / 5);
            typingRateSlider_L.Text = "Typing Rate: ~" + WPMCalculation;
            UserConfig.Set("UsrCnf_TypingRate_Visual", typingRateSlider.Value);
        }

        private void InPageAdBlock(object? sender, CoreWebView2WebResourceResponseReceivedEventArgs e)
        {
            webView.ExecuteScriptAsync(
                @"setInterval(() => {
                    const tmpx = document.querySelectorAll('.advert');
                    for (let i = 0; i < tmpx.length; i++) {
                        tmpx[i].remove();
                    }
                }, 100);"
            );
        }

        private void WebMessageRecieved(object? sender, CoreWebView2WebMessageReceivedEventArgs e)
        {
            if (!Config.CheatRunning)
            {
                string BrowserData = e.TryGetWebMessageAsString();
                Logger.Log("Web Message Recieved");

                if (BrowserData == "GAME_NOT_STARTED_ERROR")
                {
                    MessageBox.Show(
                        "The test hasn't started yet.",
                        "Internal Error",
                        MessageBoxButtons.OK
                    );
                }
                else
                {
                    Controller.SimulateTypingText(BrowserData, webView);
                }
            }
        }

        private void RequestBlocker(object? sender, CoreWebView2WebResourceRequestedEventArgs e)
        {
            bool Blocked = AdBlocker.IsBlocked(e.Request.Uri);

            if (Blocked)
            {
                e.Response = webView.CoreWebView2.Environment.CreateWebResourceResponse(
                    null,
                    404,
                    "Resource Blocked by Client",
                    null
                );
            }
        }
    }
}
