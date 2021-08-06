namespace BuilderPattern
{
    public abstract class ReportBuilder
    {
        protected Report reportObject;

        public abstract void SetReportType();

        public abstract void SetReportHeader();

        public abstract void SetReportFooter();

        public abstract void SetReportContent();

        public void CreateReport()
        {
            reportObject = new Report();
        }

        public Report GetReport()
        {
            return reportObject;
        }
    }
}
