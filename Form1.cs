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
            string FileName = @"F:\PDF Resume\Resume.json";
            string jsonfile = File.ReadAllText(FileName);
            Resume resume = JsonSerializer.Deserialize<Resume>(jsonfile)!;
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
            string FileName = @"F:\PDF Resume\Resume.json";
            string jsonfile = File.ReadAllText(FileName);
            Resume jsonresume = JsonSerializer.Deserialize<Resume>(jsonfile)!;

            string FullName = jsonresume.FullName;
            string Job = jsonresume.Job;
            string Experience = jsonresume.Experience;

            string EducCol = jsonresume.EducCol;
            string EducYr1 = jsonresume.EducYr1;
            string EducSHS = jsonresume.EducSHS;
            string EducYr2 = jsonresume.EducYr2;
            string EducJRH = jsonresume.EducJRH;
            string EducYr3 = jsonresume.EducYr3;
            string EducElem = jsonresume.EducElem;
            string EducYr4 = jsonresume.EducYr4;

            string SpecAward1 = jsonresume.SpecAward1;
            string SpecAward2 = jsonresume.SpecAward2;
            string SpecAward3 = jsonresume.SpecAward3;
            string SpecAward4 = jsonresume.SpecAward4;

            string RefName = jsonresume.RefName;
            string RefJob = jsonresume.RefJob;
            string RefNo = jsonresume.RefNo;

            string SoftwareSkills = jsonresume.SoftwareSkills;
            string SSkills1 = jsonresume.SSkills1;
            string SSkills2 = jsonresume.SSkills2;
            string SSkills3 = jsonresume.SSkills3;
            string HardwareSkills = jsonresume.HardwareSkills;
            string HSkills1 = jsonresume.HSkills1;
            string HSkills2 = jsonresume.HSkills2;
            string LiteracySkills = jsonresume.LiteracySkills;
            string LSkills1 = jsonresume.LSkills1;
            string LSkills2 = jsonresume.LSkills2;
            string LSkills3 = jsonresume.LSkills3;
            string LSkills4 = jsonresume.LSkills4;
            string LSkills5 = jsonresume.LSkills5;

            string InfoEmail = jsonresume.InfoEmail;
            string InfoWebsite = jsonresume.InfoWebsite;
            string InfoLI = jsonresume.InfoLI;
            string InfoNo = jsonresume.InfoNo;

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {

            }
        }
    }
}