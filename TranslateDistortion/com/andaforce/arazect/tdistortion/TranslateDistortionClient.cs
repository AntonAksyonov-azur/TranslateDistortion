using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using TranslateDistortion.com.andaforce.arazect.tdistortion.translate.api.client;

namespace TranslateDistortion.com.andaforce.arazect.tdistortion
{
    public class TranslateDistortionClient
    {
        public delegate void OnTranslateIterationCompleteDelegate(
            String translationResult,
            String translationResultLang,
            String translationNextStepLang);

        private readonly OnTranslateIterationCompleteDelegate _onTranslateIterationComplete;

        private readonly ITranslateClient _translateApiClient;
        private String _currentResult;
        private List<String> _langDirections;

        public TranslateDistortionClient(
            ITranslateClient translateApiClient,
            OnTranslateIterationCompleteDelegate onTranslateIterationComplete)
        {
            _translateApiClient = translateApiClient;
            _onTranslateIterationComplete = onTranslateIterationComplete;
        }


        public void StartProcess(String sourceString, List<String> langDirections)
        {
            _langDirections = langDirections.ToList();
            _currentResult = sourceString;

            _langDirections.Insert(0, _translateApiClient.GetRussianTranslationId());
            _langDirections.Add(_translateApiClient.GetRussianTranslationId());

            ThreadPool.QueueUserWorkItem(TranslationStep);
        }

        private void TranslationStep(object state)
        {
            for (int i = 0; i < _langDirections.Count - 1; i++)
            {
                _currentResult = _translateApiClient.GetTranslation(
                    _currentResult,
                    _langDirections[i], _langDirections[i + 1]);

                _onTranslateIterationComplete.Invoke(
                    _currentResult,
                    _langDirections[i],
                    _langDirections[i + 1]);

                Thread.Sleep(100);
            }
        }
    }
}