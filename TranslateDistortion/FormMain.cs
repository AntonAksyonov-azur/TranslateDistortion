using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using TranslateDistortion.com.andaforce.tdistortion.translate.api.client.bing;

namespace TranslateDistortion
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var translator = new BingTranslateClient();
            translator.Autorize();
            var str = translator.GetTranslation("Hello world!", "en", "ru");
            var list = translator.GetTranslateDirections();

            var a = 1;
        }
    }
}
