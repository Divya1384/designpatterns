namespace BuilderPattern
{
    public class ExcelReport : ReportBuilder
    {
        public override void SetReportContent()
        {
            reportObject.ReportContent = "Excel Report Content";
        }

        public override void SetReportFooter()
        {
            reportObject.ReportFooter = "Excel Report Footer";
        }

        public override void SetReportHeader()
        {
            reportObject.ReportHeader = "Excel Report Header";
        }

        public override void SetReportType()
        {
            reportObject.ReportType = "Excel Report Type";
        }
    }
}
