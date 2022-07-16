using Newtonsoft.Json;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Linq;

namespace Resume_PDF
{
    public partial class Form1 : Form
    {
        private readonly string _fileName = @"C:\Users\tilos\source\repos\Resume PDF\Resume.json";
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_generate_Click(object sender, EventArgs e)
        {

        }
    }
}