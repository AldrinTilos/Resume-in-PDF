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
                saveFileDialog.InitialDirectory = @"F:\PDF Resume\PDF\Resume";
                saveFileDialog.FileName = FullName + ".pdf";
                saveFileDialog.Filter = "PDF|*.pdf";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    PdfDocument pdf = new PdfDocument();
                    pdf.Info.Title = FullName + "_" + "Resume";
                    PdfPage page = pdf.AddPage();


                    XGraphics graph = XGraphics.FromPdfPage(page);

                    XFont namefont = new XFont("Franklin Gothic Demi", 30, XFontStyle.Bold);
                    XFont titlefont = new XFont("Franklin Gothic Demi", 16, XFontStyle.Bold);
                    XFont infofont = new XFont("Rockwell", 12, XFontStyle.Regular);

                    XPen shadename = new XPen(XColors.SandyBrown, 50);
                    XPen lineR = new XPen(XColors.Brown, 2);
                    XPen lineL = new XPen(XColors.Brown, 2);

                    int marginL = 25;
                    int marginL1 = 200;


                    string jpg = @"F:\PDF Resume\PDF\pic.jpg";
                    XImage image = XImage.FromFile(jpg);
                    graph.DrawImage(image, marginL, 50, 125, 125);

                    graph.DrawString("PERSONAL INFO", titlefont, XBrushes.Black, new XRect(marginL, marginL1 + 5, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

                    graph.DrawRectangle(lineL, marginL, marginL1 + 25, 170, 2);

                    graph.DrawString(InfoEmail, infofont, XBrushes.Black, new XRect(marginL, marginL1 + 30, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(InfoWebsite, infofont, XBrushes.Black, new XRect(marginL, marginL1 + 45, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(InfoLI, infofont, XBrushes.Black, new XRect(marginL, marginL1 + 60, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(InfoNo, infofont, XBrushes.Black, new XRect(marginL, marginL1 + 75, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

                    graph.DrawString("SKILLS", titlefont, XBrushes.Black, new XRect(marginL, marginL1 + 95, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

                    graph.DrawRectangle(lineL, marginL, marginL1 + 115, 170, 2);

                    graph.DrawString(SoftwareSkills, infofont, XBrushes.Black, new XRect(marginL, marginL1 + 120, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(SSkills1, infofont, XBrushes.Black, new XRect(marginL, marginL1 + 135, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(SSkills2, infofont, XBrushes.Black, new XRect(marginL, marginL1 + 150, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(SSkills3, infofont, XBrushes.Black, new XRect(marginL, marginL1 + 165, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

                    graph.DrawString(HardwareSkills, infofont, XBrushes.Black, new XRect(marginL, marginL1 + 185, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(HSkills1, infofont, XBrushes.Black, new XRect(marginL, marginL1 + 200, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(HSkills2, infofont, XBrushes.Black, new XRect(marginL, marginL1 + 215, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

                    graph.DrawString(LiteracySkills, infofont, XBrushes.Black, new XRect(marginL, marginL1 + 235, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(LSkills1, infofont, XBrushes.Black, new XRect(marginL, marginL1 + 250, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(LSkills2, infofont, XBrushes.Black, new XRect(marginL, marginL1 + 265, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(LSkills3, infofont, XBrushes.Black, new XRect(marginL, marginL1 + 280, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(LSkills4, infofont, XBrushes.Black, new XRect(marginL, marginL1 + 295, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(LSkills5, infofont, XBrushes.Black, new XRect(marginL, marginL1 + 310, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

                    graph.DrawString("REFERENCE", titlefont, XBrushes.Black, new XRect(marginL, marginL1 + 330, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

                    graph.DrawRectangle(lineL, marginL, marginL1 + 350, 170, 2);

                    graph.DrawString(RefName, infofont, XBrushes.Black, new XRect(marginL, marginL1 + 355, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(RefJob, infofont, XBrushes.Black, new XRect(marginL, marginL1 + 370, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(RefNo, infofont, XBrushes.Black, new XRect(marginL, marginL1 + 385, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

                    int marginT = 370;
                    int marginT1 = 200;

                    int marginright1 = 575;
                    int initialright1 = 200;

                    graph.DrawRectangle(shadename, marginright1, initialright1 - 110, -400, 50);

                    graph.DrawString(FullName, namefont, XBrushes.Black, new XRect(marginT, marginT1 - 120, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

                    int marginT3 = 470;
                    int marginT4 = 200;

                    graph.DrawString(Job, titlefont, XBrushes.Black, new XRect(marginT3, marginT4 - 90, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

                    int marginR = 220;
                    int marginR1 = 200;

                    graph.DrawString("EXPERIENCE", titlefont, XBrushes.Black, new XRect(marginR, marginR1, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

                    graph.DrawRectangle(lineR, marginR, marginR1 + 25, 350, 2);

                    graph.DrawString(Experience, infofont, XBrushes.Black, new XRect(marginR, marginR1 + 30, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

                    marginR1 = marginR1 + 100;

                    graph.DrawString("EDUCATION", titlefont, XBrushes.Black, new XRect(marginR, marginR1, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

                    graph.DrawRectangle(lineR, marginR, marginR1 + 25, 350, 2);

                    graph.DrawString(EducCol, infofont, XBrushes.Black, new XRect(marginR, marginR1 + 30, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(EducYr1, infofont, XBrushes.Black, new XRect(marginR, marginR1 + 45, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(EducSHS, infofont, XBrushes.Black, new XRect(marginR, marginR1 + 60, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(EducYr2, infofont, XBrushes.Black, new XRect(marginR, marginR1 + 75, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(EducJRH, infofont, XBrushes.Black, new XRect(marginR, marginR1 + 90, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(EducYr3, infofont, XBrushes.Black, new XRect(marginR, marginR1 + 105, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(EducElem, infofont, XBrushes.Black, new XRect(marginR, marginR1 + 120, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(EducYr4, infofont, XBrushes.Black, new XRect(marginR, marginR1 + 135, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

                    marginR1 = marginR1 + 180;

                    graph.DrawString("SPECIAL AWARDS/ HONORS/ CERTIFICATES", titlefont, XBrushes.Black, new XRect(marginR, marginR1, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

                    graph.DrawRectangle(lineR, marginR, marginR1 + 25, 350, 2);

                    graph.DrawString(SpecAward1, infofont, XBrushes.Black, new XRect(marginR, marginR1 + 30, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(SpecAward2, infofont, XBrushes.Black, new XRect(marginR, marginR1 + 45, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(SpecAward3, infofont, XBrushes.Black, new XRect(marginR, marginR1 + 60, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(SpecAward4, infofont, XBrushes.Black, new XRect(marginR, marginR1 + 75, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);


                    pdf.Save(saveFileDialog.FileName);
                }
                MessageBox.Show("The PDF File has been Download");
            }
            Application.Restart();
            Environment.Exit(0);
        }
    }
}