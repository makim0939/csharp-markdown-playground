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
            Report = new ObservableCollection<DailyReportModel> { report };
        }

        public void ReadMdFile()
        {
            Report[0] = MarkdownFileService.ReadMdFile(Report[0]);
            
        }
    }
}