using System;

namespace TranslateDistortion.com.andaforce.tdistortion.translate.api.client
{
    public interface ITranslateClient
    {
        void Autorize();
        String GetTranslation(String text, String fromLang, String toLang);
        String[] GetTranslateDirections();
    }
}