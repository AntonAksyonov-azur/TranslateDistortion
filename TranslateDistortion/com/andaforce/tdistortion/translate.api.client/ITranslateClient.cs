﻿using System;
using System.Collections.Generic;

namespace TranslateDistortion.com.andaforce.tdistortion.translate.api.client
{
    public interface ITranslateClient
    {
        void Autorize();
        String GetTranslation(String text, String fromLang, String toLang);
        List<String> GetTranslateDirections();
        List<String> GetCustomTranslateDirections();
        String GetRussianTranslationId();
    }
}