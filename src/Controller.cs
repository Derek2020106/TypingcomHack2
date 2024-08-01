using Microsoft.Web.WebView2.WinForms;

namespace TypingCom3
{
    class Controller
    {
        public async static void SimulateTypingText(string Text, WebView2 webView)
        {
            Config.CheatRunning = true;
            Logger.Log("Func SimulateTypingText Running");

            int TypingRate = CalculateVariancy(Config.TypingRate, Config.TypingRateVariancy, Min: 10);
            int Accuracy = CalculateVariancy(Config.Accuracy, Config.AccuracyVariancy, Max: 100);

            char[] InvalidCharacters = { '`', '~', '@', '#', '$', '%', '^', '&', '*', '(', ')' };
            char[] Letters = Text.Replace("\u00A0", " ").ToCharArray();

            int LettersLength = Letters.Length;
            int MissIndex = 0;

            int LettersToMiss = (int)Math.Floor(LettersLength * ((decimal)(100 - Accuracy) / 100));
            int MaxIndex = (int)Math.Floor(LettersLength / (decimal)(LettersToMiss + 1));

            for (int i = 0; i < LettersLength; i++)
            {
                char Letter = Letters[i];
                string Args;

                if (Letter == 32)
                {
                    Args = @"{ ""type"": ""char"", ""keyIdentifier"": ""U+0020"", ""text"": "" "", ""code"": ""Space"", ""key"": "" "" }";
                }
                else
                {
                    Args = @"{ ""type"": ""char"", ""text"": """ + GetEscapeSequence(Letter) + @""" }";
                }

                _ = await webView.CoreWebView2.CallDevToolsProtocolMethodAsync("Input.dispatchKeyEvent", Args);

                if (MissIndex == MaxIndex)
                {
                    Args = @"{""type"": ""char"", ""text"": """ + InvalidCharacters.Sample() + @"""}";
                    _ = await webView.CoreWebView2.CallDevToolsProtocolMethodAsync("Input.dispatchKeyEvent", Args);
                    MissIndex = 0;
                }
                else
                {
                    MissIndex++;
                }

                if (TypingRate != 10)
                {
                    await Task.Delay((int)(Math.Sin(i) * 10 + TypingRate));
                }
            }

            Logger.Log("Finished Typing");
            Config.CheatRunning = false;
        }

        private static string GetEscapeSequence(char c)
        {
            return "\\u" + ((int)c).ToString("X4");
        }

        /**
         * @param int       Base amount to change
         * @param int       + or - amount to change
         * @param int       Maximum value
         * @param int       Minimum value
         * @returns int     Fully modified base value
         */
        private static int CalculateVariancy(int Base, int Variancy, int Max = 0, int Min = 0)
        {
            Random RandGen = new();

            Base += RandGen.Next(-Variancy, Variancy);
            if (Max != 0 && Base > Max) Base = Max;
            if (Min != 0 && Base < Min) Base = Min;

            return Base;
        }
    }

    public static class ArrayExtension
    {
        public static char Sample(this char[] array)
        {
            return array[Random.Shared.Next(0, array.Length - 1)];
        }
    }
}
