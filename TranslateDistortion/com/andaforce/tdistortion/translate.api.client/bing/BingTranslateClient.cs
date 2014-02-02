using System;
using System.IO;
using System.Net;
using System.Runtime.Serialization;
using System.Web;

namespace TranslateDistortion.com.andaforce.tdistortion.translate.api.client.bing
{
    public class BingTranslateClient : ITranslateClient
    {
        private const String ApiAddress = "http://api.microsofttranslator.com/v2/Http.svc/Translate?";
        private const String AppId = "TranslateDistortion";
        private const String AppSecret = "Hu3X0ReH8ETW8U+dJ77KyciC8qlZFTC+A95EWnAwTKU=";

        private AdmAuthentication _admAuthentication;
        private AdmAccessToken _token;

        public void Autorize()
        {
            _admAuthentication = new AdmAuthentication(AppId, AppSecret);
            _token = _admAuthentication.GetAccessToken();
        }

        public string[] GetTranslateDirections()
        {
            throw new NotImplementedException();
        }

        public string GetTranslation(string text, string fromLang, string toLang)
        {
            String uri = String.Format("{0}&text={1}&from={2}&to={3}",
                ApiAddress, HttpUtility.UrlEncode(text), fromLang, toLang);
            String authToken = "Bearer" + " " + _token.access_token;

            var httpWebRequest = (HttpWebRequest) WebRequest.Create(uri);
            httpWebRequest.Headers.Add("Authorization", authToken);

            WebResponse response = httpWebRequest.GetResponse();
            Stream stream = response.GetResponseStream();
            if (stream != null)
            {
                var dcs = new DataContractSerializer(Type.GetType("System.String"));
                var content = (string) dcs.ReadObject(stream);

                return content;
            }
            Console.WriteLine("Error while reading request!");

            return String.Empty;
        }
    }
}