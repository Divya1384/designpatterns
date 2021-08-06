namespace BuilderPattern
{
    public class PdfReport : ReportBuilder
    {
        public override void SetReportContent()
        {
            reportObject.ReportContent = "PDF Report Content";
        }

        public override void SetReportFooter()
        {
            reportObject.ReportFooter = "PDF Report Footer";
        }

        public override void SetReportHeader()
        {
            reportObject.ReportHeader = "PDF Report Header";
        }

        public override void SetReportType()
        {
            reportObject.ReportType = "PDF Report Type";
        }
    }
}
