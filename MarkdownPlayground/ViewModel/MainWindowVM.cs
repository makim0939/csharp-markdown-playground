using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarkdownPlayground.Model;

namespace MarkdownPlayground.ViewModel
{
    internal class MainWindowVM
    {
        
        public DailyReportModel Report { get; set; }

        public MainWindowVM() 
        {
            DailyReportModel report = new();
            MarkdownFileService.ParseReport(report);
            Console.WriteLine();

            this.Report = report;
        }
    }
}