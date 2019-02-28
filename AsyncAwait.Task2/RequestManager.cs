using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwait.Task2
{
    public class RequestManager
    {
        private const string ResultRequestInfoString = "Html page length - {0} symbols";
        private const string CanceledRequestInfoString = "Request canceled";

        public string GetResponse(string uri)
        {
            var stringBuilder = new StringBuilder();
            var buf = new byte[8192];
            var request = (HttpWebRequest)WebRequest.Create(uri);
            var response = (HttpWebResponse)request.GetResponse();
            var resStream = response.GetResponseStream();
            var count = 0;

            do
            {
                count = resStream.Read(buf, 0, buf.Length);
                if (count != 0)
                {
                    stringBuilder.Append(Encoding.Default.GetString(buf, 0, count));
                }
            }
            while (count > 0);

            Thread.Sleep(5000);
            return string.Format(ResultRequestInfoString, stringBuilder.Length.ToString());
        }

        public async Task<string> GetResponseAsync(string uri, CancellationToken token)
        {
            var responce = await Task.Run(() => GetResponse(uri), token);
            return !token.IsCancellationRequested
                ? responce
                : CanceledRequestInfoString;
        }

    }
}

