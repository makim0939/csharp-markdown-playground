using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarkdownPlayground.Model;

namespace MarkdownPlayground.ViewModel
{
    internal class MainWindowVM
    {

        public ObservableCollection<DailyReportModel> Report { get; set; } = []; 


        public MainWindowVM() 
        {
            DailyReportModel report = new();
            MarkdownFileService.ReadMdFile(report);
            Console.WriteLine();

            this.Report.Add(report);
            Console.WriteLine();
        }

        public void ReadMdFile()
        {
            MarkdownFileService.ReadMdFile(Report[0]);
            
        }
    }
}