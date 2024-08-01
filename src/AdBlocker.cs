namespace TypingCom3
{
    class AdBlocker
    {
        private static string[] BlockedDomains = {
            "3lift.com",
            "adlightning.com",
            "adsafeprotected.com",
            "adnxs.com",
            "amazon-adsystem.com",
            "btloader.com",
            "bugsnag.com",
            "bidswitch.net",
            "criteo.com",
            "combcompetition.com",
            "casalemedia.com",
            "cloudfront.net",
            "cloudflareinsights.com",
            "doubleclick.net",
            "facebook.net",
            "facebook.com",
            "google-analytics.com",
            "googletagmanager.com",
            "googlesyndication.com",
            "intergient.com",
            "moatads.com",
            "openx.net",
            "proper.io",
            "pub.network",
            "qualaroo.com",
            "sharethrough.com",
            "streamrail.com",
            "vuukle.com",
            "rubiconproject.com",
            "gumgum.com",
            "pubmatic.com",
            "yellowblue.io",
        };

        public static bool IsBlocked(string Uri)
        {
            for (int i = 0; i < BlockedDomains.Length; i++)
            {
                if (Uri.Contains(BlockedDomains[i]))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
