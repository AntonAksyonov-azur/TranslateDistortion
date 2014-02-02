using System;
using System.Threading;
using TranslateDistortion.com.andaforce.tdistortion.translate.api.client;

namespace TranslateDistortion.com.andaforce.tdistortion
{
    public class TranslateDistortionClient
    {
        public delegate void OnTranslateIterationCompleteDelegate(String translationResult);

        private readonly ITranslateClient _translateApiClient;
        private String _currentLangDirection = "ru";
        private String _currentResult;
        private String[] _langDirections;

        private OnTranslateIterationCompleteDelegate _onTranslateIterationComplete;
        private String _sourceString;

        public TranslateDistortionClient(
            ITranslateClient translateApiClient,
            OnTranslateIterationCompleteDelegate onTranslateIterationComplete)
        {
            _translateApiClient = translateApiClient;
            _onTranslateIterationComplete = onTranslateIterationComplete;
        }

        public void StartProcess(String sourceString, String[] langDirections)
        {
            _langDirections = langDirections;
            _sourceString = sourceString;

            _currentResult = sourceString;
            _currentLangDirection = "ru";

            ThreadPool.QueueUserWorkItem(TranslationStep);
        }

        private void TranslationStep(object state)
        {
            foreach (string toLang in _langDirections)
            {
                _currentResult = _translateApiClient.GetTranslation(
                    _currentResult,
                    _currentLangDirection, toLang);

                _onTranslateIterationComplete.Invoke(_currentResult);

                Thread.Sleep(100);
            }
        }
    }
}