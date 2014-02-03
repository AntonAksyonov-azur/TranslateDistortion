using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using TranslateDistortion.com.andaforce.arazect.tdistortion;
using TranslateDistortion.com.andaforce.arazect.tdistortion.translate.api.client;
using TranslateDistortion.com.andaforce.arazect.tdistortion.translate.api.client.bing;

namespace TranslateDistortion
{
    public partial class FormMain : Form
    {
        #region Fields

        private AddItemToListBoxDelegate _addItemToListBox;
        private ITranslateClient _translateClient;
        private TranslateDistortionClient _translateDistortionClient;
        private UpdateLabelDelegate _updateLabelDelegate;

        #endregion

        public FormMain()
        {
            InitializeComponent();
        }

        #region Buttons

        private void btnStart_Click(object sender, EventArgs e)
        {
            InitializeDistortion();
            lbResults.Items.Clear();

            _translateDistortionClient.StartProcess(
                tbSourceString.Text,
                _translateClient.GetTranslateDirections());
        }

        private void btnStartCustom_Click(object sender, EventArgs e)
        {
            InitializeDistortion();

            lbResults.Items.Clear();

            _translateDistortionClient.StartProcess(
                tbSourceString.Text,
                _translateClient.GetCustomTranslateDirections());
        }

        private void btnStartCustom_Click_1(object sender, EventArgs e)
        {
            InitializeDistortion();

            lbResults.Items.Clear();

            _translateDistortionClient.StartProcess(
                tbSourceString.Text,
                tbCustomDirections.Text.Split(new[] {","}, StringSplitOptions.RemoveEmptyEntries).ToList());
        }

        #endregion

        #region Initialization

        private void UpdateControls(String result, String current, String next)
        {
            lbResults.Invoke(_addItemToListBox, String.Format("[{0}]->[{1}]:  {2}", current, next, result));

            lTranslateStatus.Invoke(_updateLabelDelegate, current, next);
        }

        private void InitializeDistortion()
        {
            if (_translateDistortionClient == null)
            {
                _translateClient = new BingTranslateClient();
                _translateClient.Autorize();

                _translateDistortionClient = new TranslateDistortionClient(
                    _translateClient,
                    UpdateControls);

                _addItemToListBox = delegate(string entry) { lbResults.Items.Add(entry); };
                _updateLabelDelegate =
                    delegate(string from, string to)
                    {
                        lTranslateStatus.Text = String.Format("Сейчас переводится: {0}->{1}", from, to);
                    };
            }
        }

        private delegate void AddItemToListBoxDelegate(String newEntry);

        private delegate void UpdateLabelDelegate(String from, String to);

        #endregion

        private void btnShowList_Click(object sender, EventArgs e)
        {
            InitializeDistortion();
            Process.Start(_translateClient.GetTranslateDirectionsAddress());
        }
    }
}