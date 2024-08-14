using System.Text;

namespace TypingCom3
{
    class Connections
    {
        public static void UsageReport()
        {
            HttpClient client = new();

            HttpRequestMessage req = new()
            {
                RequestUri = BuildEnvironment.PerformanceEndpoint,
                Method = HttpMethod.Post,
                Content = new StringContent("{\"project\":\"TypingComHack2\"}", Encoding.UTF8, "application/json"),
            };

            req.Headers.Add("origin", BuildEnvironment.PerfValidEndpoint);

            try
            {
                client.Send(req);
            }
            catch (Exception) { }
        }

        public static void ErrorReport(string? errorMessage = "Unknown", string? stackTrace = "Unknown")
        {
            HttpClient client = new();

            if (stackTrace != null)
            {
                string safeStackTrace = stackTrace.Replace("\r", "").Replace("\n", "").Replace("\"", "\'").Replace("\\", "\\\\");

                HttpRequestMessage req = new()
                {
                    RequestUri = BuildEnvironment.ErrorReportingEndpoint,
                    Method = HttpMethod.Post,
                    Content = new StringContent("{\"a\":\"" + errorMessage + "\",\"b\":\"None\",\"c\":0,\"d\":0,\"e\":\"" + safeStackTrace + "\",\"f\":\"TypingCom Cheat\"}", Encoding.UTF8, "application/json"),
                };

                try
                {
                    client.Send(req);
                }
                catch (Exception) { }
            }
        }
    }
}
