using System;
using System.Text;
using System.Net;
using System.Threading;

namespace ConsoleSimpleIpBasedServer
{
    internal class Program
    { 
        public static string htmlContent = "<!DOCTYPE html>" + 
            "<html>" +
                "<head>" +
                    "<title> C# website example</title>" +
                    "<meta charset=\"utf-8\">" +
                "</head>" +
                "<body>" +
                    "<h1>TTITLE</h1>" +
                    "<h2>Subtitle</h2>" +
                    "<p>lorem ipsum</p>" +
                "</body>" +
            "</html>";
        public static string unknownPage = "<!DOCTYPE html>" +
            "<html>" +
                "<head>" +
                    "<title> C# website example</title>" +
                    "<meta charset=\"utf-8\">" +
                "</head>" +
                "<noscript>no JS</noscript>" +
                "<body>Unknown website.</body>"+
            "</html>";
        static void Main(string[] args)
        {
            string url = "https://localhost:9000/";
            byte[] dados = new byte[255];
            StringBuilder standby = new StringBuilder();
            HttpListener listener = new HttpListener();
            listener.Prefixes.Add(url);
            listener.Start();
            Console.WriteLine("Starting server in "+url);

            bool isRunning = true;

            // GET method:
            while (isRunning)
            {
                standby.Append(".");
                Console.Write(standby);
                Thread.Sleep(1000);
                HttpListenerContext connectContext = listener.GetContext(); // waiting server connections.
                Console.WriteLine("Established connection.");
                HttpListenerRequest request = connectContext.Request;       // Established connection.
                HttpListenerResponse response = connectContext.Response;    // Resp object.

                if (request.HttpMethod == "GET")                            // Can be POST method too.
                {
                    switch(request.Url.AbsolutePath)
                    {
                        case "/favicon.ico": dados = new byte[0]; break;
                        case "/index": Encoding.UTF8.GetBytes(htmlContent); break;
                        default: Encoding.UTF8.GetBytes(unknownPage); break;
                    }
                }
                else
                {
                    dados = Encoding.UTF8.GetBytes(unknownPage);
                }
                // Adding response:
                response.ContentType = "text/html";
                response.ContentEncoding = Encoding.UTF8;
                response.ContentLength64 = dados.LongLength;
                response.OutputStream.WriteAsync(dados, 0, dados.Length);
                response.Close();
            }
            listener.Close();
        }
    }
}
