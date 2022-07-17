using System.Text.Json;
using PdfSharp;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using System.Diagnostics;
using System.Text;

namespace Resume_PDF
{
    public partial class Form1 : Form
    {
        private readonly string _fileName = @"C:\Users\tilos\source\repos\Resume PDF\Resume.json";
        public Form1()
        {
            InitializeComponent();
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            string filename = @"F:\PDF Resume\Resume.json";
            string jsonstring = File.ReadAllText(filename);
            Resume resume = JsonSerializer.Deserialize<Resume>(jsonstring)!;
        }

        public class Resume
        {
            public string FullName { get; set; }
            public string Job { get; set; }
            public string Experience { get; set; }
            public string EducCol { get; set; }
            public string EducYr1 { get; set; }
            public string EducSHS { get; set; }
            public string EducYr2 { get; set; }
            public string EducJRH { get; set; }
            public string EducYr3 { get; set; }
            public string EducElem { get; set; }
            public string EducYr4 { get; set; }
            public string SpecAward1 { get; set; }
            public string SpecAward2 { get; set; }
            public string SpecAward3 { get; set; }
            public string SpecAward4 { get; set; }
            public string RefName { get; set; }
            public string RefJob { get; set; }
            public string RefNo { get; set; }
            public string SoftwareSkills { get; set; }
            public string SSkills1 { get; set; }
            public string SSkills2 { get; set; }
            public string SSkills3 { get; set; }
            public string HardwareSkills { get; set; }
            public string HSkills1 { get; set; }
            public string HSkills2 { get; set; }
            public string LiteracySkills { get; set; }
            public string LSkills1 { get; set; }
            public string LSkills2 { get; set; }
            public string LSkills3 { get; set; }
            public string LSkills4 { get; set; }
            public string LSkills5 { get; set; }
            public string InfoEmail { get; set; }
            public string InfoWebsite { get; set; }
            public string InfoLI { get; set; }
            public string InfoNo { get; set; }
        }
        private void btn_generate_Click(object sender, EventArgs e)
        {
        
    }
    }
}