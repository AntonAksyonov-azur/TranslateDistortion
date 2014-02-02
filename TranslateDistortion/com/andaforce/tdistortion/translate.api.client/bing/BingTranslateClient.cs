using System;
using System.Collections.Generic;
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

        private List<String> _translateLanguages;

        public void Autorize()
        {
            _admAuthentication = new AdmAuthentication(AppId, AppSecret);
            _token = _admAuthentication.GetAccessToken();
        }

        public List<String> GetTranslateDirections()
        {
            // I can get all available languages with http://api.microsofttranslator.com/V2/Http.svc/GetLanguagesForTranslate
            //return PerformWebRequest<>()

            return _translateLanguages ??
                   (_translateLanguages =
                       PerformWebRequest<List<String>>(
                           "http://api.microsofttranslator.com/V2/Http.svc/GetLanguagesForTranslate"));
        }

        public List<String> GetCustomTranslateDirections()
        {
            return new List<string>()
            {
                "en",
                "de",
                "fr",
                "it",

            }
        }


        public string GetTranslation(string text, string fromLang, string toLang)
        {
            String uri = String.Format("{0}&text={1}&from={2}&to={3}",
                ApiAddress, HttpUtility.UrlEncode(text), fromLang, toLang);

            return PerformWebRequest<String>(uri);
        }
        
        public String GetRussianTranslationId()
        {
            return "ru";
        }

        private T PerformWebRequest<T>(String address)
        {
            var httpWebRequest = (HttpWebRequest) WebRequest.Create(address);

            String authToken = "Bearer" + " " + _token.access_token;
            httpWebRequest.Headers.Add("Authorization", authToken);

            WebResponse response = httpWebRequest.GetResponse();
            Stream stream = response.GetResponseStream();
            if (stream != null)
            {
                var dcs = new DataContractSerializer(typeof (T));
                var content = (T) dcs.ReadObject(stream);

                return content;
            }
            Console.WriteLine("Error while reading request!");

            return default(T);
        }
    }
}