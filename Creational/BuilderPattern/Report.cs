﻿using System;

namespace BuilderPattern
{
    public class Report
    {
        public string ReportType { get; set; }

        public string ReportHeader { get; set; }

        public string ReportFooter { get; set; }

        public string ReportContent { get; set; }

        public void DisplayReport()
        {
            Console.WriteLine($"Report Type : {ReportType}");
            Console.WriteLine();
            Console.WriteLine($"Report Header : {ReportHeader}");
            Console.WriteLine();
            Console.WriteLine($"Report Footer : {ReportFooter}");
            Console.WriteLine();
            Console.WriteLine($"Report Content : {ReportContent}");
            Console.WriteLine();
        }
    }
}
